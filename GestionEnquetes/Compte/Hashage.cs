using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GestionEnquetes
{
    // Types de hashages disponibles
    public enum HashType { Sha256, Sha384, Sha512 }

    /// <summary>
    /// Encryptage des données sensibles
    /// </summary>
    public static class Hashage
    {
        /// <summary>
        ///  Encrypter le texte selon le mode de hashage (HashType) passé en paramettre.
        /// <link> Salt : https://en.wikipedia.org/wiki/Salt_(cryptography) </link>
        /// </summary>
        /// <param name="p_text">Texte à encrypter</param>
        /// <param name="p_hashType">type de hash</param>
        /// <param name="p_salt">Laisser null, va être generé auotatiquement</param>
        /// <returns>Base64String(Signature hash + salt)</returns>
        public static string Encrypter(string p_text, byte[] p_salt = null, HashType p_hashType = HashType.Sha256)
        {
            int saltMin = 4;
            int saltMax = 16;
            byte[] saltBytes = null;

            if (p_salt != null)
            {
                saltBytes = p_salt;
            }
            else
            {
                // Générer la taille du salt seulement. Random n'est Pas utilisé dans l'encryptage
                Random rd = new Random(Guid.NewGuid().GetHashCode());
                saltBytes = new byte[rd.Next(saltMin, saltMax)];
                // Générer la vraie sequence de valeurs random, qui servira à l'encryptage des données
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(saltBytes);
                rng.Dispose();
            }

            byte[] donneesBrutes = ASCIIEncoding.UTF8.GetBytes(p_text);
            byte[] donneesEtSalt = new byte[donneesBrutes.Length + saltBytes.Length];

            for (int x = 0; x < donneesBrutes.Length; x++)
                donneesEtSalt[x] = donneesBrutes[x];
            for (int y = 0; y < saltBytes.Length; y++)
                donneesEtSalt[donneesBrutes.Length + y] = saltBytes[y];

            // encrypter
            byte[] donneesHashees = null;
            switch (p_hashType)
            {
                case HashType.Sha256:
                    SHA256Managed sha2 = new SHA256Managed();
                    donneesHashees = sha2.ComputeHash(donneesEtSalt);
                    sha2.Dispose();
                    break;
                case HashType.Sha384:
                    SHA384Managed sha3 = new SHA384Managed();
                    donneesHashees = sha3.ComputeHash(donneesEtSalt);
                    sha3.Dispose();
                    break;
                case HashType.Sha512:
                    SHA512Managed sha4 = new SHA512Managed();
                    donneesHashees = sha4.ComputeHash(donneesEtSalt);
                    sha4.Dispose();
                    break;
            }

            byte[] resultat = new byte[donneesHashees.Length + saltBytes.Length];

            for (int x = 0; x < donneesHashees.Length; x++)
                resultat[x] = donneesHashees[x];
            for (int y = 0; y < saltBytes.Length; y++)
                resultat[donneesHashees.Length + y] = saltBytes[y];

            return Convert.ToBase64String(resultat);
        }

        /// <summary>
        /// Verifier si la signature hash du texte (saisi) correspond à la valeur hash (dans la bd)
        /// </summary>
        /// <param name="p_text">texte brute à comparer</param>
        /// <param name="p_valeurHash">La valeur du Hash Original, Base64String(Signature hash + salt)</param>
        /// <param name="p_hashType">Type du Hash, Sha256 par default</param>
        /// <returns>Vrai si les signatures correspondent. Faux sinon</returns>
        public static bool HashValide(string p_text, string p_valeurHash, HashType p_hashType = HashType.Sha256)
        {
            byte[] hashBytes = Convert.FromBase64String(p_valeurHash);
            int taillehash = 0;

            if (p_text == null || p_text == null)
            return false;

            switch (p_hashType)
            {
                case HashType.Sha256: taillehash = 32; break;
                case HashType.Sha384: taillehash = 48; break;
                case HashType.Sha512: taillehash = 64; break;
            }
            byte[] saltbytes = new byte[hashBytes.Length - taillehash];
            for (int x = 0; x < saltbytes.Length; x++)
                saltbytes[x] = hashBytes[taillehash + x];
            string nouveauHash;
            nouveauHash = Encrypter(p_text, saltbytes, p_hashType);
            return (p_valeurHash == nouveauHash);
        }
    }
}

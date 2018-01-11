using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;
using UtilStJ;

namespace GestionEnquetes
{
    public static class RequetesSQL
    {
        private static OleDbConnection m_bd;

        /// <summary>
        /// Connecter à la base des données
        /// </summary>
        /// <param name="p_strAccessConnection"></param>
        public static void Connecterbd(string p_strAccessConnection)
        {
            try
            {
                m_bd = new OleDbConnection(p_strAccessConnection);
                m_bd.Open();
            }
            catch (Exception e)
            {
                MB.AvertirCritique("La base de données n'est pas accessible. « {0} »\n\n" +
                                   "{1}\n\n" +
                                   "Le programme va s'arrêter.\n",
                                   p_strAccessConnection, e.Message);

                Environment.Exit(0);
            }
        }
        /// Fermer la base des données
        public static void FermerBD()
        {
            m_bd.Close();
        }

        public static bool UpdateCompte(Compte p_compte)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Compte " +
                        "SET " +
                        "prénom =?, nom=?, grade=?, mot_de_passe=?, " +
                        "date_naissance=?, telephone=?, email=?, " +
                        "adr_rue=?, adr_ville=?, adr_etat=?, adr_zip=?, adr_pays=? " +
                        "WHERE matricule =?",
                        p_compte.Prenom, p_compte.Nom, p_compte.Grade.ToString(), p_compte.HashPass,
                        p_compte.Naissance.Date.ToShortDateString(), p_compte.Telephone, p_compte.Email,
                        p_compte.Adrss.Rue, p_compte.Adrss.Ville, p_compte.Adrss.Etat, p_compte.Adrss.Zip, p_compte.Adrss.Pays, p_compte.Matricule);

                insert.ExecuteNonQuery();
                return true;
            }
            catch(Exception e) { }
            return false;
        }

        /// <summary>
        /// Ajouter un Compte à la base de donnée
        /// </summary>
        /// <param name="p_compte"></param>
        /// <returns>true quand operation reussit, false sinon</returns>
        public static bool AjouterCompte(Compte p_compte)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Compte(matricule, prénom, nom, grade, mot_de_passe, " +
                "date_naissance, telephone, email, " +
                "adr_rue, adr_ville, adr_etat, adr_zip, adr_pays) " +
                "VALUES(?,?,?,?,? ,?,?,?, ?,?,?,?,?)",
                p_compte.Matricule, p_compte.Prenom, p_compte.Nom, p_compte.Grade.ToString(), p_compte.HashPass,
                p_compte.Naissance.Date.ToShortDateString(), p_compte.Telephone, p_compte.Email,
                p_compte.Adrss.Rue, p_compte.Adrss.Ville, p_compte.Adrss.Etat, p_compte.Adrss.Zip, p_compte.Adrss.Pays);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("risque de doublons"))
                {
                    try
                    {
                        BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Compte " +
                        "SET mot_de_passe=? " +
                        "WHERE matricule =?",
                        p_compte.HashPass, p_compte.Matricule);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MB.Avertir(ex.Message);
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Recherche et retourne le dernier numéro de compte saisit.
        /// </summary>
        /// <returns></returns>
        public static int SQLLireNumeroCompte()
        {
            return BdCompteur.Valeur(m_bd, "numeroCompte");
        }

        public static int NbComptes()
        {
            return BdScalar.Get<int>(m_bd, "SELECT COUNT(*) FROM Compte");
        }

        public static int numeroCompteSansIncrementer()
        {
            return BdScalar.Get<int>(m_bd,
                   "SELECT valeurCompteur " +
                   "FROM Compteurs " +
                   "WHERE nomCompteur=?", "numeroCompte");
        }

        /// <summary>
        /// Revoie la list de tous les tous les comptes
        /// </summary>
        /// <returns>Toutes les catégories</returns>
        public static IEnumerable<Compte> ListeTousLesComptes()
        {
            using (BdReader bdr = new BdReader(m_bd,
                "SELECT matricule, prénom, nom, grade, mot_de_passe, " +
                        "date_naissance, telephone, email, " +
                        "adr_rue, adr_ville, adr_etat, adr_zip, adr_pays " +
                        "FROM Compte " +
                        "ORDER BY grade"))
            {
                while (bdr.Read())
                {
                    Grade grade;
                    Enum.TryParse(bdr.GetString(3), out grade);
                    if (!Enum.IsDefined(typeof(Grade), grade))
                    {
                        MB.AvertirCritique("Lecture du grad n'est pas valide.");
                        yield return null;
                    }
                    Compte compte = new Compte(bdr.GetString(1), bdr.GetString(2), bdr.GetInt32(0), bdr.GetDateTime(5),
                                    new Adresse(bdr.GetString(8), bdr.GetString(9), bdr.GetString(10), bdr.GetString(11), bdr.GetString(12)),
                                    bdr.GetString(6), bdr.GetString(7), grade, bdr.GetString(4));
                    yield return compte;
                }
            }
        }


        /// <summary>
        /// lire un Compte à partir de la base de donnée
        /// </summary>
        public static Compte SQLLireCompte(string p_matricule)
        {
            Compte compte = null;
            int matricule;

            if (!Int32.TryParse(p_matricule, out matricule))
                return null;

            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT matricule, prénom, nom, grade, mot_de_passe, " +
                        "date_naissance, telephone, email, " +
                        "adr_rue, adr_ville, adr_etat, adr_zip, adr_pays " +
                        "FROM Compte " +
                        "WHERE matricule=?", p_matricule))
                {
                    if (!bdr.Read() /*&& !bdr.IsDBNull(1) */)
                        return null;

                    Grade grade;
                    Enum.TryParse(bdr.GetString(3), out grade);
                    if (!Enum.IsDefined(typeof(Grade), grade))
                    {
                        MB.AvertirCritique("Le grade n'est pas valide.");
                        return null;
                    }

                    compte = new Compte(bdr.GetString(1), bdr.GetString(2), bdr.GetInt32(0), bdr.GetDateTime(5),
                                    new Adresse(bdr.GetString(8), bdr.GetString(9), bdr.GetString(10), bdr.GetString(11), bdr.GetString(12)),
                                    bdr.GetString(6), bdr.GetString(7), grade, bdr.GetString(4));
                }
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
            }
            return compte;
        }

        /// <summary>
        /// Requete SQL pour Ajouter Etiquete
        /// </summary>
        public static bool SQLAjouterEtiquete(string p_noDossier, int p_matricule)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Dossier_policier(no_dossier, matricule_policier) " +
                "VALUES(?,?)",
                p_noDossier, p_matricule);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Requete SQL pour Supprimer Etiquete
        /// </summary>
        public static bool SQLSupprimerEtiquete(string p_noDossier, int p_matricule)
        {
            BdNonQuery delete = new BdNonQuery(m_bd,
                "DELETE FROM Dossier_policier " +
                "WHERE no_dossier = ? AND matricule_policier = ?",
                p_noDossier, p_matricule);
            try
            {
                delete.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Requete SQL pour Verifier Etiquete
        /// </summary>
        public static bool SQLVerifierEtiquete(string p_noDossier, int p_matricule)
        {
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT no_dossier " +
                        "FROM Dossier_policier " +
                        "WHERE no_dossier = ? AND matricule_policier = ?",
                        p_noDossier, p_matricule.ToString()))
                {
                    return bdr.Read();
                }
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
            }
            return false;
        }

        /// <summary>
        /// Requete SQL pour chercher un compte selon l'email en parametre
        /// </summary>
        public static int ChercherCompteSelonEmail(string p_email)
        {
            int matricule;

            //if (!Int32.TryParse(p_matricule, out matricule))
            //    return null;

            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT matricule " +
                        "FROM Compte " +
                        "WHERE email=?", p_email))
                {
                    if (!bdr.Read() /*&& !bdr.IsDBNull(1) */)
                        return -1;
                    matricule = bdr.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
                matricule = -1;
            }
            return matricule;
        }

        /// <summary>
        /// Supprimer un Compte
        /// </summary>
        public static void SupprimerCompte(string p_matricule)
        {
            BdNonQuery delete = new BdNonQuery(m_bd,
                "DELETE FROM Compte " +
                "WHERE matricule=?",
                p_matricule);
            try
            {
                delete.ExecuteNonQuery();
            }
            catch(Exception e)
            {

            }
        }

        /// <summary>
        /// Requete SQL pour se connecter
        /// </summary>
        public static Compte SQLLogin(string p_matricule, string p_textPasse)
        {
            int nombre;
            if (!Int32.TryParse(p_matricule, out nombre))
                return null;

            Compte compte = SQLLireCompte(p_matricule);
            if (compte == null)
                return null;
            string hp = compte.HashPass;
            if (compte.Matricule == nombre &&
                Hashage.HashValide(p_textPasse, compte.HashPass))
                return compte;
            return null;
        }

        /// <summary>
        /// lire un Compte à partir de la base de donnée
        /// </summary>
        public static List<Dossier> SQLChercherDossierAvecMatricule(int p_matricule)
        {
            List<Dossier> listeDossier = new List<Dossier>();
            List<string> ListNumeroDossier = SQLChercherListeNumeroDansDestinationAvecMatricule(p_matricule);

            foreach (string numDossier in ListNumeroDossier.Distinct().ToList())
            {
                listeDossier.Add(SQLChercherDossierParNumero(numDossier));
            }

            return listeDossier;
        }

        /// <summary>
        /// Requete SQL pour lister tous les dossiers
        /// </summary>
        public static List<Dossier> SQLTousLesDossiers()
        {
            List<Dossier> listeDossier = new List<Dossier>();
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT numéro_dossier " +
                        "FROM Dossier"))
                {
                    while (bdr.Read())
                    {
                        listeDossier.Add(SQLChercherDossierParNumero(bdr.GetString(0)));
                    }
                }
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
            }
            return listeDossier;
        }

        /// <summary>
        /// Requete SQL pour chercher les dossiers BEC
        /// </summary>
        public static List<Dossier> SQLChercherDossierBEC()
        {
            List<Dossier> listeDossier = new List<Dossier>();
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT numéro_dossier " +
                        "FROM Dossier"))
                {
                    while (bdr.Read())
                    {
                        string noDossier = bdr.GetString(0);
                        if (SQLChercherDestinationAvecNoDossier(noDossier).CodeDestination == CodeDestination.BEC)
                        {
                            listeDossier.Add(SQLChercherDossierParNumero(noDossier));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
            }
            return listeDossier;
        }

        /// <summary>
        /// Requete SQL chercher les dossiers ouverts
        /// </summary>
        public static List<Dossier> SQLChercherDossierOuvert(int p_matricule)
        {
            List<String> listeNoDossier = SQLChercherListeNumeroDansDestinationAvecMatricule(p_matricule);
            List<Dossier> listeDossier = new List<Dossier>();
            foreach(string no in listeNoDossier)
            {
                if (SQLChercherDestinationAvecNoDossier(no).CodeDestination == CodeDestination.ARC)
                {
                    listeNoDossier.Remove(no);
                }
            }
            listeNoDossier = listeNoDossier.Distinct().ToList();
            foreach (string no in listeNoDossier)
            {
                listeDossier.Add(SQLChercherDossierParNumero(no));
            }
            return listeDossier;
        }

        /// <summary>
        /// Ajouter un Rapport d'Enquête
        /// </summary>
        /// <param name="p_rapport"></param>
        /// <returns></returns>
        public static bool SQLAjouterRapportEnquete(RapportEnquete p_rapport, string p_noDossier)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Rapport_Enquete(remarques, no_dossier, matricule_policier) " +
                "VALUES(?,?,?)",
                p_rapport.Contenu, p_noDossier, p_rapport.Matricule.Matricule);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("risque de doublons"))
                {
                    try
                    {
                        BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Rapport_Enquete " +
                        "SET remarques = ? " +
                        "WHERE matricule_policier=? AND no_dossier=?",
                        p_rapport.Contenu, p_rapport.Matricule.Matricule, p_noDossier);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MB.Avertir(ex.Message);
                        return false;
                    }
                }
                else
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Lit et ressort un compte dans la base de données.
        /// </summary>
        /// <param name="p_noDossier">Numéro du dossier lié au rapport (Un seul rapport par dossier)</param>
        /// <returns></returns>
        public static RapportEnquete SQLLireRapportEnquete(string p_noDossier)
        {
            RapportEnquete rapport = null;
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT remarques, matricule_policier " +
                        "FROM Rapport_Enquete " +
                        "WHERE no_dossier=?", p_noDossier))
                {
                    if (!bdr.Read() /*&& !bdr.IsDBNull(1) */)
                        return null;

                    rapport = new RapportEnquete(bdr.GetString(0), SQLLireCompte(bdr.GetString(1)));
                }
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
            }
            return rapport;
        }

        public static void SQLSupprimerRapportEnquete(string p_noDossier)
        {
            BdNonQuery delete = new BdNonQuery(m_bd,
                "DELETE FROM Rapport_Enquete " +
                "WHERE no_dossier=?",
                p_noDossier);
            try
            {
                delete.ExecuteNonQuery();
            }
            catch { }
        }

        /// <summary>
        /// Requete SQL pour obtenir le code du status du dossier
        /// </summary>
        public static string SQLGetCodeStatutAvecNoDossier(string p_noDossier)
        {
            string code = "";
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT code_statut " +
                        "FROM Statut " +
                        "WHERE no_dossier=?", p_noDossier))
                {
                    if (bdr.Read() /*&& !bdr.IsDBNull(1) */)
                        code = bdr.GetString(0);
                }
            }
            catch { }
            return code;
        }

        /// <summary>
        /// Requete SQL pour obtenir la matricule du policier en charge du dossier
        /// </summary>
        public static string SQLGetMatriculePolicierAvecNumero(string p_noDossier)
        {
            string matricule = "";

            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT matricule_policier " +
                        "FROM Statut " +
                        "WHERE no_dossier=?", p_noDossier))
                {
                    if (bdr.Read() /*&& !bdr.IsDBNull(1) */)
                        matricule = bdr.GetString(0);
                }
            }
            catch { }
            return matricule;
        }

        /// <summary>
        /// Requete SQL pour chercher dossier par numero
        /// </summary>
        public static Dossier SQLChercherDossierParNumero(string p_noDossier)
        {
            Dossier dossier = null;
            Statut statut;
            List<Vehicule> listeVehicule = new List<Vehicule>();
            List<Personne> listePersonne = new List<Personne>();
            RapportAccident rapportAccident;
            RapportEnquete rapportEnquete;
            RapportEvenement rapportEvenement;
            Destination destination;

            foreach (int i in SQLChercherNoPersonneAvecNoDossier(p_noDossier))
            {
                listePersonne.Add(SQLChercherPersonneAvecNoPersonne(i));
            }

            foreach (int i in SQLChercherNoVehiculeAvecNoDossier(p_noDossier))
            {
                listeVehicule.Add(SQLChercherVehiculeAvecNoVehicule(i));
            }

            statut = SQLChercherStatutAvecNoDossier(p_noDossier);
            rapportAccident = SQLChercherRapportAccidentAvecNoDossier(p_noDossier);
            rapportEnquete = SQLChercherRapportEnqueteAvecNoDossier(p_noDossier);
            rapportEvenement = SQLChercherRapportEvenementAvecNoDosser(p_noDossier);
            destination = SQLChercherDestinationAvecNoDossier(p_noDossier);

            dossier = new Dossier(p_noDossier, statut, rapportAccident, rapportEvenement,
                rapportEnquete, destination, listeVehicule, listePersonne);

            return dossier;
        }

        public static List<int> SQLChercherNoPersonneAvecNoDossier(string p_noDossier)
        {
            List<int> numeros = new List<int>();
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT no_personne " +
                        "FROM Personne_Dossier " +
                        "WHERE no_dossier=?", p_noDossier))
                {
                    while (bdr.Read())
                    {
                        numeros.Add(bdr.GetInt32(0));
                    }

                }
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
            }

            return numeros;
        }

        public static Personne SQLChercherPersonneAvecNoPersonne(int p_noPersonne)
        {
            Personne personne = null;
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT nom, prénom, date_naissance, " +
                        "adresse, code_personne " +
                        "FROM Personne " +
                        "WHERE numéro_personne=?", p_noPersonne))
                {
                    if (bdr.Read())
                    {
                        CodePersonne code;
                        Enum.TryParse(bdr.GetString(4), out code);

                        personne = new Personne(p_noPersonne, bdr.GetString(0), bdr.GetString(1), bdr.GetDateTime(2), bdr.GetString(3), code);
                    }
                }
            }
            catch { }

            return personne;
        }

        public static List<int> SQLChercherNoVehiculeAvecNoDossier(string p_noDossier)
        {
            List<int> numeros = new List<int>();
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT no_véhicule " +
                        "FROM Vehicule_Dossier " +
                        "WHERE no_dossier=?", p_noDossier))
                {
                    while (bdr.Read())
                    {
                        numeros.Add(bdr.GetInt32(0));
                    }

                }
            }
            catch (Exception e)
            {
                MB.Avertir(e.Message);
            }

            return numeros;
        }

        public static Vehicule SQLChercherVehiculeAvecNoVehicule(int p_noVehicule)
        {
            Vehicule Vehicule = null;
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT marque, modèle, année, " +
                        "statut_véhicule, numéro_personne " +
                        "FROM Vehicule " +
                        "WHERE no_véhicule=?", p_noVehicule))
                {
                    if (bdr.Read())
                    {
                        CodeVehicule code;
                        Enum.TryParse(bdr.GetString(3), out code);
                        Personne personne = SQLChercherPersonneAvecNoPersonne(bdr.GetInt32(4));
                        Vehicule = new Vehicule(p_noVehicule, bdr.GetString(0), bdr.GetString(1), bdr.GetInt32(2), code, personne);
                    }
                }
            }
            catch (Exception e) { }

            return Vehicule;
        }

        public static Statut SQLChercherStatutAvecNoDossier(string p_noDossier)
        {
            Statut statut = null;
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT date_heure_statut, code_statut, matricule_policier " +
                        "FROM Statut " +
                        "WHERE no_dossier=?", p_noDossier))
                {
                    if (bdr.Read())
                    {
                        CodeStatut code;
                        Enum.TryParse(bdr.GetString(1), out code);
                        statut = new Statut(p_noDossier, bdr.GetDateTime(0), code, bdr.GetInt32(2));
                    }
                }
            }
            catch { }

            return statut;
        }

        public static RapportAccident SQLChercherRapportAccidentAvecNoDossier(string p_noDossier)
        {
            RapportAccident rapportAccident = null;
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT no_rapport, adr_rue, adr_ville, adr_etat, adr_zip, adr_pays, adr_noCivique, date_heure, remarque " +
                        "FROM Rapport_Accident " +
                        "WHERE no_dossier=?", p_noDossier))
                {
                    if (bdr.Read())
                    {
                        Adresse adresse = new Adresse(bdr.GetString(1), bdr.GetString(2), bdr.GetString(3), bdr.GetString(4), bdr.GetString(5), bdr.GetStringOuNull(6));
                        List<Vehicule> listeVehicule = SQLGetListeVehiculeRapport(bdr.GetInt32(0));
                        rapportAccident = new RapportAccident(bdr.GetInt32(0), listeVehicule, adresse, DateTime.Parse(bdr.GetString(7)), bdr.GetString(8));
                    }
                }
            }
            catch { }

            return rapportAccident;
        }

        public static List<Vehicule> SQLGetListeVehiculeRapport(int p_noRapport)
        {
            List<int> listeNumeroVehicule = new List<int>();
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT no_véhicule " +
                        "FROM Rapport_Accident_Vehicule " +
                        "WHERE no_rapport=?", p_noRapport))
                {
                    while (bdr.Read())
                    {
                        listeNumeroVehicule.Add(bdr.GetInt32(0));
                    }
                }
            }
            catch { }

            List<Vehicule> listeVehicule = new List<Vehicule>();

            try
            {
                foreach (int i in listeNumeroVehicule)
                {
                    using (BdReader bdr = new BdReader(m_bd,
                        "SELECT no_véhicule, marque, modèle, année, statut_véhicule, numéro_personne " +
                        "FROM Vehicule " +
                        "WHERE no_véhicule=?", i))
                    {
                        if (bdr.Read())
                        {
                            CodeVehicule code;
                            Enum.TryParse(bdr.GetString(4), out code);
                            listeVehicule.Add(new Vehicule(bdr.GetInt32(0), bdr.GetString(1),
                                bdr.GetString(2), bdr.GetInt32(3), code, SQLChercherPersonneAvecNoPersonne(bdr.GetInt32(5))));
                        }
                    }
                }

            }
            catch { }

            return listeVehicule;
        }




        public static RapportEnquete SQLChercherRapportEnqueteAvecNoDossier(string p_noDossier)
        {
            RapportEnquete rapportEnquete = null;
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT remarques, matricule_policier " +
                        "FROM Rapport_Enquete " +
                        "WHERE no_dossier=?", p_noDossier))
                {
                    if (bdr.Read())
                    {
                        Compte compte = SQLChercherCompteAvecMatricule(bdr.GetInt32(1));
                        rapportEnquete = new RapportEnquete(bdr.GetString(0), compte);
                    }
                }
            }
            catch { }

            return rapportEnquete;
        }

        public static Compte SQLChercherCompteAvecMatricule(int p_matricule)
        {
            Compte compte = null;
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                        "SELECT prénom, nom, grade, mot_de_passe, date_naissance, " +
                        "telephone, email, adr_rue, adr_ville, adr_etat, adr_zip, adr_pays " +
                        "FROM Compte " +
                        "WHERE matricule=?", p_matricule))
                {
                    if (bdr.Read())
                    {
                        Grade grade;
                        Enum.TryParse(bdr.GetString(2), out grade);
                        Adresse adresse = new Adresse(bdr.GetString(7), bdr.GetString(8), bdr.GetString(9), bdr.GetString(10), bdr.GetString(11));
                        compte = new Compte(bdr.GetString(0), bdr.GetString(1), p_matricule, bdr.GetDateTime(4), adresse, bdr.GetString(5), bdr.GetString(6), grade, bdr.GetString(3));
                    }
                }
            }
            catch { }

            return compte;
        }

        public static RapportEvenement SQLChercherRapportEvenementAvecNoDosser(string p_noDossier)
        {
            RapportEvenement rapportEvenement = null;
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                    "SELECT code_nature, adr_rue, adr_ville, adr_etat, adr_zip, adr_pays, adr_noCivique, date_heure_rapport, remarques " +
                    "FROM Rapport_Evenement " +
                    "WHERE no_dossier=?", p_noDossier))
                {
                    if (bdr.Read())
                    {
                        int code;
                        Int32.TryParse(bdr.GetString(0), out code);
                        CodeDeNature codeNature = CodeDeNature.getCodeNature(code);
                        Adresse adresse = new Adresse(bdr.GetString(1), bdr.GetString(2), bdr.GetString(3), bdr.GetString(4), bdr.GetString(5), bdr.GetStringOuNull(6));
                        rapportEvenement = new RapportEvenement(codeNature, DateTime.Parse(bdr.GetString(7)), adresse, bdr.GetString(8));
                    }
                }
            }
            catch { }

            return rapportEvenement;
        }

        public static Destination SQLChercherDestinationAvecNoDossier(string p_noDossier)
        {
            List<Destination> destination = new List<Destination>();

            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                    "SELECT date_heure_transfert, code_destination, remarques, matricule_policier " +
                    "FROM Destination " +
                    "WHERE numero_dossier=?", p_noDossier))
                {
                    while(bdr.Read())
                    {
                        CodeDestination code;
                        Enum.TryParse(bdr.GetString(1), out code);

                        destination.Add(new Destination(bdr.GetDateTime(0), code, bdr.GetString(2), p_noDossier, bdr.GetInt32(3)));
                    }
                }
            }
            catch { }

            return destination.OrderByDescending(x => x.HeureTransfer).First();           
        }

        public static List<Destination> SQLChercherListeDestinationNoDossier(string p_noDossier)
        {
            List<Destination> destinations = new List<Destination>();
            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                    "SELECT date_heure_transfert, code_destination, remarques, matricule_policier " +
                    "FROM Destination " +
                    "WHERE numero_dossier=?", p_noDossier))
                {
                    while (bdr.Read())
                    {
                        CodeDestination code;
                        Enum.TryParse(bdr.GetString(1), out code);

                        destinations.Add(new Destination(bdr.GetDateTime(0), code, bdr.GetString(2), p_noDossier, bdr.GetInt32(3)));
                    }
                }
            }
            catch { }

            return destinations;
        }

        /// <summary>
        /// Fonction qui permet d'obternir la liste des numéros associés au matricule.
        /// Pour aller chercher tout les dossiers qui ont déja appartenu à un matricule.
        /// </summary>
        /// <param name="p_matricule"></param>
        /// <returns></returns>
        public static List<string> SQLChercherListeNumeroDansDestinationAvecMatricule(int p_matricule) // TODO : RAPETISSER LE NOM JESUS...
        {
            List<string> numeros = new List<string>();

            try
            {
                using (BdReader bdr = new BdReader(m_bd,
                    "SELECT numero_dossier " +
                    "FROM Destination " +
                    "WHERE matricule_policier=?", p_matricule))
                {
                    while (bdr.Read())
                    {
                        numeros.Add(bdr.GetString(0));
                    }
                }
            }
            catch { }

            return numeros;
        }

        public static void SQLEnregistrerDossier(Dossier p_dossier)
        {
            SQLEnregistrerNoDossier(p_dossier.Numero);          //Fait

            foreach (Personne personne in p_dossier.Personnes)
                SQLLierPersonneDossier(personne, p_dossier);

            foreach (Vehicule vehicule in p_dossier.Vehicules)
                SQLLierVehiculeDossier(vehicule, p_dossier);

            if (p_dossier.RapportEnquete != null)
                SQLAjouterRapportEnquete(p_dossier.RapportEnquete, p_dossier.Numero);

            if (p_dossier.RapportAccident != null)
                SQLEnregistrerRapportAccident(p_dossier.RapportAccident, p_dossier.Numero);

            if (p_dossier.RapportEvenement != null)
                SQLEnregistrerRapportEvenement(p_dossier.RapportEvenement, p_dossier.Numero);

            SQLEnregistrerStatut(p_dossier.Statut, p_dossier.Numero);
            SQLEnregistrerDestination(p_dossier.Destination, p_dossier.Numero);
        }

        public static bool SQLEnregistrerNoDossier(string p_numéro)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Dossier(numéro_dossier) " +
                "VALUES(?)",
                p_numéro);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (!e.Message.Contains("risque de doublons"))
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool SQLLierPersonneDossier(Personne p_personne, Dossier p_dossier)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Personne_dossier(no_personne, no_dossier) " +
                "VALUES(?,?)",
                p_personne.Numero, p_dossier.Numero);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (!e.Message.Contains("risque de doublons"))
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool SQLEnregistrerPersonne(Personne p_personne)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Personne(numéro_personne, nom, prénom, date_naissance, adresse, code_personne) " +
                "VALUES(?,?,?,?,?,?)",
                p_personne.Numero, p_personne.Nom, p_personne.Prenom, p_personne.DateNaissance, p_personne.Adresse, p_personne.CodePersonne.ToString());

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("risque de doublons"))
                {
                    try
                    {
                        BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Personne " +
                        "SET nom = ?, prénom = ?, date_naissance = ?, adresse = ?, code_personne = ? " +
                        "WHERE numéro_personne = ?",
                        p_personne.Nom, p_personne.Prenom, p_personne.DateNaissance, p_personne.Adresse, p_personne.CodePersonne.ToString(), p_personne.Numero);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MB.Avertir(ex.Message);
                        return false;
                    }
                }
                else
                {
                    MB.Avertir(e.Message);
                    return false;
                }

            }
            return true;
        }

        public static bool SQLLierVehiculeDossier(Vehicule p_vehicule, Dossier p_dossier)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Vehicule_Dossier(no_dossier, no_véhicule) " +
                "VALUES(?,?)",
                p_dossier.Numero, p_vehicule.NoVehicule);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (!e.Message.Contains("risque de doublons"))
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool SQLEnregistrerVehicule(Vehicule p_vehicule)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Vehicule(no_véhicule, marque, modèle, année, statut_véhicule, numéro_personne) " +
                "VALUES(?,?,?,?,?,?)",
                p_vehicule.NoVehicule, p_vehicule.Marque, p_vehicule.Modele, p_vehicule.Annee, p_vehicule.CodeVehicule.ToString(), p_vehicule.Proprietaire.Numero);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("risque de doublons"))
                {
                    try
                    {
                        BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Vehicule " +
                        "SET marque = ?, modèle = ?, année = ?, statut_véhicule = ?, numéro_personne = ? " +
                        "WHERE no_véhicule = ?",
                        p_vehicule.Marque, p_vehicule.Modele, p_vehicule.Annee, p_vehicule.CodeVehicule.ToString(), p_vehicule.Proprietaire.Numero, p_vehicule.NoVehicule);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MB.Avertir(ex.Message);
                        return false;
                    }
                }
                else
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool SQLEnregistrerRapportAccident(RapportAccident p_rapport, string p_noDossier)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Rapport_Accident(no_rapport, no_dossier, adr_rue, adr_ville, adr_etat, adr_zip, adr_pays, adr_noCivique, date_heure, remarque) " +
                "VALUES(?,?,?,?,?,?,?,?,?,?)",
                p_rapport.NoRapport, p_noDossier, p_rapport.Adresse.Rue, p_rapport.Adresse.Ville, p_rapport.Adresse.Etat,
                p_rapport.Adresse.Zip, p_rapport.Adresse.Pays, p_rapport.Adresse.NoCivique, p_rapport.DateEtHeure, p_rapport.Remarques);

                insert.ExecuteNonQuery();


                foreach (Vehicule vehicule in p_rapport.VehiculesImpliques)
                {
                    try
                    {
                        insert = new BdNonQuery(m_bd,
                        "INSERT INTO Rapport_Accident_Vehicule(no_véhicule, no_rapport) " +
                        "VALUES(?,?)",
                        vehicule.NoVehicule, p_rapport.NoRapport);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        if (!e.Message.Contains("risque de doublons"))
                        {
                            MB.Avertir(e.Message);
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("risque de doublons"))
                {
                    try
                    {
                        BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Rapport_Accident " +
                        "SET no_dossier =?, adr_rue =?, adr_ville =?, adr_etat =?, adr_zip=?, adr_pays=?, adr_noCivique=?, date_heure=?, remarque=? " +
                        "WHERE no_rapport =?",
                        p_noDossier, p_rapport.Adresse.Rue, p_rapport.Adresse.Ville, p_rapport.Adresse.Etat,
                        p_rapport.Adresse.Zip, p_rapport.Adresse.Pays, p_rapport.Adresse.NoCivique, p_rapport.DateEtHeure, p_rapport.Remarques, p_rapport.NoRapport);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MB.Avertir(ex.Message);
                        return false;
                    }
                }
                else
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool SQLEnregistrerRapportEvenement(RapportEvenement p_rapport, string p_noDossier)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Rapport_Evenement(no_dossier, code_nature, adr_rue, adr_ville, adr_etat, adr_zip, adr_pays, adr_noCivique, date_heure_rapport, remarques) " +
                "VALUES(?,?,?,?,?,?,?,?,?,?)",
                p_noDossier, p_rapport.CodeDeNature.Code.ToString(), p_rapport.Adresse.Rue, p_rapport.Adresse.Ville,
                p_rapport.Adresse.Etat, p_rapport.Adresse.Zip, p_rapport.Adresse.Pays, p_rapport.Adresse.NoCivique, p_rapport.DateEtHeure, p_rapport.Remarques);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("risque de doublons"))
                {
                    try
                    {
                        BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Rapport_Evenement " +
                        "SET code_nature = ?, adr_rue=?, adr_ville = ?, adr_etat = ?, adr_zip=?, adr_pays=?, adr_noCivique=?, date_heure_rapport=?, remarques=? " +
                        "WHERE no_dossier = ?",
                        p_rapport.CodeDeNature.Code.ToString(),p_rapport.Adresse.Rue, p_rapport.Adresse.Ville, p_rapport.Adresse.Etat,
                        p_rapport.Adresse.Zip, p_rapport.Adresse.Pays, p_rapport.Adresse.NoCivique, p_rapport.DateEtHeure, p_rapport.Remarques, p_noDossier);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MB.Avertir(ex.Message);
                        return false;
                    }
                }
                else
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool SQLEnregistrerStatut(Statut p_statut, string p_noDossier)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Statut(date_heure_statut, code_statut, matricule_policier, no_dossier) " +
                "VALUES(?, ?, ?, ?)",
                p_statut.DateHeure, p_statut.CodeStatut.ToString(), p_statut.Matricule, p_noDossier);

                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("risque de doublons"))
                {
                    try
                    {
                        BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Statut " +
                        "SET date_heure_statut=?, code_statut = ?, matricule_policier=? " +
                        "WHERE no_dossier = ?",
                        p_statut.DateHeure, p_statut.CodeStatut.ToString(), p_statut.Matricule, p_noDossier);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MB.Avertir(ex.Message);
                        return false;
                    }
                }
                else
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool SQLEnregistrerDestination(Destination p_destination, string p_noDossier)
        {
            try
            {
                BdNonQuery insert = new BdNonQuery(m_bd,
                "INSERT INTO Destination(date_heure_transfert, code_destination, remarques, numero_dossier, matricule_policier) " +
                "VALUES(?,?,?,?,?)",
                p_destination.HeureTransfer, p_destination.CodeDestination.ToString(),
                p_destination.Remarque, p_noDossier, p_destination.MatriculePolicier);
                insert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("risque de doublons"))
                {
                    try
                    {
                        BdNonQuery insert = new BdNonQuery(m_bd,
                        "UPDATE Destination " +
                        "SET code_destination=?, remarques = ?, numero_dossier=?, matricule_policier=? " +
                        "WHERE date_heure_transfert=?",
                        p_destination.CodeDestination.ToString(), p_destination.Remarque, p_noDossier, 
                        p_destination.MatriculePolicier, p_destination.HeureTransfer);

                        insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MB.Avertir(ex.Message);
                        return false;
                    }
                }
                else
                {
                    MB.Avertir(e.Message);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Va chercher le numéro incrémentable du dernier dossier créé dans la BD.
        /// </summary>
        /// <returns></returns>
        public static int SQLLireNumeroDossier()
        {
            return BdCompteur.Valeur(m_bd, "numeroDossier");
        }

        /// <summary>
        /// Recherche et retourne le dernier numéro de véhicule enregistré dans la BD.
        /// </summary>
        /// <returns></returns>
        public static int SQLLireNumeroVehicule()
        {
            return BdCompteur.Valeur(m_bd, "numeroVehicule");
        }

        /// <summary>
        /// Recherche et retourne le dernier numéro de personne saisit.
        /// </summary>
        /// <returns></returns>
        public static int SQLLireNumeroPersonne()
        {
            return BdCompteur.Valeur(m_bd, "numeroPersonne");
        }

        /// <summary>
        /// Recherche et retourne le dernier numéro de rapport saisit.
        /// </summary>
        /// <returns></returns>
        public static int SQLLireNumeroRapport()
        {
            return BdCompteur.Valeur(m_bd, "numeroRapport");
        }

    }
}
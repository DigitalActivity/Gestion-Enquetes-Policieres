using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionEnquetes
{
    static public class Utilitaires
    {
        /// <summary>
        /// Envoyer un message pour reset le mot de passe
        /// </summary>
        /// <param name="p_recipient">email de l'utilisateur</param>
        /// <param name="p_hashPasse">hash passe a conserver dans la base des données</param>
        /// <returns></returns>
        public static bool sendResetMessage(string p_recipient, out string p_hashPasse)
        {
            p_hashPasse = "";
            if (!IsValidEmail(p_recipient))
                return false;
            // SMTP server (par google)
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            p_hashPasse = Base64Encode(Guid.NewGuid().GetHashCode().ToString()); // passe provisoire généré automatiquement
            SmtpServer.Port = 587;
            string secret = Base64Decode("VWt4TmNteHRJeU14"); // Mot de passe pour se connecter à google
            SmtpServer.Credentials = new System.Net.NetworkCredential("youniversion", Base64Decode(secret) + "00");
            SmtpServer.EnableSsl = true;
            // Message
            mail.From = new MailAddress("youniversion@gmail.com");
            mail.To.Add(p_recipient);
            mail.Subject = "reinitialiser le mot de passe";
            mail.Body = "Utilisez ce mot de passe pour reinitialiser votre mot de passe : \n" +
                        p_hashPasse;
            try
            {        
                // Set the method that is called back when the send operation ends.
                SmtpServer.SendCompleted += new
                SendCompletedEventHandler(SendCompletedCallback);
                string userState = "test message1";
                SmtpServer.SendAsync(mail, userState);
                p_hashPasse = Hashage.Encrypter(p_hashPasse);
            }
            catch (Exception ex)
            {
                SmtpServer.Dispose();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Verifier si email est valide
        /// </summary>
        /// <param name="email">email à verifier</param>
        /// <returns>vrai si email valide, faix sinon</returns>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifier si un telephone est valide
        /// </summary>
        /// <param name="p_phone"></param>
        /// <returns></returns>
        public static bool IsValidePhone(string p_phone)
        {
            // Regex Telephone pour canada et US
            Regex regexPhoneNumber = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            return regexPhoneNumber.IsMatch(p_phone);   
        }

        /// <summary>
        /// fonction Callback : previent quand un evenement asynchrone est complété
        /// </summary>
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                Console.WriteLine("Message sent.");
            }
        }

        // Encoder 64
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        // Decoder 64
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}

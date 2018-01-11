using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilStJ;

namespace GestionEnquetes
{
    public partial class DlgAjoutVehicule : DialogueOkAnnuler
    {
        private Vehicule m_vehicule;
        private List<Personne> m_listPersonnes;
        private TypeDeSaisie m_typeDeSaisie;

        public DlgAjoutVehicule(TypeDeSaisie p_operation, Vehicule p_vehicule, List<Personne> p_listePersonne)
        {
            InitializeComponent();
            m_vehicule = p_vehicule;
            m_typeDeSaisie = p_operation;

            if (p_listePersonne != null)
                m_listPersonnes = p_listePersonne;
            else
                m_listPersonnes = new List<Personne>();

            InitialiserComboBoxPersonne();
            InitialiserComboBoxCodeVehicule();

            //Lors de modification
            if (m_typeDeSaisie == TypeDeSaisie.Modification)
            {
                RemplirPourModification();
            }
            else if(m_typeDeSaisie == TypeDeSaisie.Affichage)
            {
                RemplirPourAffichage();
            }
        }

        private void RemplirPourAffichage()
        {
            RemplirPourModification();
            textBoxMarque.Enabled = false;
            textBoxModele.Enabled = false;
            textBoxAnnee.Enabled = false;
            comboBoxStatut.Enabled = false;
            comboBoxPersonne.Enabled = false;
            buttonAjouterPersonne.Enabled = false;
        }

        /// <summary>
        /// Méthode qui remplit les champs avec les informations du véhicule passé en paramètre.
        /// </summary>
        private void RemplirPourModification()
        {
            textBoxMarque.Text = m_vehicule.Marque;
            textBoxModele.Text = m_vehicule.Modele;
            textBoxAnnee.Text = m_vehicule.Annee.ToString();
            comboBoxStatut.SelectedItem = m_vehicule.CodeVehicule;
            comboBoxPersonne.SelectedItem = m_vehicule.Proprietaire;
        }

        private void InitialiserComboBoxCodeVehicule()
        {
            comboBoxStatut.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (CodeVehicule code in Enum.GetValues(typeof(CodeVehicule)))
                comboBoxStatut.Items.Add(code);

            comboBoxStatut.SelectedIndex = 0;
        }

        private void InitialiserComboBoxPersonne()
        {
            comboBoxPersonne.Items.Clear();
            //TODO : voir si la validation du null est encore nécessaire.
            if (m_listPersonnes != null && m_listPersonnes.Count > 0)
            {
                foreach (Personne personne in m_listPersonnes)
                {
                    comboBoxPersonne.Items.Add(personne);
                }
                comboBoxPersonne.ValueMember = "m_prenom";
                comboBoxPersonne.SelectedIndex = 0;
            }
        }

        protected override bool ChampsValides()
        {
            //Itération 2 mettre suggestions
            string marque = StringNonVide(textBoxMarque, "Marque");
            string modele = StringNonVide(textBoxModele, "modèle");
            int annee = Int32DansIntervalle(textBoxAnnee, 1800, 
            DateTime.Today.Year + 3, "Année"); // 3 ans de plus pour les prototypes.
            CodeVehicule codeVehicule = (CodeVehicule)comboBoxStatut.SelectedItem;
            Personne proprietaire = (Personne)comboBoxPersonne.SelectedItem;
            bool estAjout = m_typeDeSaisie == TypeDeSaisie.Ajout;
            m_vehicule = new Vehicule(estAjout ? Document.Instance.NumProchainVehicule() : m_vehicule.NoVehicule, marque, modele, annee, codeVehicule, proprietaire);
            if (estAjout)
            {
                RequetesSQL.SQLEnregistrerVehicule(m_vehicule);
            }
            return true;
        }

        private void buttonAjouterPersonne_Click(object sender, EventArgs e)
        {
            DlgAjoutPersonne dlg = new DlgAjoutPersonne(TypeDeSaisie.Ajout, null);
            dlg.ShowDialog();

            if (dlg.DialogResult == DialogResult.Cancel)
                return;

            //Ajoute la personne, vide le combo box et réinitialise.
            m_listPersonnes.Add(dlg.Extraire());
            InitialiserComboBoxPersonne();
        }

        /// <summary>
        /// Méthode qui formatte la valeur afficher dans le combo box des personnes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStatut_Format(object sender, ListControlConvertEventArgs e)
        {
            Personne personne = ((Personne)e.ListItem);

            string prenom = personne.Nom;
            string nom = personne.Prenom;
            string dateNaissance = personne.DateNaissance.Date.ToShortDateString();

            /* Si on veux l'age au lieu de la date de naissance.
            int age = DateTime.Today.Year - personne.m_dateNaissance.Year;

            if (DateTime.Today < personne.m_dateNaissance.AddYears(age))
                age--;
            */
            e.Value = prenom + ", " + nom + " : " + dateNaissance;
        }

        /// <summary>
        /// Méthode pour obtenir le vehicule créer avec le form
        /// </summary>
        /// <returns>Le vehicule créer avec le form</returns>
        public Vehicule Extraire()
            => m_vehicule;

        public List<Personne> ExtrairePersonnes()
            => m_listPersonnes;
    }
}

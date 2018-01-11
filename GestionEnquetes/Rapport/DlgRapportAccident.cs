using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilStJ;

namespace GestionEnquetes
{
    /// <summary>
    /// Boîte de dialogue pour la création, affichage, modification et suppression d'un rapport d'accident.
    /// </summary>
    public partial class DlgRapportAccident : UtilStJ.DialogueOkAnnuler
    {
        private RapportAccident m_rapportAccident; // Rapport d'accident en cours de création / affichage / modification / suppression
        private List<Vehicule> m_vehiculesDuDossier; // Liste de véhicules impliqués dans le dossier, pouvant figurer dans le rapport.

        /// <summary>
        /// COnstructeur du dialogue du rapport.
        /// </summary>
        /// <param name="p_vehiculesDuDossier">Liste des véhicules impliqués au dossier.</param>
        /// <param name="p_typeDeSaisie">Ajout, Affichage, Modification ou Suppression.</param>
        /// <param name="p_rapportAccident">Rapport à modifier, afficher ou supprimer.</param>
        public DlgRapportAccident(List<Vehicule> p_vehiculesDuDossier, TypeDeSaisie p_typeDeSaisie = TypeDeSaisie.Ajout, RapportAccident p_rapportAccident = null)
        {
            TypeDeSaisie = p_typeDeSaisie;
            InitializeComponent();
            m_rapportAccident = p_rapportAccident;
            CreerColonnesDesDataGrids();
            textBoxRemarques.AcceptsReturn = true;
            InitialiserDatePicker();
            Province.AjouterChoixDeProvince(comboBoxProvince);
            m_vehiculesDuDossier = p_vehiculesDuDossier;
            RemplirLesControles(m_vehiculesDuDossier);

            // Si on affiche ou supprime le rapport, les champs sont désactivés afin d'éviter les changements.
            if (TypeDeSaisie == TypeDeSaisie.Affichage || TypeDeSaisie == TypeDeSaisie.Suppression)
                DesactiverTousLesChamps();
            else // On tente de créer ou modifier un rapport d'accident.
            {
                if (dataGridViewVehiculesExclusDuRapport.Rows.Count == 0)
                    buttonAjouterVehicule.Enabled = false;

                if (dataGridViewVehiculesInclusDansRapport.Rows.Count == 0)
                    buttonRetirerVehicule.Enabled = false;
            }
        }
        /// <summary>
        /// Change les textes des boutons selon le mode de saisie.
        /// Charge les listes des véhicules dans le gridview.
        /// Si un rapport existe déjà, ses informations sont chargées dans les champs de saisie.
        /// </summary>
        /// <param name="p_vehiculesDuDossier">Liste des véhicules impliqués dans le dossier.</param>
        private void RemplirLesControles(List<Vehicule> p_vehiculesDuDossier)
        {
            switch (TypeDeSaisie)
            {
                case TypeDeSaisie.Affichage:
                    BoutonOK.Visible = false;
                    BoutonAnnuler.Text = "Fermer"; break;
                case TypeDeSaisie.Ajout:
                    BoutonOK.Text = "Ajouter";
                    textBoxPays.Text = "Canada"; break;
                case TypeDeSaisie.Modification:
                    BoutonOK.Text = "Modifier"; break;
                case TypeDeSaisie.Suppression:
                    BoutonOK.Text = "Supprimer"; break;
            }

            InsererInfosDesVoitures(p_vehiculesDuDossier, m_rapportAccident?.VehiculesImpliques);
            DesactiverLesTextBoxDans(dataGridViewVehiculesExclusDuRapport);
            DesactiverLesTextBoxDans(dataGridViewVehiculesInclusDansRapport);

            if (m_rapportAccident != null)
            {
                textBoxNoCivique.Text = m_rapportAccident.Adresse.NoCivique;
                textBoxRue.Text = m_rapportAccident.Adresse.Rue;
                textBoxCodePostal.Text = m_rapportAccident.Adresse.Zip;
                textBoxVille.Text = m_rapportAccident.Adresse.Ville;
                comboBoxProvince.Text = m_rapportAccident.Adresse.Etat;
                textBoxPays.Text = m_rapportAccident.Adresse.Pays;
                dateTimePicker.Value = m_rapportAccident.DateEtHeure;
                textBoxRemarques.Text = m_rapportAccident.Remarques;
            }
        }

        /// <summary>
        /// Désactive tous les champs, afin d'interdire tout changement aux informations actuelles.
        /// </summary>
        private void DesactiverTousLesChamps()
        {
            dataGridViewVehiculesExclusDuRapport.Enabled = false;
            dataGridViewVehiculesInclusDansRapport.Enabled = false;
            buttonAjouterVehicule.Enabled = false;
            buttonRetirerVehicule.Enabled = false;
            textBoxNoCivique.Enabled = false;
            textBoxRue.Enabled = false;
            textBoxCodePostal.Enabled = false;
            textBoxVille.Enabled = false;
            comboBoxProvince.Enabled = false;
            textBoxPays.Enabled = false;
            dateTimePicker.Enabled = false;
            textBoxRemarques.Enabled = false;
        }

        /// <summary>
        /// Crée les colonnes des Datagrids selon les voitures de la liste.
        /// </summary>
        private void CreerColonnesDesDataGrids()
        {
            dataGridViewVehiculesExclusDuRapport.Columns.Clear();
            dataGridViewVehiculesInclusDansRapport.Columns.Clear();

            foreach (ColonneVoiture colonne in UtilsColonneVoiture.ToutesLesColonnes())
            {
                dataGridViewVehiculesExclusDuRapport.Columns.Add(colonne.ToString(), colonne.TexteColonne());
                dataGridViewVehiculesInclusDansRapport.Columns.Add(colonne.ToString(), colonne.TexteColonne());
            }
        }

        /// <summary>
        /// Désactive les TextBox dans le datagrid spécifié.
        /// </summary>
        /// <param name="p_dataGridView">Contrôle de type Datagrid</param>
        private void DesactiverLesTextBoxDans(DataGridView p_dataGridView)
        {
            p_dataGridView.ReadOnly = false;

            foreach (DataGridViewRow ligne in p_dataGridView.Rows)
            {
                ligne.ReadOnly = false;

                foreach (DataGridViewCell cellule in ligne.Cells)
                {
                    if (cellule is DataGridViewTextBoxCell)
                        cellule.ReadOnly = true;
                }
            }
        }

        /// <summary>
        /// Crée une cellule pour le propriétaire d'un véhicule.
        /// </summary>
        /// <param name="p_proprietaire">Propriétaire d'un véhicule.</param>
        /// <returns></returns>
        private DataGridViewComboBoxCell CreerCelluleProprietaire(Personne p_proprietaire)
        {
            DataGridViewComboBoxCell celluleProprietaire = new DataGridViewComboBoxCell();
            celluleProprietaire.Items.Add($"{p_proprietaire.Prenom} {p_proprietaire.Nom}");
            celluleProprietaire.Items.Add(p_proprietaire.Numero);
            celluleProprietaire.Items.Add(p_proprietaire.DateNaissance);
            celluleProprietaire.Items.Add(p_proprietaire.CodePersonne);
            celluleProprietaire.Items.Add(p_proprietaire.Adresse);
            celluleProprietaire.Value = $"{p_proprietaire.Prenom} {p_proprietaire.Nom}";
            celluleProprietaire.ReadOnly = false;
            celluleProprietaire.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;

            return celluleProprietaire;
        }

        /// <summary>
        /// Insère les informations d'un véhicule dans une cellule de DataGrid.
        /// </summary>
        /// <param name="p_dataGridView">DataGrid dans lequel sera placée la cellule.</param>
        /// <param name="p_vehicule">Véhicule à insérer dans le DataGrid.</param>
        private void InsererInfosDUneVoiture(DataGridView p_dataGridView, Vehicule p_vehicule)
        {
            p_dataGridView.Rows.Add(new DataGridViewRow());
            int indexDerniereLigne = p_dataGridView.RowCount - 1;
            p_dataGridView[(int)ColonneVoiture.Marque, indexDerniereLigne].Value = p_vehicule.Marque;
            p_dataGridView[(int)ColonneVoiture.Modele, indexDerniereLigne].Value = p_vehicule.Modele;
            p_dataGridView[(int)ColonneVoiture.NoVehicule, indexDerniereLigne].Value = p_vehicule.NoVehicule;
            p_dataGridView[(int)ColonneVoiture.Annee, indexDerniereLigne].Value = p_vehicule.Annee;
            p_dataGridView[(int)ColonneVoiture.Statut, indexDerniereLigne].Value = p_vehicule.CodeVehicule;

            DataGridViewComboBoxCell celluleProprietaire = CreerCelluleProprietaire(p_vehicule.Proprietaire);
            p_dataGridView.Rows[indexDerniereLigne].Cells[(int)ColonneVoiture.Proprietaire] = celluleProprietaire;
        }

        /// <summary>
        /// Insère les informations de la liste des véhicules dans les DataGrids selon qu'ils soient inclus ou exclus du rapport.
        /// </summary>
        /// <param name="p_vehiculesDuDossier">Liste des véhicules du dossier</param>
        /// <param name="p_vehiculesImpliques">Liste des véhicules du rapport</param>
        private void InsererInfosDesVoitures(List<Vehicule> p_vehiculesDuDossier, List<Vehicule> p_vehiculesImpliques = null)
        {
            if (p_vehiculesDuDossier != null && p_vehiculesDuDossier.Count > 0)
            {
                foreach (Vehicule vehicule in p_vehiculesDuDossier)
                {
                    // si le véhicule courant ne fait pas partie des véhicules impliqués :
                    if (p_vehiculesImpliques == null || !p_vehiculesImpliques.Any((v) => v.NoVehicule == vehicule.NoVehicule))
                        InsererInfosDUneVoiture(dataGridViewVehiculesExclusDuRapport, vehicule);
                    else
                        InsererInfosDUneVoiture(dataGridViewVehiculesInclusDansRapport, vehicule);
                }
            }

            AjouterEvenements(dataGridViewVehiculesExclusDuRapport);
            AjouterEvenements(dataGridViewVehiculesInclusDansRapport);
        }

        /// <summary>
        /// Ajoute des événements aux DataGridView qui ont des cellules qui sont des DataGridViewComboBox.
        /// Ceci permet d'éviter les erreurs qui se produisent lorsqu'on modifie la valeur d'un DataGridViewComboBox
        /// et qu'on clique sur une autre cellule
        /// </summary>
        /// <param name="p_dataGridView">DataGridView qui contient des DataGridViewComboBox</param>
        private void AjouterEvenements(DataGridView p_dataGridView)
        {
            p_dataGridView.CellClick += DataGridViewVehicules_CellClick;
            p_dataGridView.DataError += DataGridViewVehicules_DataError;
        }

        private void DataGridViewVehicules_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewComboBoxCell celluleClique = (DataGridViewComboBoxCell)dataGridView[e.ColumnIndex, e.RowIndex];
            celluleClique.Value = celluleClique.Items[0];
        }

        /// <summary>
        /// Gère les clics sur les éléments du DataGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewVehicules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView[e.ColumnIndex, e.RowIndex] is DataGridViewComboBoxCell)
            {
                dataGridView.CurrentCell = dataGridView[e.ColumnIndex, e.RowIndex];
                dataGridView.BeginEdit(true);
                ComboBox comboBox = (ComboBox)dataGridView.EditingControl;

                if (comboBox != null)
                    comboBox.DroppedDown = true;
            }
            else
            {
                foreach (DataGridViewRow ligne in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cellule in ligne.Cells)
                    {
                        if (cellule is DataGridViewComboBoxCell)
                            cellule.Value = ((DataGridViewComboBoxCell)cellule).Items[0];
                    }
                }
            }
        }

        /// <summary>
        /// Initialise le DatePicker à la date d'aujourd'hui.
        /// </summary>
        private void InitialiserDatePicker()
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "d MMMM yyyy H:mm";
            dateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Détermine si les informations saisies sont valides.
        /// </summary>
        /// <returns>True si les informations sont valides, false sinon.</returns>
        protected override bool ChampsValides()
        {
            List<Vehicule> vehiculesImpliques = new List<Vehicule>();

            foreach (DataGridViewRow ligneCourante in dataGridViewVehiculesInclusDansRapport.Rows)
            {
                Vehicule vehiculeCourant = m_vehiculesDuDossier.Find(v =>
                    v.Marque == ligneCourante.Cells[(int)ColonneVoiture.Marque].Value &&
                    v.Modele == ligneCourante.Cells[(int)ColonneVoiture.Modele].Value &&
                    v.NoVehicule == (int)ligneCourante.Cells[(int)ColonneVoiture.NoVehicule].Value &&
                    v.Annee == (int)ligneCourante.Cells[(int)ColonneVoiture.Annee].Value &&
                    v.CodeVehicule == (CodeVehicule)ligneCourante.Cells[(int)ColonneVoiture.Statut].Value /*&&
                    v.Proprietaire ==     (Personne)ligneCourante.Cells[(int)IndexColonnes.Proprietaire].Value*/);

                Debug.Assert(vehiculeCourant != null, "Le véhicule sélectionné n'existe pas.");

                if (vehiculeCourant != null)
                    vehiculesImpliques.Add(vehiculeCourant);
            }

            if (vehiculesImpliques.Count < 1)
            {
                MB.Avertir("Il doit y avoir au moins un véhicule impliqué dans le rapport d'accident.");
                return false;
            }

            try
            {
                string noCivique = StringNonVide(textBoxNoCivique, "numéro civique");
                string rue = StringNonVide(textBoxRue, "rue");
                string codePostal = StringNonVide(textBoxCodePostal, "code postal").Trim().ToUpper();
                Regex regexCodePostal = new Regex("^[A-Z][0-9][A-Z][ ]?[0-9][A-Z][0-9]$");

                if (!regexCodePostal.IsMatch(codePostal))
                {
                    MB.Avertir("Le code postal doit avoir le format suivant « A1A1A1 » ou « A1A 1A1 ».");
                    return false;
                }

                string ville = StringNonVide(textBoxVille, "ville");
                string province = StringNonVide(comboBoxProvince, "province");
                string pays = StringNonVide(textBoxPays, "pays");

                Adresse adresse = new Adresse(rue, ville, province, codePostal, pays, noCivique);

                if (dateTimePicker.Value > DateTime.Now)
                {
                    MB.Avertir("La date et heure doit être inférieur à la date et heure actuelle.");
                    return false;
                }

                DateTime dateEtHeure = dateTimePicker.Value;
                string remarques = StringNonVide(textBoxRemarques, "remarques");
                m_rapportAccident = new RapportAccident(Document.Instance.NumProchainRapport(), vehiculesImpliques, adresse, dateEtHeure, remarques);

                return true;
            }
            catch (ErreurExtraction p_erreurEntreeUtilisateur)
            {
                // L'utilisateur n'a pas bien rempli le formulaire.
                return false;
            }
        }

        /// <summary>
        /// Ajoute le véhicule sélectionné dans la liste des véhicules impliqués dans le rapport.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterVehicule_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection lignesSelectionnees = dataGridViewVehiculesExclusDuRapport.SelectedRows;

            foreach (DataGridViewRow ligne in lignesSelectionnees)
            {
                dataGridViewVehiculesInclusDansRapport.Rows.Add(new DataGridViewRow());

                foreach (DataGridViewCell colonne in ligne.Cells)
                {
                    int indexDerniereLigne = dataGridViewVehiculesInclusDansRapport.Rows.Count - 1;
                    dataGridViewVehiculesInclusDansRapport[colonne.ColumnIndex, indexDerniereLigne] = (DataGridViewCell)colonne.Clone();
                    dataGridViewVehiculesInclusDansRapport[colonne.ColumnIndex, indexDerniereLigne].Value = colonne.Value;
                }

                DesactiverLesTextBoxDans(dataGridViewVehiculesInclusDansRapport);
                dataGridViewVehiculesExclusDuRapport.Rows.Remove(ligne);
            }

            buttonRetirerVehicule.Enabled = true;

            if (dataGridViewVehiculesExclusDuRapport.Rows.Count == 0)
                buttonAjouterVehicule.Enabled = false;
        }

        /// <summary>
        /// Retire le véhicule sélectionné de la liste des véhicules impliqués dans le rapport.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRetirerVehicule_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection lignesSelectionnees = dataGridViewVehiculesInclusDansRapport.SelectedRows;

            foreach (DataGridViewRow ligne in lignesSelectionnees)
            {
                dataGridViewVehiculesExclusDuRapport.Rows.Add(new DataGridViewRow());

                foreach (DataGridViewCell colonne in ligne.Cells)
                {
                    int indexDerniereColonne = dataGridViewVehiculesExclusDuRapport.Rows.Count - 1;
                    dataGridViewVehiculesExclusDuRapport[colonne.ColumnIndex, indexDerniereColonne] = (DataGridViewCell)colonne.Clone();
                    dataGridViewVehiculesExclusDuRapport[colonne.ColumnIndex, indexDerniereColonne].Value = colonne.Value;
                }

                DesactiverLesTextBoxDans(dataGridViewVehiculesExclusDuRapport);
                dataGridViewVehiculesInclusDansRapport.Rows.Remove(ligne);
            }

            buttonAjouterVehicule.Enabled = true;

            if (dataGridViewVehiculesInclusDansRapport.Rows.Count == 0)
                buttonRetirerVehicule.Enabled = false;
        }

        public RapportAccident Extraire() => m_rapportAccident;
    }

    /// <summary>
    /// Classe d'une colonne de la grille d'un DataGrid.
    /// </summary>
    public static class ColonnesDataGridVehicule
    {
        public enum ColonnesDataGridVehiculeEnum { Marque, Modele, NoVehicule, Annee, Statut };

        public static List<ColonnesDataGridVehiculeEnum> ToutesLesColonnes()
        {
            List<ColonnesDataGridVehiculeEnum> toutesLesColonnes = new List<ColonnesDataGridVehiculeEnum>();

            // Si le premier caractère d'un enum est un chiffre on peut en déduire que ce n'est pas un enum
            // puisque c'est impossible de créer une variable qui commence par un chiffre :
            for (ColonnesDataGridVehiculeEnum colonne = (ColonnesDataGridVehiculeEnum)0; !Char.IsDigit(colonne.ToString()[0]); ++colonne)
                toutesLesColonnes.Add(colonne);

            return toutesLesColonnes;
        }
    }
    /// <summary>
    /// Enum de la positionde l'information des véhicules en terme de colonne dans le DataGrid.
    /// </summary>
    public enum ColonneVoiture
    {
        Marque = 0,
        Modele = 1,
        NoVehicule = 2,
        Annee = 3,
        Statut = 4,
        Proprietaire = 5
    }

    /// <summary>
    /// Utilitaires 
    /// </summary>
    static class UtilsColonneVoiture
    {
        internal static List<ColonneVoiture> ToutesLesColonnes()
        {
            List<ColonneVoiture> toutesLesColonnes = new List<ColonneVoiture>();

            // Si le premier caractère d'un enum est un chiffre on peut en déduire que ce n'est pas un enum
            // puisque c'est impossible de créer une variable qui commence par un chiffre :
            for (ColonneVoiture colonne = (ColonneVoiture)0; !Char.IsDigit(colonne.ToString()[0]); ++colonne)
                toutesLesColonnes.Add(colonne);

            return toutesLesColonnes;
        }

        /// <summary>
        /// Retourne un texte "placeholder" selon la colonne passée en paramètre.
        /// </summary>
        /// <param name="p_colonne">Colonne pour laquelle on veut un texte d'indice.</param>
        /// <returns></returns>
        internal static string TexteColonne(this ColonneVoiture p_colonne)
        {
            switch (p_colonne)
            {
                case ColonneVoiture.Marque: return "Marque";
                case ColonneVoiture.Modele: return "Modèle";
                case ColonneVoiture.NoVehicule: return "No véhicule";
                case ColonneVoiture.Annee: return "Année";
                case ColonneVoiture.Statut: return "Statut";
                case ColonneVoiture.Proprietaire: return "Propriétaire";
                default: throw new IndexOutOfRangeException($"p_colonne ({p_colonne}) n'existe pas."); return "";
            }
        }
    }
}
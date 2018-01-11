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
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
            InitialiserControles();
            ConstruireMenuFormPrincipal();
            ChargerDossierCompte();
        }

        public void ConstruireMenuFormPrincipal()
        {
            ajouterToolStripMenuItem.Visible = LoggedUser.compte.Grade == Grade.Capitaine;
            modifierToolStripMenuItem.Visible = LoggedUser.compte.Grade == Grade.Capitaine;
        }

        /// <summary>
        /// Initialier les controles du formulaire
        /// </summary>
        private void InitialiserControles()
        {
            EnleverCouleurFiltre();
            buttonMesDossier.BackColor = Color.LightGray;
            if (LoggedUser.compte.Grade != Grade.Capitaine)
            {
                buttonDossierBECSeulement.Visible = false;
                buttonTousLesDossiers.Visible = false;
            }
        }

        private void EnleverCouleurFiltre()
        {
            buttonTousLesDossiers.BackColor = Color.WhiteSmoke;
            buttonDossierBECSeulement.BackColor = Color.WhiteSmoke;
            buttonDossierOuvertSeulement.BackColor = Color.WhiteSmoke;
            buttonMesDossier.BackColor = Color.WhiteSmoke;
            buttonEtiquete.BackColor = Color.WhiteSmoke;
        }

        /// <summary>
        /// Charge les dossiers associé au compte dans la table dossier_policier
        /// </summary>
        private void ChargerDossierCompte()
        {
            dataGridViewDossier.Rows.Clear();
            List<Dossier> list = RequetesSQL.SQLChercherDossierAvecMatricule(LoggedUser.compte.Matricule);
            ChargerDossierAfficher(list);
        }

        /// <summary>
        /// Afficher les dossiers chargés
        /// </summary>
        /// <param name="p_dossiers"></param>
        private void ChargerDossierAfficher(List<Dossier> p_dossiers)
        {
            dataGridViewDossier.Rows.Clear();
            foreach (Dossier i in p_dossiers)
            {
                dataGridViewDossier.Rows.Add(i.Numero, i.Statut.Matricule, i.Statut.CodeStatut.ToString());
            }
        }

        /// <summary>
        /// Menu element : Ajouter un compte
        /// </summary>
        private void ajouterCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgSaisieCompte d = new DlgSaisieCompte(TypeDeSaisie.Ajout, LoggedUser.compte.Grade);
            if (d.ShowDialog() == DialogResult.Cancel)
                return;
            else
                RequetesSQL.AjouterCompte(d.Extraire());
        }

        /// <summary>
        /// Menu element : Modifier un compte
        /// </summary>
        private void modifierCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgChoisirCompte choixcompte = new DlgChoisirCompte();
            if (choixcompte.ShowDialog() == DialogResult.OK)
            {
                Compte c = choixcompte.Extraire();
                if (c == null)
                {
                    MB.Avertir("Ce compte n'exist pas");
                }

                DlgSaisieCompte d = new DlgSaisieCompte(TypeDeSaisie.Modification, LoggedUser.compte.Grade, c);
                if (d.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    c = d.Extraire();
                    RequetesSQL.UpdateCompte(c);
                }
            }
        }

        /// <summary>
        /// Menu element : Afficher un compte
        /// </summary>
        private void afficherCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoggedUser.compte.Grade == Grade.Capitaine)
            {
                DlgChoisirCompte choixcompte = new DlgChoisirCompte();
                if (choixcompte.ShowDialog() == DialogResult.OK)
                {
                    Compte c = choixcompte.Extraire();
                    if (c != null)
                        new DlgSaisieCompte(TypeDeSaisie.Affichage, Grade.Capitaine, c).ShowDialog();
                }
            }
            else
            {
                new DlgSaisieCompte(TypeDeSaisie.Affichage, LoggedUser.compte.Grade, LoggedUser.compte).ShowDialog();
            }

        }

        /// <summary>
        /// Menu element : Supprimer un compte
        /// </summary>
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgChoisirCompte choixcompte = new DlgChoisirCompte();
            if (choixcompte.ShowDialog() == DialogResult.OK)
            {
                Compte c = choixcompte.Extraire();
                if (c == null)
                {
                    MB.Avertir("Ce compte n'exist pas");
                }
                else
                {
                    if(MB.ConfirmerOuiNon("Voulez-vous vraiment supprimer définitivement ce compte?"))
                        RequetesSQL.SupprimerCompte(c.Matricule.ToString());
                }
            }
        }

        /// <summary>
        /// Menu element : Ajouter un dossier
        /// </summary>
        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DlgAjoutDossier d = new DlgAjoutDossier(TypeDeSaisie.Ajout, null);
            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                Dossier dossier = d.Extraire();
                RequetesSQL.SQLEnregistrerDossier(dossier);
                ChargerDossierCompte();
            }
        }

        /// <summary>
        /// DataGrid : Dossiers
        /// </summary>
        private void dataGridViewDossier_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dossier dossier = RequetesSQL.SQLChercherDossierParNumero(dataGridViewDossier.Rows[e.RowIndex].Cells[0].Value.ToString());
                DlgAjoutDossier d = new DlgAjoutDossier(TypeDeSaisie.Modification, dossier);
                d.ShowDialog();
                if (d.DialogResult == DialogResult.OK)
                {
                    RequetesSQL.SQLEnregistrerDossier(d.Extraire());
                    ChargerDossierCompte();
                }
            }
            catch (Exception excep) { Console.WriteLine("Réessayez svp"); }
        }

        /// <summary>
        /// Raccourci clavier pour ajouter nouveau dossier
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                ajouterToolStripMenuItem1.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Boutton : Afficher dossiers avec destination BEC 
        /// </summary>
        private void buttonDossierBECSeulement_Click(object sender, EventArgs e)
        {
            EnleverCouleurFiltre();
            buttonDossierBECSeulement.BackColor = Color.LightGray;
            List<Dossier> list = RequetesSQL.SQLChercherDossierBEC();
            ChargerDossierAfficher(list);
        }

        /// <summary>
        /// Boutton : Afficher les dossiers de l'utilisateur actuel
        /// </summary>
        private void buttonMesDossier_Click(object sender, EventArgs e)
        {
            EnleverCouleurFiltre();
            buttonMesDossier.BackColor = Color.LightGray;
            ChargerDossierCompte();
        }

        /// <summary>
        /// Boutton : Afficher dossiers ouverts
        /// </summary>
        private void buttonDossierOuvertSeulement_Click(object sender, EventArgs e)
        {
            EnleverCouleurFiltre();
            buttonDossierOuvertSeulement.BackColor = Color.LightGray;
            List<Dossier> list = RequetesSQL.SQLChercherDossierOuvert(LoggedUser.compte.Matricule);
            ChargerDossierAfficher(list);
        }

        /// <summary>
        /// Boutton : Etiquete
        /// </summary>
        private void buttonEtiquete_Click(object sender, EventArgs e)
        {
            EnleverCouleurFiltre();
            List<Dossier> list = RequetesSQL.SQLChercherDossierAvecMatricule(LoggedUser.compte.Matricule);
            buttonEtiquete.BackColor = Color.LightGray;
            List<Dossier> list1 = new List<Dossier>();
            foreach (Dossier d in list)
            {
                if (RequetesSQL.SQLVerifierEtiquete(d.Numero, LoggedUser.compte.Matricule))
                {
                    list1.Add(d);
                }
            }
            ChargerDossierAfficher(list1);
        }

        /// <summary>
        /// Boutton : Afficher tous les dossiers
        /// </summary>
        private void buttonTousLesDossiers_Click(object sender, EventArgs e)
        {
            EnleverCouleurFiltre();
            buttonTousLesDossiers.BackColor = Color.LightGray;
            List<Dossier> list = RequetesSQL.SQLTousLesDossiers();
            ChargerDossierAfficher(list);
        }

        /// <summary>
        /// Menu element : Modifier le mot de passe
        /// </summary>
        private void modifierMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgResetPass rp = new DlgResetPass();
            if (rp.ShowDialog() == DialogResult.OK)
            {
                MB.Avertir("Votre mot de passe a été modifié");
            }
        }

        // Evenement : colorer nouvelle ligne ajoutée selon destination du dossier
        private void dataGridViewDossier_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Dossier dossier = RequetesSQL.SQLChercherDossierParNumero(dataGridViewDossier.Rows[e.RowIndex].Cells[0].Value.ToString());
            dataGridViewDossier.Rows[e.RowIndex].DefaultCellStyle.BackColor = PickColorForDossierRow(dossier.Destination.CodeDestination);
        }
        // Donner une couleur selon destination du dossier
        private Color PickColorForDossierRow(CodeDestination p_codeDes)
        {
            Color c;
            switch (p_codeDes)
            {
                case CodeDestination.ARC: labelARC.BackColor = c = Color.FromArgb(149, 149, 142); break;
                case CodeDestination.ATT: labelATT.BackColor = c = Color.FromArgb(210, 214, 128); break;
                case CodeDestination.BEC: labelBEC.BackColor = c = Color.FromArgb(131, 169, 71); break;
                case CodeDestination.RED: labelRED.BackColor = c = Color.FromArgb(97, 195, 162); break;
                case CodeDestination.REV: labelREV.BackColor = c = Color.FromArgb(240, 211, 154); break;
                case CodeDestination.SD:  labelSD.BackColor  = c = Color.FromArgb(220, 122, 122); break;
                default: c = Color.White; break;
            }
            return c;
        }

        /// <summary>
        /// Fermer l'application
        /// </summary>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
            => Close();

        private void FormPrincipale_FormClosed(object sender, FormClosedEventArgs e)
            => Document.Instance.Fermer();
    }
}

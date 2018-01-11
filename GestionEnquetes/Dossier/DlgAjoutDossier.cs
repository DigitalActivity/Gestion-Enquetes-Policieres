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
    public partial class DlgAjoutDossier : DialogueOkAnnuler
    {
        TypeDeSaisie m_typeDeSaisie;
        Dossier m_dossier;
        Destination m_destinationInitial;
        Statut m_statutInitial;

        public DlgAjoutDossier(TypeDeSaisie p_operation, Dossier p_dossier)
        {
            m_typeDeSaisie = p_operation;
            m_dossier = (p_dossier != null) ? p_dossier : new Dossier();
            m_destinationInitial = m_dossier.Destination;
            m_statutInitial = m_dossier.Statut;

            InitializeComponent();

            MAJRapportEnquete();
            MAJRapportAccident();
            MAJRapportEvenement();
            MAJDestination();
            InitialiserComboBoxStatutDossier();

            if (p_operation != TypeDeSaisie.Ajout)
                RemplirLesControles();
        }

        public void RemplirLesControles()
        {
            AffichageEtiquete(m_dossier.Numero, LoggedUser.compte.Matricule);

            InitializerListViewVehicules();
            InitializerListViewPersonnes();

            if (m_dossier.Destination?.CodeDestination == CodeDestination.BEC && m_typeDeSaisie == TypeDeSaisie.Modification)
            {
                if (LoggedUser.compte.Grade != Grade.Capitaine)
                {
                    m_typeDeSaisie = TypeDeSaisie.Affichage;
                }
            }

            switch (m_typeDeSaisie)
            {
                case TypeDeSaisie.Affichage: RemplirePourAffichage(); break;
                case TypeDeSaisie.Modification:
                    RemplirePourModification();

                    if (m_dossier.Destination.CodeDestination == CodeDestination.SD)
                    {
                        RemplirePourAffichage();
                        buttonAjouterPersonne.Enabled = true;
                        buttonAjouterVehicule.Enabled = true;
                        buttonAjouterREnq.Enabled = true;
                        listViewVehicules.MouseDoubleClick -= listViewVehicules_DoubleClick;
                        listViewPersonnes.MouseDoubleClick -= listViewPersonnes_DoubleClick;
                    }
                    if (m_dossier.Destination.CodeDestination == CodeDestination.ARC)
                    {
                        RemplirePourAffichage();
                    }

                    break;
                default: break;
            }
        }

        private void RemplirePourAffichage()
        {
            RemplirePourModification();
            comboBoxStatut.Enabled = false;
            buttonAjouterRAcc.Enabled = false;
            buttonSupprimerRAcc.Enabled = false;
            buttonAfficherRAcc.Enabled = true;
            buttonAjouterREve.Enabled = false;
            buttonSupprimerREve.Enabled = false;
            buttonAfficherREve.Enabled = true;
            buttonAjouterREnq.Enabled = false;
            buttonSupprimerREnq.Enabled = false;
            buttonAfficherREnq.Enabled = true;
            buttonAjouterPersonne.Enabled = false;
            buttonAjouterVehicule.Enabled = false;
            buttonModifierREve.Enabled = false;
        }

        private void RemplirePourModification()
        {
            comboBoxStatut.SelectedItem = m_dossier.Statut.CodeStatut;
            labelDestination.Text = m_dossier.Destination.CodeDestination.ToString();
        }

        private void InitializerListViewVehicules()
        {
            listViewVehicules.Items.Clear();
            listViewVehicules.FullRowSelect = true;
            foreach (Vehicule v in m_dossier.Vehicules)
            {
                ListViewItem item = new ListViewItem(new string[] { v.Marque, v.Modele, v.Annee.ToString() });
                item.Tag = v;
                listViewVehicules.Items.Add(item);
            }
        }

        private void InitializerListViewPersonnes()
        {
            listViewPersonnes.Items.Clear();
            listViewPersonnes.FullRowSelect = true;
            foreach (Personne p in m_dossier.Personnes)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Nom, p.Prenom });
                item.Tag = p;
                listViewPersonnes.Items.Add(item);
            }
        }

        private void InitialiserComboBoxStatutDossier()
        {
            comboBoxStatut.Items.Clear();
            comboBoxStatut.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (CodeStatut s in Enum.GetValues(typeof(CodeStatut)))
                comboBoxStatut.Items.Add(s);

            comboBoxStatut.SelectedItem = CodeStatut._1;

            if (m_typeDeSaisie == TypeDeSaisie.Ajout)
            {
                comboBoxStatut.Enabled = false;
            }

            if (m_dossier.Destination?.CodeDestination == CodeDestination.ARC)
            {
                comboBoxStatut.Items.Remove(CodeStatut._1);
                comboBoxStatut.SelectedItem = CodeStatut._2;
                comboBoxStatut.Enabled = true;
            }
        }

        protected override bool ChampsValides()
        {
            string no_dossier = "";
            if (m_typeDeSaisie == TypeDeSaisie.Ajout)
                no_dossier = Document.PREFIXE_POSTE + " " + DateTime.Now.ToString("yyyyMMdd") + "-" + Document.Instance.NumProchainDossier().ToString().PadLeft(3, '0');
            CodeStatut codeStatut = (CodeStatut)comboBoxStatut.SelectedItem;
            Statut statut = new Statut(no_dossier, DateNow(), codeStatut, LoggedUser.compte.Matricule);
            Destination destination = new Destination(DateNow(), CodeDestination.RED, "", (m_typeDeSaisie == TypeDeSaisie.Modification) ? m_dossier.Numero : no_dossier, LoggedUser.compte.Matricule);

            if (m_dossier.RapportEvenement == null && m_dossier.RapportAccident == null)
            {
                MB.AvertirCritique("Au moins un rapport (Évenement ou Accident) doit être lié au dossier.");
                return false;
            }

            m_dossier = new Dossier((m_typeDeSaisie == TypeDeSaisie.Modification) ? m_dossier.Numero : no_dossier, (m_dossier.Statut == null) ? statut : m_dossier.Statut,
                m_dossier.RapportAccident, m_dossier.RapportEvenement, m_dossier.RapportEnquete,
                (m_dossier.Destination == null) ? destination : m_dossier.Destination, m_dossier.Vehicules, m_dossier.Personnes);

            EnregistrerEtiquete(m_dossier.Numero, LoggedUser.compte.Matricule);
            return true;
        }

        /// <summary>
        /// Retire les milisecondes du datetime pour access
        /// </summary>
        /// <returns> La date et l'heure courante YYYY:MM:DD HH:mm:SS</returns>
        public DateTime DateNow()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }


        public Dossier Extraire()
            => m_dossier;


        private void buttonAjouterPersonne_Click(object sender, EventArgs e)
        {
            DlgAjoutPersonne dlgAjoutPersonne = new DlgAjoutPersonne(TypeDeSaisie.Ajout, null);
            dlgAjoutPersonne.ShowDialog();

            if (dlgAjoutPersonne.DialogResult == DialogResult.Cancel)
                return;

            m_dossier.Personnes.Add(dlgAjoutPersonne.Extraire());
            InitializerListViewPersonnes();
        }

        private void buttonAjouterVehicule_Click(object sender, EventArgs e)
        {
            DlgAjoutVehicule dlgAjoutVehicule = new DlgAjoutVehicule(TypeDeSaisie.Ajout, null, m_dossier.Personnes);
            dlgAjoutVehicule.ShowDialog();

            if (dlgAjoutVehicule.DialogResult == DialogResult.Cancel)
                return;

            m_dossier.Vehicules.Add(dlgAjoutVehicule.Extraire());
            m_dossier.setPersonnes(dlgAjoutVehicule.ExtrairePersonnes());
            InitializerListViewPersonnes();
            InitializerListViewVehicules();
        }

        private void listViewVehicules_DoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewVehicules.SelectedItems.Count == 1)
            {
                ListViewItem item = listViewVehicules.SelectedItems[0];
                Vehicule v = (Vehicule)item.Tag;
                DlgAjoutVehicule dlgAjoutVehicule = new DlgAjoutVehicule((m_typeDeSaisie == TypeDeSaisie.Ajout) ? TypeDeSaisie.Modification : m_typeDeSaisie, v, m_dossier.Personnes);
                dlgAjoutVehicule.ShowDialog();

                if (dlgAjoutVehicule.DialogResult == DialogResult.Cancel)
                    return;

                m_dossier.Vehicules[item.Index] = dlgAjoutVehicule.Extraire();
                InitializerListViewVehicules();
            }
        }

        private void listViewPersonnes_DoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewPersonnes.SelectedItems.Count == 1)
            {
                ListViewItem item = listViewPersonnes.SelectedItems[0];
                Personne p = (Personne)item.Tag;
                DlgAjoutPersonne dlgAjoutPersonne = new DlgAjoutPersonne((m_typeDeSaisie == TypeDeSaisie.Ajout) ? TypeDeSaisie.Modification : m_typeDeSaisie, p);
                dlgAjoutPersonne.ShowDialog();

                if (dlgAjoutPersonne.DialogResult == DialogResult.Cancel)
                    return;

                m_dossier.Personnes[item.Index] = dlgAjoutPersonne.Extraire();
                InitializerListViewPersonnes();
            }
        }

        private void buttonAjouterREnq_Click(object sender, EventArgs e)
        {
            DlgRapportEnquete d = new DlgRapportEnquete();
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportEnquete(d.Extraire());
                MAJRapportEnquete();
            }
        }

        private void buttonSupprimerREnq_Click(object sender, EventArgs e)
        {
            DlgRapportEnquete d = new DlgRapportEnquete(TypeDeSaisie.Suppression, m_dossier.RapportEnquete);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportEnquete(null);
                MAJRapportEnquete();
            }
        }

        private void buttonAfficherREnq_Click(object sender, EventArgs e)
        {
            new DlgRapportEnquete(TypeDeSaisie.Affichage, m_dossier.RapportEnquete).ShowDialog();
        }

        private void buttonModifierREnq_Click(object sender, EventArgs e)
        {
            DlgRapportEnquete d = new DlgRapportEnquete(TypeDeSaisie.Modification, m_dossier.RapportEnquete);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportEnquete(d.Extraire());
                MAJRapportEnquete();
            }
        }

        private void MAJRapportEnquete()
        {
            if (m_dossier.RapportEnquete == null)
            {
                labelREnq.Text = "Aucun rapport d'enquête n'est lié";
                buttonAjouterREnq.Enabled = true;
                buttonModifierREnq.Enabled = false;
                buttonSupprimerREnq.Enabled = false;
                buttonAfficherREnq.Enabled = false;
                labelREnq.ForeColor = Color.Black;
            }
            else
            {
                labelREnq.Text = "Un rapport d'enquête est lié";
                buttonAjouterREnq.Enabled = false;
                buttonModifierREnq.Enabled = true;
                buttonSupprimerREnq.Enabled = true;
                buttonAfficherREnq.Enabled = true;
                labelREnq.ForeColor = Color.DarkGreen;
            }
        }

        private void buttonAjouterREve_Click(object sender, EventArgs e)
        {
            DlgRapportEvenement d = new DlgRapportEvenement();
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportEvenement(d.Extraire());
                MAJRapportEvenement();
            }
        }

        private void buttonSupprimerREve_Click(object sender, EventArgs e)
        {
            DlgRapportEvenement d = new DlgRapportEvenement(TypeDeSaisie.Suppression, m_dossier.RapportEvenement);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportEvenement(null);
                MAJRapportEvenement();
            }
        }

        private void buttonAfficherREve_Click(object sender, EventArgs e)
        {
            new DlgRapportEvenement(TypeDeSaisie.Affichage, m_dossier.RapportEvenement).ShowDialog();
        }

        private void buttonModifierREve_Click(object sender, EventArgs e)
        {
            DlgRapportEvenement d = new DlgRapportEvenement(TypeDeSaisie.Modification, m_dossier.RapportEvenement);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportEvenement(d.Extraire());
                MAJRapportEvenement();
            }
        }

        private void MAJRapportEvenement()
        {
            if (m_dossier.RapportEvenement == null)
            {
                labelREve.Text = "Aucun rapport d'évènement n'est lié";
                buttonAjouterREve.Enabled = true;
                buttonModifierREve.Enabled = false;
                buttonSupprimerREve.Enabled = false;
                buttonAfficherREve.Enabled = false;
                labelREve.ForeColor = Color.Black;
            }
            else
            {
                labelREve.Text = "Un rapport d'évènement est lié";
                buttonAjouterREve.Enabled = false;
                buttonModifierREve.Enabled = true;
                buttonSupprimerREve.Enabled = true;
                buttonAfficherREve.Enabled = true;
                labelREve.ForeColor = Color.DarkGreen;
            }
        }

        private void buttonAjouterRAcc_Click(object sender, EventArgs e)
        {
            DlgRapportAccident d = new DlgRapportAccident(m_dossier.Vehicules);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportAccident(d.Extraire());
                MAJRapportAccident();
            }
        }

        private void buttonSupprimerRAcc_Click(object sender, EventArgs e)
        {
            DlgRapportAccident d = new DlgRapportAccident(m_dossier.Vehicules, TypeDeSaisie.Suppression, m_dossier.RapportAccident);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportAccident(null);
                MAJRapportAccident();
            }
        }

        private void buttonAfficherRAcc_Click(object sender, EventArgs e)
        {
            new DlgRapportAccident(m_dossier.Vehicules, TypeDeSaisie.Affichage, m_dossier.RapportAccident).Show();
        }

        private void buttonModifierRAcc_Click(object sender, EventArgs e)
        {
            DlgRapportAccident d = new DlgRapportAccident(m_dossier.Vehicules, TypeDeSaisie.Modification, m_dossier.RapportAccident);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetRapportAccident(d.Extraire());
                MAJRapportAccident();
            }
        }

        private void MAJRapportAccident()
        {
            if (m_dossier.RapportAccident == null)
            {
                labelRAcc.Text = "Aucun rapport d'accident n'est lié";
                buttonAjouterRAcc.Enabled = true;
                buttonModifierRAcc.Enabled = false;
                buttonSupprimerRAcc.Enabled = false;
                buttonAfficherRAcc.Enabled = false;
                labelRAcc.ForeColor = Color.Black;
            }
            else
            {
                labelRAcc.Text = "Un rapport d'accident est lié";
                buttonAjouterRAcc.Enabled = false;
                buttonModifierRAcc.Enabled = true;
                buttonSupprimerRAcc.Enabled = true;
                buttonAfficherRAcc.Enabled = true;
                labelRAcc.ForeColor = Color.DarkGreen;
            }
        }



        private void EnregistrerEtiquete(string p_noDossier, int p_matricule)
        {
            if (p_noDossier != null)
            {
                if (checkBoxEtiquete.Checked)
                {
                    RequetesSQL.SQLAjouterEtiquete(p_noDossier, p_matricule);
                }
                else
                {
                    RequetesSQL.SQLSupprimerEtiquete(p_noDossier, p_matricule);
                }
            }
        }

        private void AffichageEtiquete(string p_noDossier, int p_matricule)
        {
            checkBoxEtiquete.Checked = false;
            if (p_noDossier != null)
            {
                checkBoxEtiquete.Checked = RequetesSQL.SQLVerifierEtiquete(p_noDossier, p_matricule);
            }
        }

        private void MAJDestination()
        {
            if (m_dossier.Destination == null)
            {
                labelDestination.Text = "Destination par défaut";
            }
            else
            {
                labelDestination.Text = m_dossier.Destination.CodeDestination.ToString();
            }
        }

        private void buttonDestination_Click(object sender, EventArgs e)
        {
            DlgDestination d = new DlgDestination(TypeDeSaisie.Modification, m_dossier.Destination);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetDestination(d.Extraire());

                MAJDestination();
                InitialiserComboBoxStatutDossier();
            }
        }

        private void buttonAjouterDest_Click(object sender, EventArgs e)
        {
            DlgDestination d = new DlgDestination(TypeDeSaisie.Ajout, null);
            if (d.ShowDialog() == DialogResult.OK)
            {
                m_dossier.SetDestination(d.Extraire());

                buttonAjouterDest.Enabled = false;
                buttonRetirerDest.Enabled = true;
                buttonModifDest.Enabled = true;
                MAJDestination();
                InitialiserComboBoxStatutDossier();
            }
        }

        private void buttonRetirerDest_Click(object sender, EventArgs e)
        {
            if(m_statutInitial != null)
            {
                comboBoxStatut.SelectedItem = m_statutInitial.CodeStatut;
            }
  
            m_dossier.SetDestination(m_destinationInitial);

            buttonAjouterDest.Enabled = true;
            buttonRetirerDest.Enabled = false;
            buttonModifDest.Enabled = false;
            MAJDestination();
            InitialiserComboBoxStatutDossier();
        }

        private void buttonHistorique_Click(object sender, EventArgs e)
        {
            DlgHistorique d = new DlgHistorique(m_dossier.Numero);
            d.ShowDialog();
        }
    }
}
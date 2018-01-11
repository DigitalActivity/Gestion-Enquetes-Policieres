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
    public partial class DlgDestination : DialogueOkAnnuler
    {
        Destination m_destination;
        public DlgDestination(TypeDeSaisie p_operation, Destination p_destination)
        {
            InitializeComponent();
            InitialiserComboBox();
            m_destination = p_destination;

            if (m_destination != null)
            {
                InitialiserModification();
            }
        }

        private void InitialiserModification()
        {
            textBoxRemarque.Text = m_destination.Remarque;
            textBoxMatricule.Text = m_destination.MatriculePolicier.ToString();
            comboBoxDestination.SelectedItem = m_destination.CodeDestination;
        }

        private void InitialiserComboBox()
        {
            comboBoxDestination.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (LoggedUser.compte.Grade)
            {
                case Grade.Patrouilleur:
                    comboBoxDestination.Items.Add(CodeDestination.REV);
                    break;
                case Grade.Lieutenant:
                    comboBoxDestination.Items.Add(CodeDestination.RED);
                    comboBoxDestination.Items.Add(CodeDestination.BEC);
                    break;
                case Grade.Capitaine:
                    comboBoxDestination.Items.Add(CodeDestination.SD);
                    comboBoxDestination.Items.Add(CodeDestination.ARC);
                    comboBoxDestination.Items.Add(CodeDestination.ATT);
                    comboBoxDestination.Items.Add(CodeDestination.BEC);
                    break;
                case Grade.Détective:
                    comboBoxDestination.Items.Add(CodeDestination.BEC);
                    break;
            }
            
            comboBoxDestination.SelectedIndex = 0;
        }

        protected override bool ChampsValides()
        {
            int? matricule = Int32OuNull(textBoxMatricule, "Matricule");
      
            if (matricule != null)
            {
                int numero = (int)matricule;
                Compte compte = RequetesSQL.SQLChercherCompteAvecMatricule(numero);

                if (compte == null)
                {
                    MB.Avertir("Le compte n'existe pas.");
                    return false;
                }
                else
                {
                    if (compte.Grade != Grade.Détective && (CodeDestination)comboBoxDestination.SelectedItem == CodeDestination.SD)
                    {
                        MB.Avertir("Le matricule n'est pas un détective.");
                        return false;
                    }
                    if ((compte.Grade != Grade.Lieutenant && compte.Grade != Grade.Capitaine) && (CodeDestination)comboBoxDestination.SelectedItem == CodeDestination.REV)
                    {
                        MB.Avertir("Le matricule n'est pas un lieutenant ni un capitaine.");
                        return false;
                    }
                }
            }
            else
            {
                if ((CodeDestination)comboBoxDestination.SelectedItem != CodeDestination.ATT &&
                    (CodeDestination)comboBoxDestination.SelectedItem != CodeDestination.BEC &&
                    (CodeDestination)comboBoxDestination.SelectedItem != CodeDestination.ARC)
                {
                    MB.Avertir("Le matricule doit être nul lors d'envoie au BEC, de mise en attente ou lors de l'archivage.");
                    return false;
                }
            }

            m_destination = new Destination(DateNow(), (CodeDestination)comboBoxDestination.SelectedItem, textBoxRemarque.Text, "", matricule);

            return true;
        }

        public Destination Extraire()
            => m_destination;

        public DateTime DateNow()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

    }
}

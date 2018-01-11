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
    public partial class DlgHistorique : Form
    {
        string m_noDossier; //Numéro du dossier.
        public DlgHistorique(string p_noDossier)
        {
            InitializeComponent();
            m_noDossier = p_noDossier;
            InitialiserDataGridView();
        }

        /// <summary>
        /// Initialise le data grid view avec les données sur l'historique du dossier.
        /// </summary>
        private void InitialiserDataGridView()
        {
            List<Destination> destinations = RequetesSQL.SQLChercherListeDestinationNoDossier(m_noDossier);

            foreach(Destination destination in destinations)
            {
                dataGridViewDest.Rows.Add(destination.HeureTransfer.ToString(), destination.CodeDestination,
                    destination.Remarque, destination.NumeroDossier, destination.MatriculePolicier);
            }

            dataGridViewDest.Sort(ColDateHeur, ListSortDirection.Descending); //Tri les données pour que le plus récent soit en haut
        }
    }
}

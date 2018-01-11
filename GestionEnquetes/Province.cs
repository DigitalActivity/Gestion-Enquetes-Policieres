using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEnquetes
{
    /// <summary>
    /// Choix de province
    /// </summary>
    public class Province
    {
        public Province(string p_code)
        {
            Code = p_code;
        }

        public string Code { get; private set; }

        public static readonly List<Province> ProvincesDuCanada = new List<Province>
        {
            new Province("AB"),
            new Province("BC"),
            new Province("IPE"),
            new Province("MB"),
            new Province("NB"),
            new Province("NS"),
            new Province("ON"),
            new Province("QC"),
            new Province("SK"),
            new Province("NL"),
            new Province("NU"),
            new Province("NT"),
            new Province("YT")
        };

        /// <summary>
        /// Ajoute les provinces du Canada dans un ComboBox et sélectionne la première province.
        /// </summary>
        /// <param name="p_comboBox">ComboBox où on veut ajouter les provinces du Canada</param>
        public static void AjouterChoixDeProvince(ComboBox p_comboBox)
        {
            foreach (Province province in Province.ProvincesDuCanada)
                p_comboBox.Items.Add(province);

            p_comboBox.SelectedIndex = 0;
        }

        public override string ToString() => Code;
    }
}

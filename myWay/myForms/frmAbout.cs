using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWay.myForms
{
    public partial class frmAbout : Form
    {
        // var
        String[] aProductsDesc = { "myWay est un gestionnaire de raccourcis, permettant de stocker des raccourcis vers des fichiers, des sites webs et même d'envoyer des mails à une adresse spécifique.", "Cette application ne peut pas être revendue. Elle ne peut également pas être modifiée sans en citer l'auteur. L'utilisation de l'application reste libre et gratuite dans tous les domaines." };
        public frmAbout()
        {
            InitializeComponent();
            UpdateInformations();
        }

        // Update informations
        public void UpdateInformations()
        {
            lblProductDesc.Text = "Produit : " + Assembly.GetExecutingAssembly().GetName().Name.ToString() +
                "\nVersion : " + Assembly.GetExecutingAssembly().GetName().Version.ToString() +
            "\nAuteur : " + "Rui Paulo De Jesus Ferreira";
            lbxProducts.Items.Add(Assembly.GetExecutingAssembly().GetName().Name.ToString() + " - " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " product");
            lbxProducts.Items.Add(Assembly.GetExecutingAssembly().GetName().Name.ToString() + " - " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " licence");
        }
        // END - Update informations
        // Controls events
        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbxDetails.Text = aProductsDesc[lbxProducts.SelectedIndex];
            }
            catch
            {

            }
        }
        // END - Controls events
    }
}

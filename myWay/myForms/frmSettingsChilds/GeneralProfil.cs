using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myWay.myForms.frmSettingsChilds
{
    public partial class GeneralProfil : Form
    {
        public GeneralProfil()
        {
            InitializeComponent();
        }

        private void btnAddProfil_Click(object sender, EventArgs e)
        {
            frmAskTextInput askProfilName = new frmAskTextInput("profil");
            askProfilName.ShowDialog();
        }

        private void GeneralProfil_Load(object sender, EventArgs e)
        {
            data.dataSave saver = new data.dataSave();
            foreach(String profil in Directory.GetFiles(saver.savePath))
            {
                FileInfo fiProfil = new FileInfo(profil);
                if(fiProfil.Extension != ".xml")
                {
                    continue;
                }
                else
                {
                    cbxProfil.Items.Add(fiProfil.Name);
                    if(fiProfil.Name == data.dataTemp.profilName)
                    {
                        cbxProfil.SelectedItem = fiProfil.Name;
                    }
                }
            }
        }

        private void cbxProfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.dataSave saver = new data.dataSave();
            data.dataTemp.profilName = cbxProfil.SelectedItem.ToString();
            saver.ClearData();
            saver.saveSettings();
            saver.importData();
            
        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Voulez-vous vraiment supprimer le profil \"" + cbxProfil.SelectedItem.ToString() + "\" ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            data.dataSave saver = new data.dataSave();
            saver.DeleteProfile(cbxProfil.SelectedItem.ToString());
            cbxProfil.Items.Add("default_profil.xml");
            cbxProfil.SelectedItem = "default_profil.xml";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myWay.data;
using System.IO;

namespace myWay.myForms.frmSettingsChilds
{
    public partial class DataImport : Form
    {
        public DataImport()
        {
            InitializeComponent();
            foreach(myComponents.ucSections section in data.dataSections.GetSections())
            {
                cbxSections.Items.Add(section.getName());
                lblNew.Text = "v" + Application.ProductVersion + " et antérieur";
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            dataSave saver = new dataSave();
            if (cbxSections.SelectedItem == null)
            {
                myComponents.ucSections mySection = dataSections.GetSectionByName(cbxSections.Text);
                if (mySection == null)
                {
                    dataChecker check = new dataChecker();
                    if (check.validateSectionName(cbxSections.Text))
                    {
                        dataSections.addSection(cbxSections.Text);
                        saver.saveSections();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            saver.importOldData(ofd.FileName, dataSections.GetSectionByName(cbxSections.Text));
        }

        private void btnChooseFileActual_Click(object sender, EventArgs e)
        {
            ofdNew.ShowDialog();
        }

        private void ofdNew_FileOk(object sender, CancelEventArgs e)
        {
            dataSave saver = new dataSave();
            saver.importData(ofdNew.FileName);
        }
    }
}

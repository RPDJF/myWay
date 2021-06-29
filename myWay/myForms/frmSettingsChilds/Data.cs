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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
            foreach(myComponents.ucSections section in data.dataSections.GetSections())
            {
                cbxSections.Items.Add(section.getName());
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if(ofd.FileName != null && ofd.FileName != "")
            {
                dataSave saver = new dataSave();
                saver.importOldData(ofd.FileName, dataSections.GetSectionByName(cbxSections.Text));
            }
        }
    }
}

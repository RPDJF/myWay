using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWay.myForms.frmSettingsChilds
{
    public partial class DataExport : Form
    {
        public DataExport()
        {
            InitializeComponent();
            lblNew.Text = "v" + Application.ProductVersion + " et supérieur";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            sfd.FileName = null;
            sfd.ShowDialog();
        }

        private void sfd_FileOk(object sender, CancelEventArgs e)
        {
            data.dataSave saver = new data.dataSave();
            saver.exportData(sfd.FileName);
        }
    }
}

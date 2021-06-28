using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWay.myForms
{
    public partial class frmSettings : Form
    {
        // var
        Form child = new Form();
        public frmSettings()
        {
            InitializeComponent();
        }
        // Controls events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            child.Close();
            child = new frmSettingsChilds.General();
            child.TopLevel = false;
            pnlFrame.Controls.Add(child);
            child.Show();
        }
        // END - Controls events
    }
}

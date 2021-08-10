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
            this.DialogResult = DialogResult.OK;
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
            if (pnlGeneral.Visible) pnlGeneral.Visible = false;
            else pnlGeneral.Visible = true;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            pnlFrame.HorizontalScroll.Maximum = 0;
            pnlFrame.AutoScroll = false;
            pnlFrame.VerticalScroll.Visible = false;
            pnlFrame.AutoScroll = true;
        }

        private void btnDonnees_Click(object sender, EventArgs e)
        {
            if (pnlDonnees.Visible) pnlDonnees.Visible = false;
            else pnlDonnees.Visible = true;
        }

        private void btnDonneesImport_Click(object sender, EventArgs e)
        {
            child.Close();
            child = new frmSettingsChilds.DataImport();
            child.TopLevel = false;
            pnlFrame.Controls.Clear();
            pnlFrame.Controls.Add(child);
            child.Show();
        }

        private void btnDonneesExport_Click(object sender, EventArgs e)
        {
            child.Close();
            child = new frmSettingsChilds.DataExport();
            child.TopLevel = false;
            pnlFrame.Controls.Clear();
            pnlFrame.Controls.Add(child);
            child.Show();
        }

        private void btnGeneralAffichage_Click(object sender, EventArgs e)
        {
            child.Close();
            child = new frmSettingsChilds.GeneralAffichage();
            child.TopLevel = false;
            pnlFrame.Controls.Clear();
            pnlFrame.Controls.Add(child);
            child.Show();
        }
        // END - Controls events
    }
}

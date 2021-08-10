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

namespace myWay.myForms.frmSettingsChilds
{
    public partial class GeneralAffichage : Form
    {
        Boolean ready = false;
        public GeneralAffichage()
        {
            InitializeComponent();
            cbxToplevel.Checked = dataTemp.alwaysOnTop;
            cbxClassicalForm.Checked = dataTemp.classicalWindowsForm;
            ready = true;
        }

        private void cbxToplevel_CheckedChanged(object sender)
        {
            if (ready == false) return;
            if (dataTemp.alwaysOnTop) dataTemp.alwaysOnTop = false;
            else dataTemp.alwaysOnTop = true;
        }

        private void cbxClassicalForm_CheckedChanged(object sender)
        {
            if (ready == false) return;
            if (dataTemp.classicalWindowsForm) dataTemp.classicalWindowsForm = false;
            else dataTemp.classicalWindowsForm = true;
        }
    }
}

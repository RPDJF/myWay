using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myWay.data;
using myWay.myClass;

namespace myWay.myComponents
{
    public partial class ucRaccourcis : UserControl
    {
        // var
        private myClass.raccourcis contextRaccourcis;

        public ucRaccourcis(myClass.raccourcis contextRaccourcis)
        {
            InitializeComponent();
            pnlToolbox.BackColor = btnBody.BackColor;
            this.contextRaccourcis = contextRaccourcis;
            refresh();
        }
        // Getters
        public String getName()
        {
            return contextRaccourcis.getName();
        }
        // END - Getters
        // Setters
        public void setName(String name)
        {
            this.contextRaccourcis.setName(name);
            refresh();
        }
        // END - Setters
        // Refresh component
        public void refresh()
        {
            if(contextRaccourcis.getDescription() == "" || contextRaccourcis.getDescription() == null)
            {
                btnBody.Text = contextRaccourcis.getName();
            }
            else
            {
                btnBody.Text = contextRaccourcis.getName() + " - " + contextRaccourcis.getDescription();
            }
            
        }
        // END - Refresh component
        // Display toolbox
        public void ShowTools(object sender, EventArgs e)
        {
            btnBody.BackColor = Color.MediumPurple;
            btnEdit.BackColor = Color.MediumPurple;
            btnRemove.BackColor = Color.MediumPurple;
            btnEdit.Visible = true;
            btnRemove.Visible = true;
        }
        // END - Display toolbox
        // Hide toolbox
        public void HideTools(object sender, EventArgs e)
        {
            btnBody.BackColor = Color.MediumSlateBlue;
            btnEdit.BackColor = Color.MediumSlateBlue;
            btnRemove.BackColor = Color.MediumSlateBlue;
            btnEdit.Visible = false;
            btnRemove.Visible = false;
        }
        // END - Hide toolbox
        // Control events
        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataTemp.selectedSection.removeShortcut(this.getName());
            data.dataSave saver = new dataSave(); saver.saveSections();
            this.Parent = null;
            this.DestroyHandle();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            myForms.frmAskRaccourcis askRaccourcis = new myForms.frmAskRaccourcis("edit",contextRaccourcis);
            askRaccourcis.FormClosed += (s, ex) => { refresh(); };
            askRaccourcis.ShowDialog();
        }
        private void btnBody_Click(object sender, EventArgs e)
        {
            try
            {
                String runPath = this.contextRaccourcis.getPath();
                String[] aRunPath = runPath.Split('@');
                if(aRunPath.GetLength(0) > 1)
                {
                    System.Diagnostics.Process.Start("mailto:" + this.contextRaccourcis.getPath()); // try to send mail
                }
                else
                {
                    System.Diagnostics.Process.Start(this.contextRaccourcis.getPath()); // try to run shortcut
                }
                
            }
            catch(Exception ex)
            {
                // Get reference to the dialog type.
                var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);

                // Create dialog instance.
                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

                // Populate relevant properties on the dialog instance.
                dialog.Text = "ERREUR";
                dialogType.GetProperty("Details").SetValue(dialog, ex.ToString(), null);
                dialogType.GetProperty("Message").SetValue(dialog, "Une erreur est survenue à l'ouverture du raccourci.\nVérifier que le chemin soit correct.", null);

                // Display dialog.
                var result = dialog.ShowDialog();
            }
        }
        // END - Control events
    }
}

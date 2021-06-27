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
    public partial class ucSections : UserControl
    {
        // var
        private String name;
        private Boolean isReady = false;

        // list raccourcis
        private List<raccourcis> listRaccourcis = new List<raccourcis>();
        public ucSections(String name)
        {
            InitializeComponent();
            pnlToolbox.BackColor = btnBody.BackColor;
            this.name = name;
            refresh();
        }
        // Getters
        public String getName()
        {
            return this.name;
        }
        public List<raccourcis> getRaccourcis()
        {
            return this.listRaccourcis;
        }
        public Boolean getReady()
        {
            return isReady;
        }
        // END - Getters
        // Setters
        public void setName(String name)
        {
            this.name = name;
            refresh();
        }
        public void setReady(Boolean inputBool)
        {
            this.isReady = inputBool;
        }
        // END - Setters
        // Refresh component
        public void refresh()
        {
            btnBody.Text = name;
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
        // Add new shortcut
        public void addShortcut(String name, String path)
        {
            addShortcut(name, path, "");
        }
        public void addShortcut(String name, String path ,String description)
        {
            addShortcut(name, path, description, Color.White);
        }
        public void addShortcut(String name, String path, String description, Color color)
        {
            listRaccourcis.Add(new raccourcis(name, path, description, color));
        }
        // END - Add new shortcut
        // Remove specific shortcut
        public void removeShortcut(String name)
        {
            foreach(raccourcis shortcut in listRaccourcis)
            {
                if (shortcut.getName() == name)
                {
                    listRaccourcis.Remove(shortcut);
                    return;
                }
            }
        }
        // END - Remove specific shortcut
        // raccourcisExists
        public Boolean raccourcisExists(raccourcis inputRaccourcis)
        {
            foreach(raccourcis shortcut in listRaccourcis)
            {
                if (shortcut.getName() == inputRaccourcis.getName()) return true;
            }
            return false;
        }
        public Boolean raccourcisExists(String inputRaccourcisName)
        {
            foreach (raccourcis shortcut in listRaccourcis)
            {
                if (shortcut.getName() == inputRaccourcisName) return true;
            }
            return false;
        }
        // END - raccourcisExists
        // Find raccourcis
        public raccourcis findRaccourcis(String inputRaccourcisName)
        {
            foreach(raccourcis shortcut in listRaccourcis)
            {
                if (shortcut.getName() == inputRaccourcisName) return shortcut;
            }
            return new raccourcis("null","null");
        }
        // Control events
        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataSections.removeSection(this);
            data.dataSave saver = new dataSave(); saver.saveSections();
            this.Parent = null;
            this.DestroyHandle();
        }
        private void Sections_Enter(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            myForms.frmAskTextInput askName = new myForms.frmAskTextInput("edit", this, this.name);
            askName.ShowDialog();
        }
        private void btnBody_Click(object sender, EventArgs e)
        {
            dataTemp.selectedSection = this;
        }
        // END - Control events
    }
}

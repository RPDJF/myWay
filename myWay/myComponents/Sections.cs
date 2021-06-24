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

namespace myWay.myComponents
{
    public partial class Sections : UserControl
    {
        // var
        private String name;
        public Sections(String name)
        {
            InitializeComponent();
            pnlToolbox.BackColor = btnBody.BackColor;
            this.name = name;
            refresh();
        }
        // Getters
        public String getValue()
        {
            return this.name;
        }
        // END - Getters
        // Setters
        public void setValue(String name)
        {
            this.name = name;
            refresh();
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
        // Control events
        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataSections.removeSection(this);
            this.Parent = null;
            this.DestroyHandle();
        }
        private void Sections_Enter(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            myForms.frmAskTextInput askName = new myForms.frmAskTextInput("edit", this);
            askName.ShowDialog();
        }
        // END - Control events
    }
}

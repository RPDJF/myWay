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
        private String value;

        public Sections()
        {
            InitializeComponent();
            this.value = "unnamed item";
            btnBody.Text = value;
        }

        public Sections(String value)
        {
            InitializeComponent();
            this.value = value;
            btnBody.Text = value;
        }

        public String getValue()
        {
            return this.value;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            applicationData.listSections.Remove(this);
            this.Parent = null;
            this.DestroyHandle();
        }

        public void ShowTools()
        {
            btnEdit.Visible = true;
            btnRemove.Visible = true;
        }
        public void HideTools()
        {
            btnEdit.Visible = false;
            btnRemove.Visible = false;
        }
    }
}

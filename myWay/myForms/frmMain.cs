using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myWay.myComponents;
using myWay.data;

namespace myWay
{

    public partial class frmMain : Form
    {
        // vars
        List<Sections> listSections = data.dataSections.GetSections();
        // WINDOW DRAG VAR
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // END - WINDOW DRAG VAR
        public frmMain()
        {
            InitializeComponent();
        }
        // Generate - Refresh component in panels
        public Panel setComponentToPanel(Panel inputPanel, List<Sections> sectionsList)
        {
            Panel outputPanel = inputPanel;
            outputPanel.Controls.Clear(); // clear actual shown sections
            if (listSections.Count <= 0) return outputPanel; // stop here if no sections
            Sections[] aSections = sectionsList.ToArray();
            outputPanel.Controls.AddRange(aSections);
            return outputPanel; // return the new panel
        }
        public void refreshPnlSectionContent()
        {
            setComponentToPanel(pnlSectionContent, dataSections.GetSections());
            return;
        }
        // END - Generate - Refresh component in panels
        // CONTROLS EVENTS
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close app
            Application.Exit();
        }
        private void btnReduce_Click(object sender, EventArgs e)
        {
            // Minimize app
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnSize_Click(object sender, EventArgs e)
        {
            // Window size
            switch(this.WindowState){
                case FormWindowState.Maximized:
                    this.WindowState = FormWindowState.Normal;
                    OnPaint(null);
                    break;
                case FormWindowState.Normal:
                    this.WindowState = FormWindowState.Maximized;
                    break;
                default:
                    this.WindowState = FormWindowState.Normal;
                    OnPaint(null);
                    break;
            }
        }
        private void pnlAppTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            // WINDOW DRAG BAR
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                OnPaint(null);
            }
            // END - WINDOW DRAG BAR
        }
        private void lblAppName_MouseMove(object sender, MouseEventArgs e)
        {
            pnlAppTopBar_MouseMove(sender, e);
        }
        private void pnlAppTopBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnSize_Click(null, null);
        }
        private void btnIcon_Click(object sender, EventArgs e)
        {
            if (pnlLeft.Visible)
            {
                pnlLeft.Visible = false; // Open section menu
                btnOpenSection.IconChar = FontAwesome.Sharp.IconChar.Box; // Change icon
                btnOpenSection.IconSize = 28;
            }
            else
            {
                pnlLeft.Visible = true; // Close section menu
                btnOpenSection.IconChar = FontAwesome.Sharp.IconChar.BoxOpen; // Change icon
                btnOpenSection.IconSize = 35;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (listSections.Count <= 0) return; // cancel if no existing sections
            List<Sections> filteredSections = new List<Sections>(); // list that will contain results
            String searchFilter = mtbxSectionSearch.Text; // get data from research bar
            foreach(Sections mySection in listSections)
            {
                if (mySection.getValue().Contains(searchFilter)) filteredSections.Add(mySection); // add results to filtered list
            }
            pnlSectionContent = setComponentToPanel(pnlSectionContent, filteredSections); // show filtered list

        }
        private void mtbxSectionSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }
        private void btnAddSection_Click(object sender, EventArgs e)
        {
            myForms.frmAskTextInput askName = new myForms.frmAskTextInput("add");
            askName.FormClosed += (s, ex) => {refreshPnlSectionContent();};
            askName.ShowDialog();
        }
    }
}

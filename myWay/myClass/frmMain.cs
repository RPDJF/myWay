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
        List<Sections> listSections = data.applicationData.listSections;
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
            OnPaint(null);
            
        }
        // ROUNDED EDGES
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 25, 25, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 25, Rect.Y, 25, 25, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 25, Rect.Y + Rect.Height - 25, 25, 25, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 25, 25, 25, 90, 90);
            this.Region = new Region(GraphPath);
        }
        // END - ROUNDED EDGES
        // Generate sections
        public Panel setSectionsToPannel(Panel inputPanel, List<Sections> sectionsList)
        {
            Panel outputPanel = inputPanel;
            outputPanel.Controls.Clear(); // clear actual shown sections
            if (listSections.Count <= 0) return outputPanel; // stop here if no sections
            Sections[] aSections = sectionsList.ToArray();
            outputPanel.Controls.AddRange(aSections);
            return outputPanel; // return the new panel
        }
        // END - Generate sections
        // Check if section already exist
        public Boolean sectionExists(Sections inputSection, List<Sections> listReference)
        {
            foreach(Sections mySection in listReference)
            {
                if (mySection.getValue() == inputSection.getValue()) return true; // return true if find similar section on reference list
            }
            return false;
        }
        // CONTROLS EVENTS
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close app
            this.Close();
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
            if (pnlLeft.Visible) pnlLeft.Visible = false; // Open section menu
            else pnlLeft.Visible = true;
        }
        private void lblSection_Click(object sender, EventArgs e)
        {
            // FOR DEBUG PURPOSE ONLY
            Random rndGen = new Random();
            Sections mySection = new Sections("item " + rndGen.Next(0,99)); // debug add section
            if (sectionExists(mySection, listSections)) return; // cancel if section already exists
            mySection.Dock = DockStyle.Top;
            listSections.Add(mySection); // add section to the list
            pnlSectionContent = setSectionsToPannel(pnlSectionContent, listSections); // show current sections
        }
        private void pnlSectionContent_ControlAdded(object sender, ControlEventArgs e)
        {
            pnlSectionContent.VerticalScroll.Visible = false;
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
            pnlSectionContent = setSectionsToPannel(pnlSectionContent, filteredSections); // show filtered list

        }
        private void mtbxSectionSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }
        // END - CONTROLS EVENTS
    }
}

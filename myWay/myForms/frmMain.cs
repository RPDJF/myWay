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
using myWay.myClass;

namespace myWay
{
    public partial class frmMain : Form
    {
        // vars
        public List<ucSections> listSections = dataSections.GetSections();
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
        public Panel SetComponentToPanel(Panel inputPanel, List<ucSections> sectionsList)
        {
            Panel outputPanel = inputPanel;
            outputPanel.Controls.Clear(); // clear actual shown sections
            if (listSections.Count <= 0) return outputPanel; // stop here if no sections
            foreach(ucSections section in listSections)
            {
                if(!section.getReady())
                {
                    section.btnBody.Click += (s,e) => { lblCollection.Text = dataTemp.selectedSection.getName(); };
                }
            }
            ucSections[] aSections = sectionsList.ToArray();
            outputPanel.Controls.AddRange(aSections);
            return outputPanel; // return the new panel
        }
        public Panel SetComponentToPanel(Panel inputPanel, List<raccourcis> classRacourcis)
        {
            Panel outputPanel = inputPanel;
            List<ucRaccourcis> listRaccourcis = new List<ucRaccourcis>();
            foreach(raccourcis myRaccourcis in dataTemp.selectedSection.getRaccourcis())
            {
                ucRaccourcis myUcRaccourcis = new ucRaccourcis(myRaccourcis)
                {
                    Dock = DockStyle.Top
                };
                listRaccourcis.Add(myUcRaccourcis);
            }
            outputPanel.Controls.Clear(); // clear actual shown sections
            if (listSections.Count <= 0) return outputPanel; // stop here if no sections
            ucRaccourcis[] aRaccourcis = listRaccourcis.ToArray();
            outputPanel.Controls.AddRange(aRaccourcis);
            return outputPanel; // return the new panel
        }
        public void RefreshContents()
        {
            SetComponentToPanel(pnlSectionContent, dataSections.GetSections());
            if(dataTemp.selectedSection != null) SetComponentToPanel(pnlRaccourcisContent, dataTemp.selectedSection.getRaccourcis());
            if(data.dataTemp.selectedSection != null)
            {
                lblCollection.Text = data.dataTemp.selectedSection.getName();
            }
            this.TopMost = dataTemp.alwaysOnTop;
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
                    break;
                case FormWindowState.Normal:
                    this.WindowState = FormWindowState.Maximized;
                    break;
                default:
                    this.WindowState = FormWindowState.Normal;
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
            List<ucSections> filteredSections = new List<ucSections>(); // list that will contain results
            String searchFilter = mtbxSectionSearch.Text.ToLower(); // get data from research bar
            foreach(ucSections mySection in listSections)
            {
                if (mySection.getName().ToLower().Contains(searchFilter)) filteredSections.Add(mySection); // add results to filtered list
            }
            pnlSectionContent = SetComponentToPanel(pnlSectionContent, filteredSections); // show filtered list
        }
        private void mtbxSectionSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }
        private void btnAddSection_Click(object sender, EventArgs e)
        {
            myForms.frmAskTextInput askName = new myForms.frmAskTextInput("add");
            askName.FormClosed += (s, ex) => {RefreshContents(); /*data.dataSave saver = new dataSave();saver.saveSections();*/ };
            askName.ShowDialog();
        }

        private void btnAddRaccourcis_Click(object sender, EventArgs e)
        {
            if (dataSections.GetSections().Count <= 0)
            {
                var confirm = MessageBox.Show("Vous devez d'abord créer une nouvelle section.\n\nCréer une nouvelle section ?", "Créer une nouvelle section", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm.ToString() == "Yes")
                {
                    btnAddSection_Click(sender, e);
                }
            }
            if (dataTemp.selectedSection != null)
            {
                myForms.frmAskRaccourcis frmAskRaccourcis = new myForms.frmAskRaccourcis("add");
                frmAskRaccourcis.FormClosed += (s, ex) => { RefreshContents(); /*data.dataSave saver = new dataSave(); saver.saveSections();*/ };
                frmAskRaccourcis.ShowDialog();
            }
        }
        private void lblCollection_TextChanged(object sender, EventArgs e)
        {
            SetComponentToPanel(pnlRaccourcisContent,dataTemp.selectedSection.getRaccourcis());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dataSave saver = new dataSave();
            saver.importData();
            RefreshContents();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            // show about frame
            myForms.frmAbout about = new myForms.frmAbout();
            about.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            myForms.frmSettings settings = new myForms.frmSettings();
            if(settings.ShowDialog() == DialogResult.OK)
            {
                RefreshContents();
                dataSave saver = new dataSave();
                saver.saveSettings();
            }
        }
        // END - CONTROLS EVENTS
    }
}

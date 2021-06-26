using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myWay.myComponents;

namespace myWay.myForms
{
    public partial class frmAskTextInput : Form
    {
        // var
        private String inputType;
        private ucSections inputSection;
        // WINDOW DRAG VAR
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // END - WINDOW DRAG VAR
        // inputs : add, edit
        public frmAskTextInput(String inputType) : this(inputType, null)
        {
        }
        public frmAskTextInput(String inputType, ucSections inputSection) : this(inputType,  inputSection, null)
        {
        }
        public frmAskTextInput(String inputType, ucSections inputSection, String autoComplete)
        {
            InitializeComponent();
            this.inputType = inputType;
            this.inputSection = inputSection;
            tbxInput.Text = autoComplete;
            tbxInput.Select();
        }
        // Control events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        // WINDOW DRAG BAR
        private void lblAppName_MouseMove(object sender, MouseEventArgs e)
        {
            pnlAppTopBar_MouseMove(sender, e);
        }
        // END - WINDOW DRAG BAR

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Char[] testChar = tbxInput.Text.ToCharArray();
            frmMain frmMain = new frmMain();
            if (data.dataSections.sectionExists(new myComponents.ucSections(tbxInput.Text)))
            {
                MessageBox.Show("Impossible !\nUne séction du même nom existe déjà","ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(tbxInput.Text == null || tbxInput.Text == "")
            {
                MessageBox.Show("Impossible !\nLe champ est requis", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(testChar[0] == ' ' || testChar[testChar.Length-1] == ' ')
            {
                MessageBox.Show("Impossible !\nLa fin et le début ne doivent pas contenir d'espaces","ERREUR", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                switch (inputType)
                {
                    case "add":
                        data.dataSections.addSection(tbxInput.Text);
                        frmMain.refreshContents();
                        break;

                    case "edit":
                        inputSection.setName(tbxInput.Text);
                        break;
                }
                
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // END - Control events
    }
}

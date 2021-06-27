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
using myWay.myClass;
using myWay.data;

namespace myWay.myForms
{
    public partial class frmAskRaccourcis : Form
    {
        // var
        private String inputType;
        private raccourcis inputRaccourcis;
        // WINDOW DRAG VAR
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // END - WINDOW DRAG VAR
        public frmAskRaccourcis(String inputType) : this(inputType, null)
        {
        }
        public frmAskRaccourcis(String inputType, raccourcis inputRaccourcis)
        {
            InitializeComponent();
            this.inputType = inputType;
            this.inputRaccourcis = inputRaccourcis;
            if(inputRaccourcis != null)
            {
                this.tbxInputName.Text = inputRaccourcis.getName();
                this.tbxInputDescription.Text = inputRaccourcis.getDescription();
                this.tbxInputChemin.Text = inputRaccourcis.getPath();
            }
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
            Char[] testChar = tbxInputName.Text.ToCharArray();
            frmMain frmMain = new frmMain();
            if (inputType == "add" && data.dataTemp.selectedSection.raccourcisExists(tbxInputName.Text))
            {
                MessageBox.Show("Impossible !\nUn raccourci du même nom existe déjà", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (inputType == "edit" && inputRaccourcis.getName() != tbxInputName.Text && data.dataTemp.selectedSection.raccourcisExists(tbxInputName.Text))
            {
                MessageBox.Show("Impossible !\nUn raccourci du même nom existe déjà", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbxInputName.Text == null || tbxInputName.Text == "" || tbxInputChemin.Text == null || tbxInputChemin.Text == "")
            {
                MessageBox.Show("Impossible !\nLe champ Nom et Chemin sont requis !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (testChar[0] == ' ' || testChar[testChar.Length - 1] == ' ')
            {
                MessageBox.Show("Impossible !\nLa fin et le début du raccourci ne doivent pas contenir d'espaces", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataSave saver = new dataSave();
                switch (inputType)
                {
                    case "add":
                        dataTemp.selectedSection.addShortcut(tbxInputName.Text, tbxInputChemin.Text ,tbxInputDescription.Text);
                        saver.saveSections();
                        frmMain.refreshContents();
                        break;

                    case "edit":
                        inputRaccourcis.setName(tbxInputName.Text);
                        inputRaccourcis.setDescription(tbxInputDescription.Text);
                        inputRaccourcis.setPath(tbxInputChemin.Text);
                        saver.saveSections();
                        break;
                }

                this.Close();
            }
        }
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if(ofd.FileName != null || ofd.FileName != "")
            {
                tbxInputChemin.Text = ofd.FileName;
            }
        }
    }
}

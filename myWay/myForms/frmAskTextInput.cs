﻿using System;
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
using myWay.data;

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
            dataChecker check = new dataChecker();
            if(check.validateSectionName(tbxInput.Text) || (inputType == "profil"))
            {
                dataSave saver = new dataSave();
                switch (inputType)
                {
                    case "add":
                        ucSections mySection = dataSections.addSection(tbxInput.Text);
                        saver.saveSections();
                        dataTemp.selectedSection = mySection;
                        break;
                    case "edit":
                        inputSection.setName(tbxInput.Text);
                        saver.saveSections();
                        break;
                    case "profil":
                        if (check.validateProfilName(tbxInput.Text))
                        {
                            saver.ClearData();
                            dataTemp.profilName = tbxInput.Text + ".xml";
                            saver.saveSections();
                            saver.saveSettings();
                        }
                        break;
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(sender, e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(sender, e);
            }
        }

        private void frmAskTextInput_Load(object sender, EventArgs e)
        {
            if(inputType == "profil")
            {
                lblTitle.Text = "Nommer le profil";
            }
        }
        // END - Control events
    }
}


namespace myWay.myForms
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlAppTopBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.pnlTopSettings = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlSettingsCategorie = new System.Windows.Forms.Panel();
            this.pnlDonnees = new System.Windows.Forms.Panel();
            this.btnDonneesExport = new FontAwesome.Sharp.IconButton();
            this.btnDonneesImport = new FontAwesome.Sharp.IconButton();
            this.btnDonnees = new FontAwesome.Sharp.IconButton();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.btnGeneralProfile = new FontAwesome.Sharp.IconButton();
            this.btnGeneralAffichage = new FontAwesome.Sharp.IconButton();
            this.btnGeneral = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlAppTopBar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlTopSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlSettingsCategorie.SuspendLayout();
            this.pnlDonnees.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(6, 2);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(69, 20);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "myWay";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAppTopBar
            // 
            this.pnlAppTopBar.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlAppTopBar.Controls.Add(this.lblAppName);
            this.pnlAppTopBar.Controls.Add(this.btnClose);
            this.pnlAppTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppTopBar.Location = new System.Drawing.Point(2, 2);
            this.pnlAppTopBar.Name = "pnlAppTopBar";
            this.pnlAppTopBar.Size = new System.Drawing.Size(614, 28);
            this.pnlAppTopBar.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Snow;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(577, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(37, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlTopBar.Controls.Add(this.btnCancel);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 285);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(614, 39);
            this.pnlTopBar.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(531, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Fermer";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlTopSettings
            // 
            this.pnlTopSettings.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlTopSettings.Controls.Add(this.lblTitle);
            this.pnlTopSettings.Controls.Add(this.iconPictureBox1);
            this.pnlTopSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSettings.Name = "pnlTopSettings";
            this.pnlTopSettings.Size = new System.Drawing.Size(614, 58);
            this.pnlTopSettings.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Paramètres";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(13, 17);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 32);
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            // 
            // pnlSettingsCategorie
            // 
            this.pnlSettingsCategorie.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlSettingsCategorie.Controls.Add(this.pnlDonnees);
            this.pnlSettingsCategorie.Controls.Add(this.btnDonnees);
            this.pnlSettingsCategorie.Controls.Add(this.pnlGeneral);
            this.pnlSettingsCategorie.Controls.Add(this.btnGeneral);
            this.pnlSettingsCategorie.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSettingsCategorie.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.pnlSettingsCategorie.Location = new System.Drawing.Point(0, 58);
            this.pnlSettingsCategorie.Name = "pnlSettingsCategorie";
            this.pnlSettingsCategorie.Size = new System.Drawing.Size(190, 227);
            this.pnlSettingsCategorie.TabIndex = 25;
            // 
            // pnlDonnees
            // 
            this.pnlDonnees.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDonnees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(146)))), ((int)(((byte)(242)))));
            this.pnlDonnees.Controls.Add(this.btnDonneesExport);
            this.pnlDonnees.Controls.Add(this.btnDonneesImport);
            this.pnlDonnees.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDonnees.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.pnlDonnees.Location = new System.Drawing.Point(0, 148);
            this.pnlDonnees.Name = "pnlDonnees";
            this.pnlDonnees.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlDonnees.Size = new System.Drawing.Size(190, 60);
            this.pnlDonnees.TabIndex = 27;
            this.pnlDonnees.Visible = false;
            // 
            // btnDonneesExport
            // 
            this.btnDonneesExport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDonneesExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonneesExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonneesExport.FlatAppearance.BorderSize = 0;
            this.btnDonneesExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnDonneesExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonneesExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDonneesExport.ForeColor = System.Drawing.Color.White;
            this.btnDonneesExport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDonneesExport.IconColor = System.Drawing.Color.Black;
            this.btnDonneesExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonneesExport.Location = new System.Drawing.Point(20, 30);
            this.btnDonneesExport.Name = "btnDonneesExport";
            this.btnDonneesExport.Size = new System.Drawing.Size(170, 30);
            this.btnDonneesExport.TabIndex = 25;
            this.btnDonneesExport.Text = "exporter";
            this.btnDonneesExport.UseVisualStyleBackColor = false;
            this.btnDonneesExport.Click += new System.EventHandler(this.btnDonneesExport_Click);
            // 
            // btnDonneesImport
            // 
            this.btnDonneesImport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDonneesImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonneesImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonneesImport.FlatAppearance.BorderSize = 0;
            this.btnDonneesImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnDonneesImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonneesImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDonneesImport.ForeColor = System.Drawing.Color.White;
            this.btnDonneesImport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDonneesImport.IconColor = System.Drawing.Color.Black;
            this.btnDonneesImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonneesImport.Location = new System.Drawing.Point(20, 0);
            this.btnDonneesImport.Name = "btnDonneesImport";
            this.btnDonneesImport.Size = new System.Drawing.Size(170, 30);
            this.btnDonneesImport.TabIndex = 24;
            this.btnDonneesImport.Text = "importer";
            this.btnDonneesImport.UseVisualStyleBackColor = false;
            this.btnDonneesImport.Click += new System.EventHandler(this.btnDonneesImport_Click);
            // 
            // btnDonnees
            // 
            this.btnDonnees.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDonnees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonnees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonnees.FlatAppearance.BorderSize = 0;
            this.btnDonnees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnDonnees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDonnees.ForeColor = System.Drawing.Color.White;
            this.btnDonnees.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDonnees.IconColor = System.Drawing.Color.Black;
            this.btnDonnees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonnees.Location = new System.Drawing.Point(0, 104);
            this.btnDonnees.Name = "btnDonnees";
            this.btnDonnees.Size = new System.Drawing.Size(190, 44);
            this.btnDonnees.TabIndex = 22;
            this.btnDonnees.Text = "Données";
            this.btnDonnees.UseVisualStyleBackColor = false;
            this.btnDonnees.Click += new System.EventHandler(this.btnDonnees_Click);
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(146)))), ((int)(((byte)(242)))));
            this.pnlGeneral.Controls.Add(this.btnGeneralProfile);
            this.pnlGeneral.Controls.Add(this.btnGeneralAffichage);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGeneral.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.pnlGeneral.Location = new System.Drawing.Point(0, 44);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlGeneral.Size = new System.Drawing.Size(190, 60);
            this.pnlGeneral.TabIndex = 28;
            this.pnlGeneral.Visible = false;
            // 
            // btnGeneralProfile
            // 
            this.btnGeneralProfile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGeneralProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneralProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneralProfile.FlatAppearance.BorderSize = 0;
            this.btnGeneralProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnGeneralProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGeneralProfile.ForeColor = System.Drawing.Color.White;
            this.btnGeneralProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGeneralProfile.IconColor = System.Drawing.Color.Black;
            this.btnGeneralProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGeneralProfile.Location = new System.Drawing.Point(20, 30);
            this.btnGeneralProfile.Name = "btnGeneralProfile";
            this.btnGeneralProfile.Size = new System.Drawing.Size(170, 30);
            this.btnGeneralProfile.TabIndex = 25;
            this.btnGeneralProfile.Text = "profil";
            this.btnGeneralProfile.UseVisualStyleBackColor = false;
            // 
            // btnGeneralAffichage
            // 
            this.btnGeneralAffichage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGeneralAffichage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneralAffichage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneralAffichage.FlatAppearance.BorderSize = 0;
            this.btnGeneralAffichage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnGeneralAffichage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGeneralAffichage.ForeColor = System.Drawing.Color.White;
            this.btnGeneralAffichage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGeneralAffichage.IconColor = System.Drawing.Color.Black;
            this.btnGeneralAffichage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGeneralAffichage.Location = new System.Drawing.Point(20, 0);
            this.btnGeneralAffichage.Name = "btnGeneralAffichage";
            this.btnGeneralAffichage.Size = new System.Drawing.Size(170, 30);
            this.btnGeneralAffichage.TabIndex = 24;
            this.btnGeneralAffichage.Text = "affichage";
            this.btnGeneralAffichage.UseVisualStyleBackColor = false;
            this.btnGeneralAffichage.Click += new System.EventHandler(this.btnGeneralAffichage_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGeneral.ForeColor = System.Drawing.Color.White;
            this.btnGeneral.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGeneral.IconColor = System.Drawing.Color.Black;
            this.btnGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(190, 44);
            this.btnGeneral.TabIndex = 21;
            this.btnGeneral.Text = "Général";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlContent.Controls.Add(this.pnlFrame);
            this.pnlContent.Controls.Add(this.pnlSettingsCategorie);
            this.pnlContent.Controls.Add(this.pnlTopSettings);
            this.pnlContent.Controls.Add(this.pnlTopBar);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.pnlContent.Location = new System.Drawing.Point(2, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(614, 324);
            this.pnlContent.TabIndex = 15;
            // 
            // pnlFrame
            // 
            this.pnlFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrame.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.pnlFrame.Location = new System.Drawing.Point(190, 58);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(424, 227);
            this.pnlFrame.TabIndex = 26;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 356);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlAppTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.pnlAppTopBar.ResumeLayout(false);
            this.pnlAppTopBar.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopSettings.ResumeLayout(false);
            this.pnlTopSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlSettingsCategorie.ResumeLayout(false);
            this.pnlDonnees.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lblAppName;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel pnlAppTopBar;
        private System.Windows.Forms.Panel pnlTopBar;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Panel pnlTopSettings;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel pnlSettingsCategorie;
        private FontAwesome.Sharp.IconButton btnDonnees;
        private FontAwesome.Sharp.IconButton btnGeneral;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlFrame;
        private System.Windows.Forms.Panel pnlDonnees;
        private FontAwesome.Sharp.IconButton btnDonneesExport;
        private FontAwesome.Sharp.IconButton btnDonneesImport;
        private System.Windows.Forms.Panel pnlGeneral;
        private FontAwesome.Sharp.IconButton btnGeneralProfile;
        private FontAwesome.Sharp.IconButton btnGeneralAffichage;
    }
}
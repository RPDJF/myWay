
namespace myWay.myForms
{
    partial class frmAskRaccourcis
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
            this.pnlAppTopBar = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnConfirm = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.tbxInputName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInputName = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnChooseFile = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.tbxInputDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblInputDescription = new System.Windows.Forms.Label();
            this.tbxInputChemin = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblInputChemin = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pnlAppTopBar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAppTopBar
            // 
            this.pnlAppTopBar.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlAppTopBar.Controls.Add(this.lblAppName);
            this.pnlAppTopBar.Controls.Add(this.btnClose);
            this.pnlAppTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppTopBar.Location = new System.Drawing.Point(2, 2);
            this.pnlAppTopBar.Name = "pnlAppTopBar";
            this.pnlAppTopBar.Size = new System.Drawing.Size(364, 28);
            this.pnlAppTopBar.TabIndex = 12;
            this.pnlAppTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlAppTopBar_MouseMove);
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
            this.lblAppName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAppName_MouseMove);
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
            this.btnClose.Location = new System.Drawing.Point(327, 0);
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
            this.pnlTopBar.Controls.Add(this.btnConfirm);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 200);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(364, 39);
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
            this.btnCancel.Location = new System.Drawing.Point(281, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfirm.IconColor = System.Drawing.Color.Black;
            this.btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirm.Location = new System.Drawing.Point(195, 7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(80, 25);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 31;
            this.iconPictureBox1.Location = new System.Drawing.Point(11, 13);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 32);
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            // 
            // tbxInputName
            // 
            this.tbxInputName.AutoCompleteCustomSource = null;
            this.tbxInputName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxInputName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxInputName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxInputName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxInputName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxInputName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbxInputName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInputName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbxInputName.Image = null;
            this.tbxInputName.IsDerivedStyle = false;
            this.tbxInputName.Lines = null;
            this.tbxInputName.Location = new System.Drawing.Point(109, 59);
            this.tbxInputName.MaxLength = 32767;
            this.tbxInputName.Multiline = false;
            this.tbxInputName.Name = "tbxInputName";
            this.tbxInputName.ReadOnly = false;
            this.tbxInputName.Size = new System.Drawing.Size(233, 26);
            this.tbxInputName.Style = MetroSet_UI.Enums.Style.Light;
            this.tbxInputName.StyleManager = null;
            this.tbxInputName.TabIndex = 0;
            this.tbxInputName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxInputName.ThemeAuthor = "Narwin";
            this.tbxInputName.ThemeName = "MetroLite";
            this.tbxInputName.UseSystemPasswordChar = false;
            this.tbxInputName.WatermarkText = "exemple";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(48, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Ajouter un raccourci";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputName
            // 
            this.lblInputName.AutoSize = true;
            this.lblInputName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputName.ForeColor = System.Drawing.Color.Black;
            this.lblInputName.Location = new System.Drawing.Point(8, 62);
            this.lblInputName.Name = "lblInputName";
            this.lblInputName.Size = new System.Drawing.Size(47, 16);
            this.lblInputName.TabIndex = 11;
            this.lblInputName.Text = "Nom :";
            this.lblInputName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlContent.Controls.Add(this.btnChooseFile);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.lblRequired);
            this.pnlContent.Controls.Add(this.tbxInputDescription);
            this.pnlContent.Controls.Add(this.lblInputDescription);
            this.pnlContent.Controls.Add(this.tbxInputChemin);
            this.pnlContent.Controls.Add(this.lblInputChemin);
            this.pnlContent.Controls.Add(this.pnlTopBar);
            this.pnlContent.Controls.Add(this.iconPictureBox1);
            this.pnlContent.Controls.Add(this.tbxInputName);
            this.pnlContent.Controls.Add(this.lblTitle);
            this.pnlContent.Controls.Add(this.lblInputName);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.pnlContent.Location = new System.Drawing.Point(2, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(364, 239);
            this.pnlContent.TabIndex = 13;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnChooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChooseFile.ForeColor = System.Drawing.Color.White;
            this.btnChooseFile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChooseFile.IconColor = System.Drawing.Color.Black;
            this.btnChooseFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChooseFile.Location = new System.Drawing.Point(109, 155);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(139, 25);
            this.btnChooseFile.TabIndex = 22;
            this.btnChooseFile.Text = "Choisir un fichier ...";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(48, 59);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(17, 16);
            this.lblRequired.TabIndex = 22;
            this.lblRequired.Text = "*";
            // 
            // tbxInputDescription
            // 
            this.tbxInputDescription.AutoCompleteCustomSource = null;
            this.tbxInputDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxInputDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxInputDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxInputDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxInputDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxInputDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbxInputDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInputDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbxInputDescription.Image = null;
            this.tbxInputDescription.IsDerivedStyle = false;
            this.tbxInputDescription.Lines = null;
            this.tbxInputDescription.Location = new System.Drawing.Point(109, 91);
            this.tbxInputDescription.MaxLength = 32767;
            this.tbxInputDescription.Multiline = false;
            this.tbxInputDescription.Name = "tbxInputDescription";
            this.tbxInputDescription.ReadOnly = false;
            this.tbxInputDescription.Size = new System.Drawing.Size(233, 26);
            this.tbxInputDescription.Style = MetroSet_UI.Enums.Style.Light;
            this.tbxInputDescription.StyleManager = null;
            this.tbxInputDescription.TabIndex = 1;
            this.tbxInputDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxInputDescription.ThemeAuthor = "Narwin";
            this.tbxInputDescription.ThemeName = "MetroLite";
            this.tbxInputDescription.UseSystemPasswordChar = false;
            this.tbxInputDescription.WatermarkText = "exemple";
            // 
            // lblInputDescription
            // 
            this.lblInputDescription.AutoSize = true;
            this.lblInputDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDescription.ForeColor = System.Drawing.Color.Black;
            this.lblInputDescription.Location = new System.Drawing.Point(8, 94);
            this.lblInputDescription.Name = "lblInputDescription";
            this.lblInputDescription.Size = new System.Drawing.Size(92, 16);
            this.lblInputDescription.TabIndex = 19;
            this.lblInputDescription.Text = "Description :";
            this.lblInputDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxInputChemin
            // 
            this.tbxInputChemin.AutoCompleteCustomSource = null;
            this.tbxInputChemin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxInputChemin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxInputChemin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxInputChemin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxInputChemin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxInputChemin.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbxInputChemin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInputChemin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbxInputChemin.Image = null;
            this.tbxInputChemin.IsDerivedStyle = false;
            this.tbxInputChemin.Lines = null;
            this.tbxInputChemin.Location = new System.Drawing.Point(109, 123);
            this.tbxInputChemin.MaxLength = 32767;
            this.tbxInputChemin.Multiline = false;
            this.tbxInputChemin.Name = "tbxInputChemin";
            this.tbxInputChemin.ReadOnly = false;
            this.tbxInputChemin.Size = new System.Drawing.Size(233, 26);
            this.tbxInputChemin.Style = MetroSet_UI.Enums.Style.Light;
            this.tbxInputChemin.StyleManager = null;
            this.tbxInputChemin.TabIndex = 2;
            this.tbxInputChemin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxInputChemin.ThemeAuthor = "Narwin";
            this.tbxInputChemin.ThemeName = "MetroLite";
            this.tbxInputChemin.UseSystemPasswordChar = false;
            this.tbxInputChemin.WatermarkText = "https://example.com";
            // 
            // lblInputChemin
            // 
            this.lblInputChemin.AutoSize = true;
            this.lblInputChemin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputChemin.ForeColor = System.Drawing.Color.Black;
            this.lblInputChemin.Location = new System.Drawing.Point(8, 126);
            this.lblInputChemin.Name = "lblInputChemin";
            this.lblInputChemin.Size = new System.Drawing.Size(66, 16);
            this.lblInputChemin.TabIndex = 17;
            this.lblInputChemin.Text = "Chemin :";
            this.lblInputChemin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // frmAskRaccourcis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(368, 271);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlAppTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAskRaccourcis";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAskRaccourcis";
            this.TopMost = true;
            this.pnlAppTopBar.ResumeLayout(false);
            this.pnlAppTopBar.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAppTopBar;
        private System.Windows.Forms.Label lblAppName;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel pnlTopBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MetroSet_UI.Controls.MetroSetTextBox tbxInputName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInputName;
        private System.Windows.Forms.Panel pnlContent;
        private MetroSet_UI.Controls.MetroSetTextBox tbxInputChemin;
        private System.Windows.Forms.Label lblInputChemin;
        private MetroSet_UI.Controls.MetroSetTextBox tbxInputDescription;
        private System.Windows.Forms.Label lblInputDescription;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnConfirm;
        private FontAwesome.Sharp.IconButton btnChooseFile;
    }
}

namespace myWay.myForms
{
    partial class frmAskTextInput
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxInput = new MetroSet_UI.Controls.MetroSetTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnCancel = new MetroSet_UI.Controls.MetroSetButton();
            this.btnConfirm = new MetroSet_UI.Controls.MetroSetButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblRequired = new System.Windows.Forms.Label();
            this.pnlAppTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlTopBar.SuspendLayout();
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
            this.pnlAppTopBar.TabIndex = 1;
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
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.Black;
            this.lblInput.Location = new System.Drawing.Point(8, 62);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(47, 16);
            this.lblInput.TabIndex = 11;
            this.lblInput.Text = "Nom :";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(48, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Nommer la section";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxInput
            // 
            this.tbxInput.AutoCompleteCustomSource = null;
            this.tbxInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxInput.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxInput.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbxInput.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbxInput.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbxInput.Image = null;
            this.tbxInput.IsDerivedStyle = false;
            this.tbxInput.Lines = null;
            this.tbxInput.Location = new System.Drawing.Point(71, 59);
            this.tbxInput.MaxLength = 32767;
            this.tbxInput.Multiline = false;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.ReadOnly = false;
            this.tbxInput.Size = new System.Drawing.Size(269, 26);
            this.tbxInput.Style = MetroSet_UI.Enums.Style.Light;
            this.tbxInput.StyleManager = null;
            this.tbxInput.TabIndex = 14;
            this.tbxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxInput.ThemeAuthor = "Narwin";
            this.tbxInput.ThemeName = "MetroLite";
            this.tbxInput.UseSystemPasswordChar = false;
            this.tbxInput.WatermarkText = "exemple";
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
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
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlTopBar.Controls.Add(this.btnCancel);
            this.pnlTopBar.Controls.Add(this.btnConfirm);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 98);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(364, 39);
            this.pnlTopBar.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.IsDerivedStyle = true;
            this.btnCancel.Location = new System.Drawing.Point(284, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.NormalTextColor = System.Drawing.Color.White;
            this.btnCancel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.PressTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.Style = MetroSet_UI.Enums.Style.Light;
            this.btnCancel.StyleManager = null;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.ThemeAuthor = "Narwin";
            this.btnCancel.ThemeName = "MetroLite";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirm.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnConfirm.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnConfirm.HoverTextColor = System.Drawing.Color.White;
            this.btnConfirm.IsDerivedStyle = true;
            this.btnConfirm.Location = new System.Drawing.Point(204, 7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.NormalTextColor = System.Drawing.Color.White;
            this.btnConfirm.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirm.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirm.PressTextColor = System.Drawing.Color.White;
            this.btnConfirm.Size = new System.Drawing.Size(75, 25);
            this.btnConfirm.Style = MetroSet_UI.Enums.Style.Light;
            this.btnConfirm.StyleManager = null;
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.ThemeAuthor = "Narwin";
            this.btnConfirm.ThemeName = "MetroLite";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlContent.Controls.Add(this.lblRequired);
            this.pnlContent.Controls.Add(this.pnlTopBar);
            this.pnlContent.Controls.Add(this.iconPictureBox1);
            this.pnlContent.Controls.Add(this.tbxInput);
            this.pnlContent.Controls.Add(this.lblTitle);
            this.pnlContent.Controls.Add(this.lblInput);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(2, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(364, 137);
            this.pnlContent.TabIndex = 11;
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(48, 59);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(17, 16);
            this.lblRequired.TabIndex = 23;
            this.lblRequired.Text = "*";
            // 
            // frmAskTextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 169);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlAppTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAskTextInput";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAskTextInput";
            this.pnlAppTopBar.ResumeLayout(false);
            this.pnlAppTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAppTopBar;
        private System.Windows.Forms.Label lblAppName;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblTitle;
        private MetroSet_UI.Controls.MetroSetTextBox tbxInput;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel pnlTopBar;
        private MetroSet_UI.Controls.MetroSetButton btnCancel;
        private MetroSet_UI.Controls.MetroSetButton btnConfirm;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblRequired;
    }
}
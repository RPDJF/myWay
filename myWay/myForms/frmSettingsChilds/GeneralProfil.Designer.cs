
namespace myWay.myForms.frmSettingsChilds
{
    partial class GeneralProfil
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
            this.grpFenêtre = new System.Windows.Forms.GroupBox();
            this.btnAddProfil = new FontAwesome.Sharp.IconButton();
            this.lblProfile = new System.Windows.Forms.Label();
            this.cbxProfil = new MetroSet_UI.Controls.MetroSetComboBox();
            this.grpFenêtre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFenêtre
            // 
            this.grpFenêtre.Controls.Add(this.btnAddProfil);
            this.grpFenêtre.Controls.Add(this.lblProfile);
            this.grpFenêtre.Controls.Add(this.cbxProfil);
            this.grpFenêtre.Location = new System.Drawing.Point(12, 12);
            this.grpFenêtre.Name = "grpFenêtre";
            this.grpFenêtre.Size = new System.Drawing.Size(378, 100);
            this.grpFenêtre.TabIndex = 3;
            this.grpFenêtre.TabStop = false;
            this.grpFenêtre.Text = "Profil";
            // 
            // btnAddProfil
            // 
            this.btnAddProfil.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProfil.FlatAppearance.BorderSize = 0;
            this.btnAddProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnAddProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAddProfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProfil.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddProfil.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddProfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProfil.IconSize = 20;
            this.btnAddProfil.Location = new System.Drawing.Point(267, 42);
            this.btnAddProfil.Name = "btnAddProfil";
            this.btnAddProfil.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAddProfil.Size = new System.Drawing.Size(26, 26);
            this.btnAddProfil.TabIndex = 20;
            this.btnAddProfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProfil.UseVisualStyleBackColor = false;
            this.btnAddProfil.Click += new System.EventHandler(this.btnAddProfil_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(6, 45);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(39, 16);
            this.lblProfile.TabIndex = 18;
            this.lblProfile.Text = "Profil";
            // 
            // cbxProfil
            // 
            this.cbxProfil.AllowDrop = true;
            this.cbxProfil.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxProfil.BackColor = System.Drawing.Color.Transparent;
            this.cbxProfil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbxProfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxProfil.CausesValidation = false;
            this.cbxProfil.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxProfil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxProfil.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxProfil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfil.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.cbxProfil.FormattingEnabled = true;
            this.cbxProfil.IsDerivedStyle = true;
            this.cbxProfil.ItemHeight = 20;
            this.cbxProfil.Location = new System.Drawing.Point(77, 42);
            this.cbxProfil.Name = "cbxProfil";
            this.cbxProfil.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxProfil.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxProfil.Size = new System.Drawing.Size(184, 26);
            this.cbxProfil.Style = MetroSet_UI.Enums.Style.Light;
            this.cbxProfil.StyleManager = null;
            this.cbxProfil.TabIndex = 17;
            this.cbxProfil.ThemeAuthor = "Narwin";
            this.cbxProfil.ThemeName = "MetroLite";
            this.cbxProfil.SelectedIndexChanged += new System.EventHandler(this.cbxProfil_SelectedIndexChanged);
            // 
            // GeneralProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(404, 222);
            this.Controls.Add(this.grpFenêtre);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeneralProfil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GeneralProfil_Load);
            this.grpFenêtre.ResumeLayout(false);
            this.grpFenêtre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFenêtre;
        private MetroSet_UI.Controls.MetroSetComboBox cbxProfil;
        private System.Windows.Forms.Label lblProfile;
        private FontAwesome.Sharp.IconButton btnAddProfil;
    }
}
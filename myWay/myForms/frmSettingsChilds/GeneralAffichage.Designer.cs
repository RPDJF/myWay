
namespace myWay.myForms.frmSettingsChilds
{
    partial class GeneralAffichage
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
            this.cbxToplevel = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.cbxClassicalForm = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.grpFenêtre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFenêtre
            // 
            this.grpFenêtre.Controls.Add(this.cbxClassicalForm);
            this.grpFenêtre.Controls.Add(this.cbxToplevel);
            this.grpFenêtre.Location = new System.Drawing.Point(12, 12);
            this.grpFenêtre.Name = "grpFenêtre";
            this.grpFenêtre.Size = new System.Drawing.Size(378, 100);
            this.grpFenêtre.TabIndex = 2;
            this.grpFenêtre.TabStop = false;
            this.grpFenêtre.Text = "Fenêtre";
            // 
            // cbxToplevel
            // 
            this.cbxToplevel.BackColor = System.Drawing.Color.Transparent;
            this.cbxToplevel.BackgroundColor = System.Drawing.Color.White;
            this.cbxToplevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxToplevel.Checked = false;
            this.cbxToplevel.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxToplevel.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.cbxToplevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxToplevel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.cbxToplevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxToplevel.IsDerivedStyle = true;
            this.cbxToplevel.Location = new System.Drawing.Point(15, 25);
            this.cbxToplevel.Name = "cbxToplevel";
            this.cbxToplevel.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.cbxToplevel.Size = new System.Drawing.Size(140, 16);
            this.cbxToplevel.Style = MetroSet_UI.Enums.Style.Light;
            this.cbxToplevel.StyleManager = null;
            this.cbxToplevel.TabIndex = 1;
            this.cbxToplevel.Text = "Toujours au-dessus";
            this.cbxToplevel.ThemeAuthor = "Narwin";
            this.cbxToplevel.ThemeName = "MetroLite";
            this.cbxToplevel.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.cbxToplevel_CheckedChanged);
            // 
            // cbxClassicalForm
            // 
            this.cbxClassicalForm.BackColor = System.Drawing.Color.Transparent;
            this.cbxClassicalForm.BackgroundColor = System.Drawing.Color.White;
            this.cbxClassicalForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxClassicalForm.Checked = false;
            this.cbxClassicalForm.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxClassicalForm.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.cbxClassicalForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxClassicalForm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.cbxClassicalForm.Enabled = false;
            this.cbxClassicalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxClassicalForm.IsDerivedStyle = true;
            this.cbxClassicalForm.Location = new System.Drawing.Point(15, 47);
            this.cbxClassicalForm.Name = "cbxClassicalForm";
            this.cbxClassicalForm.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.cbxClassicalForm.Size = new System.Drawing.Size(140, 16);
            this.cbxClassicalForm.Style = MetroSet_UI.Enums.Style.Light;
            this.cbxClassicalForm.StyleManager = null;
            this.cbxClassicalForm.TabIndex = 2;
            this.cbxClassicalForm.Text = "Fenêtre classique";
            this.cbxClassicalForm.ThemeAuthor = "Narwin";
            this.cbxClassicalForm.ThemeName = "MetroLite";
            this.cbxClassicalForm.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.cbxClassicalForm_CheckedChanged);
            // 
            // GeneralAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(404, 222);
            this.Controls.Add(this.grpFenêtre);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeneralAffichage";
            this.Text = "General";
            this.grpFenêtre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFenêtre;
        private MetroSet_UI.Controls.MetroSetCheckBox cbxToplevel;
        private MetroSet_UI.Controls.MetroSetCheckBox cbxClassicalForm;
    }
}
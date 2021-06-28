
namespace myWay.myForms.frmSettingsChilds
{
    partial class General
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
            this.mcbxTopmost = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.grpApparence = new System.Windows.Forms.GroupBox();
            this.grpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcbxTopmost
            // 
            this.mcbxTopmost.BackColor = System.Drawing.Color.Transparent;
            this.mcbxTopmost.BackgroundColor = System.Drawing.Color.White;
            this.mcbxTopmost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mcbxTopmost.Checked = false;
            this.mcbxTopmost.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mcbxTopmost.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.mcbxTopmost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcbxTopmost.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.mcbxTopmost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mcbxTopmost.IsDerivedStyle = true;
            this.mcbxTopmost.Location = new System.Drawing.Point(38, 176);
            this.mcbxTopmost.Name = "mcbxTopmost";
            this.mcbxTopmost.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.mcbxTopmost.Size = new System.Drawing.Size(153, 16);
            this.mcbxTopmost.Style = MetroSet_UI.Enums.Style.Light;
            this.mcbxTopmost.StyleManager = null;
            this.mcbxTopmost.TabIndex = 1;
            this.mcbxTopmost.Text = "Au-dessus";
            this.mcbxTopmost.ThemeAuthor = "Narwin";
            this.mcbxTopmost.ThemeName = "MetroLite";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.mcbxTopmost);
            this.grpGeneral.Controls.Add(this.grpApparence);
            this.grpGeneral.Location = new System.Drawing.Point(12, 12);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(400, 203);
            this.grpGeneral.TabIndex = 2;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Général";
            // 
            // grpApparence
            // 
            this.grpApparence.Location = new System.Drawing.Point(0, 35);
            this.grpApparence.Name = "grpApparence";
            this.grpApparence.Size = new System.Drawing.Size(400, 102);
            this.grpApparence.TabIndex = 3;
            this.grpApparence.TabStop = false;
            this.grpApparence.Text = "Apparence";
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(424, 227);
            this.Controls.Add(this.grpGeneral);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "General";
            this.Text = "General";
            this.grpGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetCheckBox mcbxTopmost;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.GroupBox grpApparence;
    }
}
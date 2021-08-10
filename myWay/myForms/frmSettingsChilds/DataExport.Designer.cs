
namespace myWay.myForms.frmSettingsChilds
{
    partial class DataExport
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
            this.grpMyWay2021 = new System.Windows.Forms.GroupBox();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.lblNew = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.grpMyWay2021.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMyWay2021
            // 
            this.grpMyWay2021.Controls.Add(this.btnExport);
            this.grpMyWay2021.Controls.Add(this.lblNew);
            this.grpMyWay2021.Location = new System.Drawing.Point(12, 12);
            this.grpMyWay2021.Name = "grpMyWay2021";
            this.grpMyWay2021.Size = new System.Drawing.Size(378, 100);
            this.grpMyWay2021.TabIndex = 29;
            this.grpMyWay2021.TabStop = false;
            this.grpMyWay2021.Text = "myWay 2021";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExport.IconColor = System.Drawing.Color.Black;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.Location = new System.Drawing.Point(228, 21);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 25);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "Exporter...";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblNew
            // 
            this.lblNew.Location = new System.Drawing.Point(15, 25);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(222, 16);
            this.lblNew.TabIndex = 24;
            this.lblNew.Text = "%actualVersion% et supérieur :";
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "xml";
            this.sfd.Filter = "Fichiers XML|*.xml";
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // DataExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(404, 222);
            this.Controls.Add(this.grpMyWay2021);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataExport";
            this.grpMyWay2021.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMyWay2021;
        private FontAwesome.Sharp.IconButton btnExport;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

namespace myWay.myForms.frmSettingsChilds
{
    partial class DataImport
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
            this.btnChooseFileActual = new FontAwesome.Sharp.IconButton();
            this.lblNew = new System.Windows.Forms.Label();
            this.grpOldMyWay = new System.Windows.Forms.GroupBox();
            this.btnChooseFile = new FontAwesome.Sharp.IconButton();
            this.lblOldNewSection = new System.Windows.Forms.Label();
            this.lblOldNew = new System.Windows.Forms.Label();
            this.cbxSections = new System.Windows.Forms.ComboBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.ofdNew = new System.Windows.Forms.OpenFileDialog();
            this.grpMyWay2021.SuspendLayout();
            this.grpOldMyWay.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMyWay2021
            // 
            this.grpMyWay2021.Controls.Add(this.btnChooseFileActual);
            this.grpMyWay2021.Controls.Add(this.lblNew);
            this.grpMyWay2021.Location = new System.Drawing.Point(12, 12);
            this.grpMyWay2021.Name = "grpMyWay2021";
            this.grpMyWay2021.Size = new System.Drawing.Size(378, 100);
            this.grpMyWay2021.TabIndex = 28;
            this.grpMyWay2021.TabStop = false;
            this.grpMyWay2021.Text = "myWay 2021";
            // 
            // btnChooseFileActual
            // 
            this.btnChooseFileActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnChooseFileActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFileActual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnChooseFileActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFileActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChooseFileActual.ForeColor = System.Drawing.Color.White;
            this.btnChooseFileActual.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChooseFileActual.IconColor = System.Drawing.Color.Black;
            this.btnChooseFileActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChooseFileActual.Location = new System.Drawing.Point(228, 21);
            this.btnChooseFileActual.Name = "btnChooseFileActual";
            this.btnChooseFileActual.Size = new System.Drawing.Size(139, 25);
            this.btnChooseFileActual.TabIndex = 23;
            this.btnChooseFileActual.Text = "Choisir un fichier ...";
            this.btnChooseFileActual.UseVisualStyleBackColor = false;
            this.btnChooseFileActual.Click += new System.EventHandler(this.btnChooseFileActual_Click);
            // 
            // lblNew
            // 
            this.lblNew.Location = new System.Drawing.Point(15, 25);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(207, 16);
            this.lblNew.TabIndex = 24;
            this.lblNew.Text = "%actualVersion% et antérieur :";
            // 
            // grpOldMyWay
            // 
            this.grpOldMyWay.Controls.Add(this.btnChooseFile);
            this.grpOldMyWay.Controls.Add(this.lblOldNewSection);
            this.grpOldMyWay.Controls.Add(this.lblOldNew);
            this.grpOldMyWay.Controls.Add(this.cbxSections);
            this.grpOldMyWay.Location = new System.Drawing.Point(12, 118);
            this.grpOldMyWay.Name = "grpOldMyWay";
            this.grpOldMyWay.Size = new System.Drawing.Size(378, 100);
            this.grpOldMyWay.TabIndex = 27;
            this.grpOldMyWay.TabStop = false;
            this.grpOldMyWay.Text = "Ancien myWay";
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
            this.btnChooseFile.Location = new System.Drawing.Point(228, 21);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(139, 25);
            this.btnChooseFile.TabIndex = 23;
            this.btnChooseFile.Text = "Choisir un fichier ...";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblOldNewSection
            // 
            this.lblOldNewSection.Location = new System.Drawing.Point(15, 55);
            this.lblOldNewSection.Name = "lblOldNewSection";
            this.lblOldNewSection.Size = new System.Drawing.Size(94, 16);
            this.lblOldNewSection.TabIndex = 26;
            this.lblOldNewSection.Text = "Vers section :";
            // 
            // lblOldNew
            // 
            this.lblOldNew.Location = new System.Drawing.Point(15, 25);
            this.lblOldNew.Name = "lblOldNew";
            this.lblOldNew.Size = new System.Drawing.Size(134, 16);
            this.lblOldNew.TabIndex = 24;
            this.lblOldNew.Text = "Depuis myWay 4.5 :";
            // 
            // cbxSections
            // 
            this.cbxSections.FormattingEnabled = true;
            this.cbxSections.Location = new System.Drawing.Point(228, 52);
            this.cbxSections.Name = "cbxSections";
            this.cbxSections.Size = new System.Drawing.Size(139, 24);
            this.cbxSections.TabIndex = 25;
            // 
            // ofd
            // 
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // ofdNew
            // 
            this.ofdNew.Filter = "Fichiers XML|*.xml";
            this.ofdNew.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdNew_FileOk);
            // 
            // DataImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(404, 222);
            this.Controls.Add(this.grpMyWay2021);
            this.Controls.Add(this.grpOldMyWay);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataImport";
            this.ShowInTaskbar = false;
            this.Text = "Data";
            this.grpMyWay2021.ResumeLayout(false);
            this.grpOldMyWay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnChooseFile;
        private System.Windows.Forms.Label lblOldNew;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ComboBox cbxSections;
        private System.Windows.Forms.GroupBox grpMyWay2021;
        private FontAwesome.Sharp.IconButton btnChooseFileActual;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.GroupBox grpOldMyWay;
        private System.Windows.Forms.Label lblOldNewSection;
        private System.Windows.Forms.OpenFileDialog ofdNew;
    }
}
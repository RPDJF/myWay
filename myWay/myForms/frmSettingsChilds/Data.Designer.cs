
namespace myWay.myForms.frmSettingsChilds
{
    partial class Data
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
            this.grpConverter = new System.Windows.Forms.GroupBox();
            this.btnChooseFile = new FontAwesome.Sharp.IconButton();
            this.lblOldNew = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cbxSections = new System.Windows.Forms.ComboBox();
            this.grpConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConverter
            // 
            this.grpConverter.Controls.Add(this.cbxSections);
            this.grpConverter.Controls.Add(this.lblOldNew);
            this.grpConverter.Controls.Add(this.btnChooseFile);
            this.grpConverter.Location = new System.Drawing.Point(12, 43);
            this.grpConverter.Name = "grpConverter";
            this.grpConverter.Size = new System.Drawing.Size(400, 138);
            this.grpConverter.TabIndex = 0;
            this.grpConverter.TabStop = false;
            this.grpConverter.Text = "Importation données";
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
            this.btnChooseFile.Location = new System.Drawing.Point(28, 76);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(139, 25);
            this.btnChooseFile.TabIndex = 23;
            this.btnChooseFile.Text = "Choisir un fichier ...";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblOldNew
            // 
            this.lblOldNew.AutoSize = true;
            this.lblOldNew.Location = new System.Drawing.Point(25, 32);
            this.lblOldNew.Name = "lblOldNew";
            this.lblOldNew.Size = new System.Drawing.Size(134, 16);
            this.lblOldNew.TabIndex = 24;
            this.lblOldNew.Text = "Depuis myWay 4.5+";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 19);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Données";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // cbxSections
            // 
            this.cbxSections.FormattingEnabled = true;
            this.cbxSections.Location = new System.Drawing.Point(28, 49);
            this.cbxSections.Name = "cbxSections";
            this.cbxSections.Size = new System.Drawing.Size(121, 24);
            this.cbxSections.TabIndex = 25;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(424, 227);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpConverter);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Data";
            this.ShowInTaskbar = false;
            this.Text = "Data";
            this.grpConverter.ResumeLayout(false);
            this.grpConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConverter;
        private FontAwesome.Sharp.IconButton btnChooseFile;
        private System.Windows.Forms.Label lblOldNew;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ComboBox cbxSections;
    }
}
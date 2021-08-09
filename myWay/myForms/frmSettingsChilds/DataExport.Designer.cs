
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMyWay2021.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMyWay2021
            // 
            this.grpMyWay2021.Controls.Add(this.iconButton1);
            this.grpMyWay2021.Controls.Add(this.label2);
            this.grpMyWay2021.Location = new System.Drawing.Point(12, 12);
            this.grpMyWay2021.Name = "grpMyWay2021";
            this.grpMyWay2021.Size = new System.Drawing.Size(378, 100);
            this.grpMyWay2021.TabIndex = 29;
            this.grpMyWay2021.TabStop = false;
            this.grpMyWay2021.Text = "myWay 2021";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(228, 21);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(139, 25);
            this.iconButton1.TabIndex = 23;
            this.iconButton1.Text = "Choisir un fichier ...";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "%actualVersion% et supérieur :";
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataExport";
            this.grpMyWay2021.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMyWay2021;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
    }
}

namespace myWay.myForms
{
    partial class frmAbout
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnConfirm = new FontAwesome.Sharp.IconButton();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lbxDetails = new System.Windows.Forms.Label();
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.tbxDetails = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAppTopBar = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAppTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlTopBar.Controls.Add(this.btnConfirm);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 306);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(460, 39);
            this.pnlTopBar.TabIndex = 16;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfirm.IconColor = System.Drawing.Color.Black;
            this.btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirm.Location = new System.Drawing.Point(377, 7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(80, 25);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Ok";
            this.btnConfirm.UseVisualStyleBackColor = false;
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
            this.btnClose.Location = new System.Drawing.Point(423, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(37, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlContent.Controls.Add(this.lblProductDesc);
            this.pnlContent.Controls.Add(this.lblProducts);
            this.pnlContent.Controls.Add(this.lbxDetails);
            this.pnlContent.Controls.Add(this.lbxProducts);
            this.pnlContent.Controls.Add(this.tbxDetails);
            this.pnlContent.Controls.Add(this.pictureBox1);
            this.pnlContent.Controls.Add(this.pnlTopBar);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.pnlContent.Location = new System.Drawing.Point(2, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(460, 345);
            this.pnlContent.TabIndex = 15;
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(67, 20);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(234, 48);
            this.lblProductDesc.TabIndex = 22;
            this.lblProductDesc.Text = "Produit : myWay\r\nVersion : 1.0.0\r\nAuthor : Rui Paulo De Jesus Ferreira";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(7, 81);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(193, 16);
            this.lblProducts.TabIndex = 21;
            this.lblProducts.Text = "Produits et licences incluses :";
            // 
            // lbxDetails
            // 
            this.lbxDetails.AutoSize = true;
            this.lbxDetails.Location = new System.Drawing.Point(7, 198);
            this.lbxDetails.Name = "lbxDetails";
            this.lbxDetails.Size = new System.Drawing.Size(60, 16);
            this.lbxDetails.TabIndex = 20;
            this.lbxDetails.Text = "Détails :";
            // 
            // lbxProducts
            // 
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 16;
            this.lbxProducts.Location = new System.Drawing.Point(10, 100);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(363, 84);
            this.lbxProducts.TabIndex = 19;
            this.lbxProducts.SelectedIndexChanged += new System.EventHandler(this.lbxProducts_SelectedIndexChanged);
            // 
            // tbxDetails
            // 
            this.tbxDetails.BackColor = System.Drawing.Color.GhostWhite;
            this.tbxDetails.Location = new System.Drawing.Point(10, 217);
            this.tbxDetails.Multiline = true;
            this.tbxDetails.Name = "tbxDetails";
            this.tbxDetails.ReadOnly = true;
            this.tbxDetails.Size = new System.Drawing.Size(363, 73);
            this.tbxDetails.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::myWay.Properties.Resources.myWay;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pnlAppTopBar
            // 
            this.pnlAppTopBar.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlAppTopBar.Controls.Add(this.lblAppName);
            this.pnlAppTopBar.Controls.Add(this.btnClose);
            this.pnlAppTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppTopBar.Location = new System.Drawing.Point(2, 2);
            this.pnlAppTopBar.Name = "pnlAppTopBar";
            this.pnlAppTopBar.Size = new System.Drawing.Size(460, 28);
            this.pnlAppTopBar.TabIndex = 14;
            this.pnlAppTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlAppTopBar_MouseMove);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnConfirm;
            this.ClientSize = new System.Drawing.Size(464, 377);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlAppTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAbout";
            this.TopMost = true;
            this.pnlTopBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAppTopBar.ResumeLayout(false);
            this.pnlAppTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAppName;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlAppTopBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnConfirm;
        private System.Windows.Forms.TextBox tbxDetails;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lbxDetails;
        private System.Windows.Forms.ListBox lbxProducts;
    }
}
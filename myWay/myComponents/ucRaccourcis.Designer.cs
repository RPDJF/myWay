
namespace myWay.myComponents
{
    partial class ucRaccourcis
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlToolbox = new System.Windows.Forms.Panel();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnBody = new FontAwesome.Sharp.IconButton();
            this.pnlToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbox
            // 
            this.pnlToolbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlToolbox.Controls.Add(this.btnEdit);
            this.pnlToolbox.Controls.Add(this.btnRemove);
            this.pnlToolbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlToolbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlToolbox.Location = new System.Drawing.Point(398, 0);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(90, 53);
            this.pnlToolbox.TabIndex = 12;
            this.pnlToolbox.MouseEnter += new System.EventHandler(this.ShowTools);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 26;
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(45, 53);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.HideTools);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnRemove.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 24;
            this.btnRemove.Location = new System.Drawing.Point(45, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(45, 53);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseLeave += new System.EventHandler(this.HideTools);
            // 
            // btnBody
            // 
            this.btnBody.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBody.FlatAppearance.BorderSize = 0;
            this.btnBody.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBody.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBody.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnBody.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBody.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBody.IconSize = 20;
            this.btnBody.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBody.Location = new System.Drawing.Point(0, 0);
            this.btnBody.Name = "btnBody";
            this.btnBody.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBody.Size = new System.Drawing.Size(488, 53);
            this.btnBody.TabIndex = 11;
            this.btnBody.Text = "Value";
            this.btnBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBody.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBody.UseVisualStyleBackColor = false;
            this.btnBody.Click += new System.EventHandler(this.btnBody_Click);
            this.btnBody.MouseEnter += new System.EventHandler(this.ShowTools);
            this.btnBody.MouseLeave += new System.EventHandler(this.HideTools);
            // 
            // ucRaccourcis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlToolbox);
            this.Controls.Add(this.btnBody);
            this.Name = "ucRaccourcis";
            this.Size = new System.Drawing.Size(488, 53);
            this.pnlToolbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbox;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnBody;
    }
}

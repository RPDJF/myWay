namespace myWay.myComponents
{
    partial class Sections
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
            this.pnlComponent = new System.Windows.Forms.Panel();
            this.btnBody = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.pnlComponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlComponent
            // 
            this.pnlComponent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlComponent.Controls.Add(this.btnBody);
            this.pnlComponent.Controls.Add(this.btnEdit);
            this.pnlComponent.Controls.Add(this.btnRemove);
            this.pnlComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComponent.Location = new System.Drawing.Point(0, 0);
            this.pnlComponent.Name = "pnlComponent";
            this.pnlComponent.Padding = new System.Windows.Forms.Padding(1);
            this.pnlComponent.Size = new System.Drawing.Size(256, 38);
            this.pnlComponent.TabIndex = 0;
            // 
            // btnBody
            // 
            this.btnBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBody.FlatAppearance.BorderSize = 0;
            this.btnBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBody.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnBody.IconColor = System.Drawing.Color.Black;
            this.btnBody.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBody.IconSize = 20;
            this.btnBody.Location = new System.Drawing.Point(1, 1);
            this.btnBody.Name = "btnBody";
            this.btnBody.Size = new System.Drawing.Size(184, 36);
            this.btnBody.TabIndex = 5;
            this.btnBody.Text = "Value";
            this.btnBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBody.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBody.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 30;
            this.btnEdit.Location = new System.Drawing.Point(185, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(35, 36);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnRemove.IconColor = System.Drawing.Color.Black;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 26;
            this.btnRemove.Location = new System.Drawing.Point(220, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(35, 36);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlComponent);
            this.Name = "Sections";
            this.Size = new System.Drawing.Size(256, 38);
            this.pnlComponent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlComponent;
        private FontAwesome.Sharp.IconButton btnBody;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnRemove;
    }
}


namespace myWay
{
    partial class frmMain
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlAppTopBar = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnReduce = new FontAwesome.Sharp.IconButton();
            this.btnSize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblCollection = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlSectionContent = new System.Windows.Forms.Panel();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.mtbxSectionSearch = new MetroSet_UI.Controls.MetroSetTextBox();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnAddSection = new FontAwesome.Sharp.IconButton();
            this.pnlAppTitle = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.pnlLeftBorder = new System.Windows.Forms.Panel();
            this.btnOpenSection = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnLogo = new FontAwesome.Sharp.IconButton();
            this.pnlRaccourcisContent = new System.Windows.Forms.Panel();
            this.pnlRaccourcisTop = new System.Windows.Forms.Panel();
            this.btnAddRaccourcis = new FontAwesome.Sharp.IconButton();
            this.pnlAppTopBar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlAppTitle.SuspendLayout();
            this.pnlLeftBorder.SuspendLayout();
            this.pnlRaccourcisTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAppTopBar
            // 
            this.pnlAppTopBar.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlAppTopBar.Controls.Add(this.lblAppName);
            this.pnlAppTopBar.Controls.Add(this.btnReduce);
            this.pnlAppTopBar.Controls.Add(this.btnSize);
            this.pnlAppTopBar.Controls.Add(this.btnClose);
            this.pnlAppTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppTopBar.Location = new System.Drawing.Point(42, 2);
            this.pnlAppTopBar.Name = "pnlAppTopBar";
            this.pnlAppTopBar.Size = new System.Drawing.Size(744, 34);
            this.pnlAppTopBar.TabIndex = 0;
            this.pnlAppTopBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlAppTopBar_MouseDoubleClick);
            this.pnlAppTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlAppTopBar_MouseMove);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(6, 2);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(80, 24);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "myWay";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAppName_MouseMove);
            // 
            // btnReduce
            // 
            this.btnReduce.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReduce.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReduce.FlatAppearance.BorderSize = 0;
            this.btnReduce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduce.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnReduce.IconColor = System.Drawing.Color.Snow;
            this.btnReduce.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReduce.IconSize = 20;
            this.btnReduce.Location = new System.Drawing.Point(633, 0);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnReduce.Size = new System.Drawing.Size(37, 34);
            this.btnReduce.TabIndex = 2;
            this.btnReduce.UseVisualStyleBackColor = false;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnSize
            // 
            this.btnSize.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSize.FlatAppearance.BorderSize = 0;
            this.btnSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.btnSize.IconColor = System.Drawing.Color.Snow;
            this.btnSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSize.IconSize = 20;
            this.btnSize.Location = new System.Drawing.Point(670, 0);
            this.btnSize.Name = "btnSize";
            this.btnSize.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSize.Size = new System.Drawing.Size(37, 34);
            this.btnSize.TabIndex = 1;
            this.btnSize.UseVisualStyleBackColor = false;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Snow;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(707, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(37, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlTopBar.Controls.Add(this.lblCollection);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(298, 36);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(488, 50);
            this.pnlTopBar.TabIndex = 5;
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollection.ForeColor = System.Drawing.Color.White;
            this.lblCollection.Location = new System.Drawing.Point(6, 13);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(0, 26);
            this.lblCollection.TabIndex = 4;
            this.lblCollection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCollection.TextChanged += new System.EventHandler(this.lblCollection_TextChanged);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlLeft.Controls.Add(this.pnlSectionContent);
            this.pnlLeft.Controls.Add(this.pnlSearchBar);
            this.pnlLeft.Controls.Add(this.pnlToolbar);
            this.pnlLeft.Controls.Add(this.pnlAppTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(42, 36);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(256, 412);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlSectionContent
            // 
            this.pnlSectionContent.AutoScroll = true;
            this.pnlSectionContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSectionContent.Location = new System.Drawing.Point(0, 116);
            this.pnlSectionContent.Name = "pnlSectionContent";
            this.pnlSectionContent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlSectionContent.Size = new System.Drawing.Size(256, 245);
            this.pnlSectionContent.TabIndex = 9;
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.Controls.Add(this.btnSearch);
            this.pnlSearchBar.Controls.Add(this.mtbxSectionSearch);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.Location = new System.Drawing.Point(0, 65);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.pnlSearchBar.Size = new System.Drawing.Size(256, 51);
            this.pnlSearchBar.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(215, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(31, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mtbxSectionSearch
            // 
            this.mtbxSectionSearch.AutoCompleteCustomSource = null;
            this.mtbxSectionSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbxSectionSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbxSectionSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mtbxSectionSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.mtbxSectionSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mtbxSectionSearch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.mtbxSectionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbxSectionSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxSectionSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.mtbxSectionSearch.Image = null;
            this.mtbxSectionSearch.IsDerivedStyle = true;
            this.mtbxSectionSearch.Lines = null;
            this.mtbxSectionSearch.Location = new System.Drawing.Point(10, 0);
            this.mtbxSectionSearch.Margin = new System.Windows.Forms.Padding(5);
            this.mtbxSectionSearch.MaxLength = 32767;
            this.mtbxSectionSearch.Multiline = false;
            this.mtbxSectionSearch.Name = "mtbxSectionSearch";
            this.mtbxSectionSearch.ReadOnly = false;
            this.mtbxSectionSearch.Size = new System.Drawing.Size(236, 31);
            this.mtbxSectionSearch.Style = MetroSet_UI.Enums.Style.Light;
            this.mtbxSectionSearch.StyleManager = null;
            this.mtbxSectionSearch.TabIndex = 5;
            this.mtbxSectionSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxSectionSearch.ThemeAuthor = "Narwin";
            this.mtbxSectionSearch.ThemeName = "MetroLite";
            this.mtbxSectionSearch.UseSystemPasswordChar = false;
            this.mtbxSectionSearch.WatermarkText = "Rechercher";
            this.mtbxSectionSearch.TextChanged += new System.EventHandler(this.mtbxSectionSearch_TextChanged);
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlToolbar.Controls.Add(this.btnAddSection);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 361);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(256, 51);
            this.pnlToolbar.TabIndex = 8;
            // 
            // btnAddSection
            // 
            this.btnAddSection.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddSection.FlatAppearance.BorderSize = 0;
            this.btnAddSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAddSection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSection.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddSection.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSection.IconSize = 20;
            this.btnAddSection.Location = new System.Drawing.Point(0, 11);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAddSection.Size = new System.Drawing.Size(256, 40);
            this.btnAddSection.TabIndex = 0;
            this.btnAddSection.Text = "Section";
            this.btnAddSection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSection.UseVisualStyleBackColor = false;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // pnlAppTitle
            // 
            this.pnlAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlAppTitle.Controls.Add(this.lblSection);
            this.pnlAppTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlAppTitle.Name = "pnlAppTitle";
            this.pnlAppTitle.Size = new System.Drawing.Size(256, 65);
            this.pnlAppTitle.TabIndex = 0;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.White;
            this.lblSection.Location = new System.Drawing.Point(56, 16);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(128, 34);
            this.lblSection.TabIndex = 3;
            this.lblSection.Text = "Sections";
            this.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeftBorder
            // 
            this.pnlLeftBorder.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlLeftBorder.Controls.Add(this.btnOpenSection);
            this.pnlLeftBorder.Controls.Add(this.btnSettings);
            this.pnlLeftBorder.Controls.Add(this.btnLogo);
            this.pnlLeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBorder.Location = new System.Drawing.Point(2, 2);
            this.pnlLeftBorder.Name = "pnlLeftBorder";
            this.pnlLeftBorder.Size = new System.Drawing.Size(40, 446);
            this.pnlLeftBorder.TabIndex = 12;
            // 
            // btnOpenSection
            // 
            this.btnOpenSection.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOpenSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenSection.FlatAppearance.BorderSize = 0;
            this.btnOpenSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSection.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnOpenSection.IconColor = System.Drawing.Color.Snow;
            this.btnOpenSection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenSection.IconSize = 25;
            this.btnOpenSection.Location = new System.Drawing.Point(0, 40);
            this.btnOpenSection.Name = "btnOpenSection";
            this.btnOpenSection.Size = new System.Drawing.Size(40, 366);
            this.btnOpenSection.TabIndex = 2;
            this.btnOpenSection.UseVisualStyleBackColor = false;
            this.btnOpenSection.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 30;
            this.btnSettings.Location = new System.Drawing.Point(0, 406);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLogo.BackgroundImage = global::myWay.Properties.Resources.myWay;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogo.IconColor = System.Drawing.Color.White;
            this.btnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogo.IconSize = 30;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLogo.Size = new System.Drawing.Size(40, 40);
            this.btnLogo.TabIndex = 4;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // pnlRaccourcisContent
            // 
            this.pnlRaccourcisContent.AutoScroll = true;
            this.pnlRaccourcisContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlRaccourcisContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRaccourcisContent.Location = new System.Drawing.Point(298, 126);
            this.pnlRaccourcisContent.Name = "pnlRaccourcisContent";
            this.pnlRaccourcisContent.Size = new System.Drawing.Size(488, 322);
            this.pnlRaccourcisContent.TabIndex = 13;
            // 
            // pnlRaccourcisTop
            // 
            this.pnlRaccourcisTop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlRaccourcisTop.Controls.Add(this.btnAddRaccourcis);
            this.pnlRaccourcisTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRaccourcisTop.Location = new System.Drawing.Point(298, 86);
            this.pnlRaccourcisTop.Name = "pnlRaccourcisTop";
            this.pnlRaccourcisTop.Size = new System.Drawing.Size(488, 40);
            this.pnlRaccourcisTop.TabIndex = 16;
            // 
            // btnAddRaccourcis
            // 
            this.btnAddRaccourcis.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddRaccourcis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRaccourcis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRaccourcis.FlatAppearance.BorderSize = 0;
            this.btnAddRaccourcis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnAddRaccourcis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRaccourcis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRaccourcis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddRaccourcis.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddRaccourcis.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddRaccourcis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddRaccourcis.IconSize = 20;
            this.btnAddRaccourcis.Location = new System.Drawing.Point(0, 0);
            this.btnAddRaccourcis.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btnAddRaccourcis.Name = "btnAddRaccourcis";
            this.btnAddRaccourcis.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAddRaccourcis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddRaccourcis.Size = new System.Drawing.Size(488, 40);
            this.btnAddRaccourcis.TabIndex = 16;
            this.btnAddRaccourcis.Text = "Raccourci";
            this.btnAddRaccourcis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRaccourcis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRaccourcis.UseVisualStyleBackColor = false;
            this.btnAddRaccourcis.Click += new System.EventHandler(this.btnAddRaccourcis_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.pnlRaccourcisContent);
            this.Controls.Add(this.pnlRaccourcisTop);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlAppTopBar);
            this.Controls.Add(this.pnlLeftBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myWay";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlAppTopBar.ResumeLayout(false);
            this.pnlAppTopBar.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlAppTitle.ResumeLayout(false);
            this.pnlAppTitle.PerformLayout();
            this.pnlLeftBorder.ResumeLayout(false);
            this.pnlRaccourcisTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAppTopBar;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlLeft;
        private FontAwesome.Sharp.IconButton btnReduce;
        private FontAwesome.Sharp.IconButton btnSize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel pnlAppTitle;
        private System.Windows.Forms.Panel pnlLeftBorder;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlSearchBar;
        private FontAwesome.Sharp.IconButton btnSearch;
        private MetroSet_UI.Controls.MetroSetTextBox mtbxSectionSearch;
        private FontAwesome.Sharp.IconButton btnAddSection;
        public System.Windows.Forms.Panel pnlSectionContent;
        public System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Panel pnlRaccourcisContent;
        private System.Windows.Forms.Panel pnlRaccourcisTop;
        private FontAwesome.Sharp.IconButton btnAddRaccourcis;
        private FontAwesome.Sharp.IconButton btnOpenSection;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnLogo;
    }
}


namespace P_GestProj2_Interface
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.lblPrixMax = new System.Windows.Forms.Label();
            this.tbrPrixMax = new System.Windows.Forms.TrackBar();
            this.lblPrixMin = new System.Windows.Forms.Label();
            this.tbrPrixMin = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMarque = new System.Windows.Forms.ComboBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.cbCPU = new System.Windows.Forms.ComboBox();
            this.cbTailleEcran = new System.Windows.Forms.ComboBox();
            this.cbRAM = new System.Windows.Forms.ComboBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.cbOS = new System.Windows.Forms.ComboBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.dgvResultatSmartphones = new System.Windows.Forms.DataGridView();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnContact = new System.Windows.Forms.Button();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.btnStopContact = new System.Windows.Forms.Button();
            this.lblRicardo = new System.Windows.Forms.Label();
            this.lblLoic = new System.Windows.Forms.Label();
            this.lblGregory = new System.Windows.Forms.Label();
            this.lblPierric = new System.Windows.Forms.Label();
            this.llblRicardo = new System.Windows.Forms.LinkLabel();
            this.llblLoic = new System.Windows.Forms.LinkLabel();
            this.llblGregory = new System.Windows.Forms.LinkLabel();
            this.llblPierric = new System.Windows.Forms.LinkLabel();
            this.grpFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPrixMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPrixMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultatSmartphones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.pnlContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFiltres
            // 
            this.grpFiltres.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltres.Controls.Add(this.lblPrixMax);
            this.grpFiltres.Controls.Add(this.tbrPrixMax);
            this.grpFiltres.Controls.Add(this.lblPrixMin);
            this.grpFiltres.Controls.Add(this.tbrPrixMin);
            this.grpFiltres.Controls.Add(this.label2);
            this.grpFiltres.Controls.Add(this.cbMarque);
            this.grpFiltres.Controls.Add(this.lblRAM);
            this.grpFiltres.Controls.Add(this.cbCPU);
            this.grpFiltres.Controls.Add(this.cbTailleEcran);
            this.grpFiltres.Controls.Add(this.cbRAM);
            this.grpFiltres.Controls.Add(this.lblAnnee);
            this.grpFiltres.Controls.Add(this.lblMarque);
            this.grpFiltres.Controls.Add(this.cbOS);
            this.grpFiltres.Controls.Add(this.lblCPU);
            this.grpFiltres.Controls.Add(this.cbDate);
            this.grpFiltres.Controls.Add(this.lblOS);
            this.grpFiltres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltres.Location = new System.Drawing.Point(60, 108);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Size = new System.Drawing.Size(920, 151);
            this.grpFiltres.TabIndex = 0;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "Filtres";
            // 
            // lblPrixMax
            // 
            this.lblPrixMax.AutoSize = true;
            this.lblPrixMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixMax.Location = new System.Drawing.Point(669, 84);
            this.lblPrixMax.Name = "lblPrixMax";
            this.lblPrixMax.Size = new System.Drawing.Size(93, 15);
            this.lblPrixMax.TabIndex = 18;
            this.lblPrixMax.Text = "Prix maximum :";
            // 
            // tbrPrixMax
            // 
            this.tbrPrixMax.LargeChange = 50;
            this.tbrPrixMax.Location = new System.Drawing.Point(672, 100);
            this.tbrPrixMax.Name = "tbrPrixMax";
            this.tbrPrixMax.Size = new System.Drawing.Size(227, 45);
            this.tbrPrixMax.SmallChange = 10;
            this.tbrPrixMax.TabIndex = 17;
            this.tbrPrixMax.ValueChanged += new System.EventHandler(this.UpdateTrackBars);
            // 
            // lblPrixMin
            // 
            this.lblPrixMin.AutoSize = true;
            this.lblPrixMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixMin.Location = new System.Drawing.Point(669, 25);
            this.lblPrixMin.Name = "lblPrixMin";
            this.lblPrixMin.Size = new System.Drawing.Size(90, 15);
            this.lblPrixMin.TabIndex = 16;
            this.lblPrixMin.Text = "Prix minimum :";
            // 
            // tbrPrixMin
            // 
            this.tbrPrixMin.LargeChange = 50;
            this.tbrPrixMin.Location = new System.Drawing.Point(672, 41);
            this.tbrPrixMin.Name = "tbrPrixMin";
            this.tbrPrixMin.Size = new System.Drawing.Size(227, 45);
            this.tbrPrixMin.SmallChange = 10;
            this.tbrPrixMin.TabIndex = 15;
            this.tbrPrixMin.ValueChanged += new System.EventHandler(this.UpdateTrackBars);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Taille écran :";
            // 
            // cbMarque
            // 
            this.cbMarque.AutoCompleteCustomSource.AddRange(new string[] {
            "Tous",
            "Android",
            "IOS",
            "Windows Phone"});
            this.cbMarque.BackColor = System.Drawing.SystemColors.Window;
            this.cbMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarque.FormattingEnabled = true;
            this.cbMarque.Location = new System.Drawing.Point(239, 41);
            this.cbMarque.Name = "cbMarque";
            this.cbMarque.Size = new System.Drawing.Size(195, 23);
            this.cbMarque.TabIndex = 5;
            this.cbMarque.SelectedIndexChanged += new System.EventHandler(this.ChangeFilters);
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(16, 86);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(40, 15);
            this.lblRAM.TabIndex = 8;
            this.lblRAM.Text = "RAM :";
            // 
            // cbCPU
            // 
            this.cbCPU.AutoCompleteCustomSource.AddRange(new string[] {
            "Tous",
            "Android",
            "IOS",
            "Windows Phone"});
            this.cbCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPU.FormattingEnabled = true;
            this.cbCPU.Location = new System.Drawing.Point(239, 102);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(195, 23);
            this.cbCPU.TabIndex = 11;
            this.cbCPU.SelectedIndexChanged += new System.EventHandler(this.ChangeFilters);
            // 
            // cbTailleEcran
            // 
            this.cbTailleEcran.AutoCompleteCustomSource.AddRange(new string[] {
            "Tous",
            "Android",
            "IOS",
            "Windows Phone"});
            this.cbTailleEcran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTailleEcran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTailleEcran.FormattingEnabled = true;
            this.cbTailleEcran.Location = new System.Drawing.Point(459, 41);
            this.cbTailleEcran.Name = "cbTailleEcran";
            this.cbTailleEcran.Size = new System.Drawing.Size(195, 23);
            this.cbTailleEcran.TabIndex = 7;
            this.cbTailleEcran.SelectedIndexChanged += new System.EventHandler(this.ChangeFilters);
            // 
            // cbRAM
            // 
            this.cbRAM.AutoCompleteCustomSource.AddRange(new string[] {
            "Tous",
            "Android",
            "IOS",
            "Windows Phone"});
            this.cbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAM.FormattingEnabled = true;
            this.cbRAM.Location = new System.Drawing.Point(19, 102);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(195, 23);
            this.cbRAM.TabIndex = 9;
            this.cbRAM.SelectedIndexChanged += new System.EventHandler(this.ChangeFilters);
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.Location = new System.Drawing.Point(456, 86);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(98, 15);
            this.lblAnnee.TabIndex = 12;
            this.lblAnnee.Text = "Année de sortie :";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarque.Location = new System.Drawing.Point(236, 25);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(56, 15);
            this.lblMarque.TabIndex = 4;
            this.lblMarque.Text = "Marque: ";
            // 
            // cbOS
            // 
            this.cbOS.AutoCompleteCustomSource.AddRange(new string[] {
            "Tous",
            "Android",
            "IOS",
            "Windows Phone"});
            this.cbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Location = new System.Drawing.Point(19, 41);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(195, 23);
            this.cbOS.TabIndex = 3;
            this.cbOS.SelectedIndexChanged += new System.EventHandler(this.ChangeFilters);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(236, 86);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(38, 15);
            this.lblCPU.TabIndex = 10;
            this.lblCPU.Text = "CPU :";
            // 
            // cbDate
            // 
            this.cbDate.AutoCompleteCustomSource.AddRange(new string[] {
            "Tous",
            "Android",
            "IOS",
            "Windows Phone"});
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(459, 102);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(195, 23);
            this.cbDate.TabIndex = 13;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.ChangeFilters);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(16, 25);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(30, 15);
            this.lblOS.TabIndex = 0;
            this.lblOS.Text = "OS :";
            // 
            // dgvResultatSmartphones
            // 
            this.dgvResultatSmartphones.AllowUserToAddRows = false;
            this.dgvResultatSmartphones.AllowUserToDeleteRows = false;
            this.dgvResultatSmartphones.AllowUserToResizeRows = false;
            this.dgvResultatSmartphones.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultatSmartphones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResultatSmartphones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResultatSmartphones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultatSmartphones.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultatSmartphones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultatSmartphones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvResultatSmartphones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvResultatSmartphones.Location = new System.Drawing.Point(60, 276);
            this.dgvResultatSmartphones.MultiSelect = false;
            this.dgvResultatSmartphones.Name = "dgvResultatSmartphones";
            this.dgvResultatSmartphones.ReadOnly = true;
            this.dgvResultatSmartphones.RowHeadersVisible = false;
            this.dgvResultatSmartphones.RowTemplate.ReadOnly = true;
            this.dgvResultatSmartphones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultatSmartphones.Size = new System.Drawing.Size(920, 369);
            this.dgvResultatSmartphones.TabIndex = 3;
            this.dgvResultatSmartphones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultatSmartphones_CellClick);
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbTitle.Image")));
            this.pbTitle.Location = new System.Drawing.Point(253, 2);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(553, 100);
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitle.TabIndex = 4;
            this.pbTitle.TabStop = false;
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(13, 13);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(75, 23);
            this.btnContact.TabIndex = 5;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // pnlContact
            // 
            this.pnlContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContact.Controls.Add(this.btnStopContact);
            this.pnlContact.Controls.Add(this.lblRicardo);
            this.pnlContact.Controls.Add(this.lblLoic);
            this.pnlContact.Controls.Add(this.lblGregory);
            this.pnlContact.Controls.Add(this.lblPierric);
            this.pnlContact.Controls.Add(this.llblRicardo);
            this.pnlContact.Controls.Add(this.llblLoic);
            this.pnlContact.Controls.Add(this.llblGregory);
            this.pnlContact.Controls.Add(this.llblPierric);
            this.pnlContact.Enabled = false;
            this.pnlContact.Location = new System.Drawing.Point(2, 2);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(245, 77);
            this.pnlContact.TabIndex = 6;
            this.pnlContact.Visible = false;
            // 
            // btnStopContact
            // 
            this.btnStopContact.BackColor = System.Drawing.Color.Transparent;
            this.btnStopContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopContact.BackgroundImage")));
            this.btnStopContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopContact.ForeColor = System.Drawing.Color.Transparent;
            this.btnStopContact.Location = new System.Drawing.Point(219, 3);
            this.btnStopContact.Name = "btnStopContact";
            this.btnStopContact.Size = new System.Drawing.Size(19, 17);
            this.btnStopContact.TabIndex = 7;
            this.btnStopContact.UseVisualStyleBackColor = false;
            this.btnStopContact.Click += new System.EventHandler(this.BtnStopContact_Click);
            // 
            // lblRicardo
            // 
            this.lblRicardo.AutoSize = true;
            this.lblRicardo.Location = new System.Drawing.Point(3, 23);
            this.lblRicardo.Name = "lblRicardo";
            this.lblRicardo.Size = new System.Drawing.Size(92, 13);
            this.lblRicardo.TabIndex = 7;
            this.lblRicardo.Text = "Ricardo Cardoso :";
            // 
            // lblLoic
            // 
            this.lblLoic.AutoSize = true;
            this.lblLoic.Location = new System.Drawing.Point(3, 36);
            this.lblLoic.Name = "lblLoic";
            this.lblLoic.Size = new System.Drawing.Size(71, 13);
            this.lblLoic.TabIndex = 6;
            this.lblLoic.Text = "Loïc Rosset :";
            // 
            // lblGregory
            // 
            this.lblGregory.AutoSize = true;
            this.lblGregory.Location = new System.Drawing.Point(3, 49);
            this.lblGregory.Name = "lblGregory";
            this.lblGregory.Size = new System.Drawing.Size(83, 13);
            this.lblGregory.TabIndex = 5;
            this.lblGregory.Text = "Grégory Briand :";
            // 
            // lblPierric
            // 
            this.lblPierric.AutoSize = true;
            this.lblPierric.Location = new System.Drawing.Point(3, 10);
            this.lblPierric.Name = "lblPierric";
            this.lblPierric.Size = new System.Drawing.Size(71, 13);
            this.lblPierric.TabIndex = 4;
            this.lblPierric.Text = "Pierric Ripoll :";
            // 
            // llblRicardo
            // 
            this.llblRicardo.AutoSize = true;
            this.llblRicardo.Location = new System.Drawing.Point(101, 23);
            this.llblRicardo.Name = "llblRicardo";
            this.llblRicardo.Size = new System.Drawing.Size(56, 13);
            this.llblRicardo.TabIndex = 3;
            this.llblRicardo.TabStop = true;
            this.llblRicardo.Text = "llblRicardo";
            this.llblRicardo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ricardo_Click);
            // 
            // llblLoic
            // 
            this.llblLoic.AutoSize = true;
            this.llblLoic.Location = new System.Drawing.Point(101, 36);
            this.llblLoic.Name = "llblLoic";
            this.llblLoic.Size = new System.Drawing.Size(39, 13);
            this.llblLoic.TabIndex = 2;
            this.llblLoic.TabStop = true;
            this.llblLoic.Text = "llblLoic";
            this.llblLoic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Loic_Click);
            // 
            // llblGregory
            // 
            this.llblGregory.AutoSize = true;
            this.llblGregory.Location = new System.Drawing.Point(101, 49);
            this.llblGregory.Name = "llblGregory";
            this.llblGregory.Size = new System.Drawing.Size(56, 13);
            this.llblGregory.TabIndex = 1;
            this.llblGregory.TabStop = true;
            this.llblGregory.Text = "llblGregory";
            this.llblGregory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Gregory_Click);
            // 
            // llblPierric
            // 
            this.llblPierric.AutoSize = true;
            this.llblPierric.Location = new System.Drawing.Point(101, 10);
            this.llblPierric.Name = "llblPierric";
            this.llblPierric.Size = new System.Drawing.Size(48, 13);
            this.llblPierric.TabIndex = 0;
            this.llblPierric.TabStop = true;
            this.llblPierric.Text = "llblPierric";
            this.llblPierric.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Pierric_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(987, 158);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(13, 13);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "0";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(987, 210);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(13, 13);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 676);
            this.Controls.Add(this.pnlContact);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.pbTitle);
            this.Controls.Add(this.dgvResultatSmartphones);
            this.Controls.Add(this.grpFiltres);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SmartSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPrixMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPrixMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultatSmartphones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.ComboBox cbOS;
        private System.Windows.Forms.ComboBox cbRAM;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.ComboBox cbTailleEcran;
        private System.Windows.Forms.ComboBox cbMarque;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.ComboBox cbCPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.DataGridView dgvResultatSmartphones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.Label lblPrixMax;
        private System.Windows.Forms.TrackBar tbrPrixMax;
        private System.Windows.Forms.Label lblPrixMin;
        private System.Windows.Forms.TrackBar tbrPrixMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.Button btnStopContact;
        private System.Windows.Forms.Label lblRicardo;
        private System.Windows.Forms.Label lblLoic;
        private System.Windows.Forms.Label lblGregory;
        private System.Windows.Forms.Label lblPierric;
        private System.Windows.Forms.LinkLabel llblRicardo;
        private System.Windows.Forms.LinkLabel llblLoic;
        private System.Windows.Forms.LinkLabel llblGregory;
        private System.Windows.Forms.LinkLabel llblPierric;
    }
}


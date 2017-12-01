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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpFiltres = new System.Windows.Forms.GroupBox();
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
            this.tbrPrixMin = new System.Windows.Forms.TrackBar();
            this.lblPrixMin = new System.Windows.Forms.Label();
            this.lblPrixMax = new System.Windows.Forms.Label();
            this.tbrPrixMax = new System.Windows.Forms.TrackBar();
            this.grpFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultatSmartphones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPrixMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPrixMax)).BeginInit();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultatSmartphones.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvResultatSmartphones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultatSmartphones_CellClick);
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbTitle.Image")));
            this.pbTitle.Location = new System.Drawing.Point(253, 2);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(553, 100);
            this.pbTitle.TabIndex = 4;
            this.pbTitle.TabStop = false;
            // 
            // tbrPrixMin
            // 
            this.tbrPrixMin.Location = new System.Drawing.Point(672, 41);
            this.tbrPrixMin.Name = "tbrPrixMin";
            this.tbrPrixMin.Size = new System.Drawing.Size(227, 45);
            this.tbrPrixMin.TabIndex = 15;
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
            this.tbrPrixMax.Location = new System.Drawing.Point(672, 100);
            this.tbrPrixMax.Name = "tbrPrixMax";
            this.tbrPrixMax.Size = new System.Drawing.Size(227, 45);
            this.tbrPrixMax.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 676);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultatSmartphones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPrixMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPrixMax)).EndInit();
            this.ResumeLayout(false);

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
    }
}


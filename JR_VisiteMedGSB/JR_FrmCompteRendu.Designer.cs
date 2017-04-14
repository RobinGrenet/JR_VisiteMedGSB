namespace JR_VisiteMedGSB
{
    partial class JR_FrmCompteRendu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JR_FrmCompteRendu));
            this.tctrlCompteRendu = new System.Windows.Forms.TabControl();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.BtnToutAfficher = new System.Windows.Forms.Button();
            this.MCalCompteRendu = new System.Windows.Forms.MonthCalendar();
            this.GbxListeCompteRendu = new System.Windows.Forms.GroupBox();
            this.DtgListeCompteRendu = new System.Windows.Forms.DataGridView();
            this.tabMiseAJour = new System.Windows.Forms.TabPage();
            this.ProgressControlVisiteur = new CircularProgressControl.CircularProgressControl();
            this.LblChargement = new System.Windows.Forms.Label();
            this.LblErreur = new System.Windows.Forms.Label();
            this.tctrlCompteRendu.SuspendLayout();
            this.tabConsultation.SuspendLayout();
            this.GbxListeCompteRendu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeCompteRendu)).BeginInit();
            this.SuspendLayout();
            // 
            // tctrlCompteRendu
            // 
            this.tctrlCompteRendu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctrlCompteRendu.Controls.Add(this.tabConsultation);
            this.tctrlCompteRendu.Controls.Add(this.tabMiseAJour);
            this.tctrlCompteRendu.Location = new System.Drawing.Point(12, 12);
            this.tctrlCompteRendu.Name = "tctrlCompteRendu";
            this.tctrlCompteRendu.SelectedIndex = 0;
            this.tctrlCompteRendu.Size = new System.Drawing.Size(969, 620);
            this.tctrlCompteRendu.TabIndex = 0;
            // 
            // tabConsultation
            // 
            this.tabConsultation.Controls.Add(this.LblErreur);
            this.tabConsultation.Controls.Add(this.LblChargement);
            this.tabConsultation.Controls.Add(this.ProgressControlVisiteur);
            this.tabConsultation.Controls.Add(this.BtnToutAfficher);
            this.tabConsultation.Controls.Add(this.MCalCompteRendu);
            this.tabConsultation.Controls.Add(this.GbxListeCompteRendu);
            this.tabConsultation.Location = new System.Drawing.Point(4, 22);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(961, 594);
            this.tabConsultation.TabIndex = 0;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            // 
            // BtnToutAfficher
            // 
            this.BtnToutAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnToutAfficher.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnToutAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToutAfficher.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToutAfficher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnToutAfficher.Location = new System.Drawing.Point(722, 520);
            this.BtnToutAfficher.Name = "BtnToutAfficher";
            this.BtnToutAfficher.Size = new System.Drawing.Size(227, 59);
            this.BtnToutAfficher.TabIndex = 2;
            this.BtnToutAfficher.Text = "Tout afficher";
            this.BtnToutAfficher.UseVisualStyleBackColor = false;
            this.BtnToutAfficher.Click += new System.EventHandler(this.BtnRafraichir_Click);
            // 
            // MCalCompteRendu
            // 
            this.MCalCompteRendu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MCalCompteRendu.Location = new System.Drawing.Point(722, 12);
            this.MCalCompteRendu.MaxSelectionCount = 31;
            this.MCalCompteRendu.Name = "MCalCompteRendu";
            this.MCalCompteRendu.TabIndex = 0;
            this.MCalCompteRendu.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MCalCompteRendu_DateChanged);
            // 
            // GbxListeCompteRendu
            // 
            this.GbxListeCompteRendu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxListeCompteRendu.Controls.Add(this.DtgListeCompteRendu);
            this.GbxListeCompteRendu.Location = new System.Drawing.Point(6, 6);
            this.GbxListeCompteRendu.Name = "GbxListeCompteRendu";
            this.GbxListeCompteRendu.Size = new System.Drawing.Size(704, 579);
            this.GbxListeCompteRendu.TabIndex = 1;
            this.GbxListeCompteRendu.TabStop = false;
            this.GbxListeCompteRendu.Text = "Nombre de rapports : ";
            // 
            // DtgListeCompteRendu
            // 
            this.DtgListeCompteRendu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgListeCompteRendu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListeCompteRendu.Location = new System.Drawing.Point(6, 19);
            this.DtgListeCompteRendu.Name = "DtgListeCompteRendu";
            this.DtgListeCompteRendu.Size = new System.Drawing.Size(692, 554);
            this.DtgListeCompteRendu.TabIndex = 1;
            this.DtgListeCompteRendu.DataSourceChanged += new System.EventHandler(this.DtgListeCompteRendu_DataSourceChanged);
            // 
            // tabMiseAJour
            // 
            this.tabMiseAJour.Location = new System.Drawing.Point(4, 22);
            this.tabMiseAJour.Name = "tabMiseAJour";
            this.tabMiseAJour.Padding = new System.Windows.Forms.Padding(3);
            this.tabMiseAJour.Size = new System.Drawing.Size(961, 594);
            this.tabMiseAJour.TabIndex = 1;
            this.tabMiseAJour.Text = "Mise à jour";
            this.tabMiseAJour.UseVisualStyleBackColor = true;
            // 
            // ProgressControlVisiteur
            // 
            this.ProgressControlVisiteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressControlVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.ProgressControlVisiteur.Interval = 60;
            this.ProgressControlVisiteur.Location = new System.Drawing.Point(722, 186);
            this.ProgressControlVisiteur.MinimumSize = new System.Drawing.Size(28, 28);
            this.ProgressControlVisiteur.Name = "ProgressControlVisiteur";
            this.ProgressControlVisiteur.Rotation = CircularProgressControl.CircularProgressControl.Direction.CLOCKWISE;
            this.ProgressControlVisiteur.Size = new System.Drawing.Size(32, 32);
            this.ProgressControlVisiteur.StartAngle = 270F;
            this.ProgressControlVisiteur.TabIndex = 4;
            this.ProgressControlVisiteur.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ProgressControlVisiteur.Visible = false;
            // 
            // LblChargement
            // 
            this.LblChargement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblChargement.AutoSize = true;
            this.LblChargement.Location = new System.Drawing.Point(755, 196);
            this.LblChargement.Name = "LblChargement";
            this.LblChargement.Size = new System.Drawing.Size(73, 13);
            this.LblChargement.TabIndex = 5;
            this.LblChargement.Text = "Chargement...";
            this.LblChargement.Visible = false;
            // 
            // LblErreur
            // 
            this.LblErreur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblErreur.ForeColor = System.Drawing.Color.Red;
            this.LblErreur.Location = new System.Drawing.Point(722, 221);
            this.LblErreur.Name = "LblErreur";
            this.LblErreur.Size = new System.Drawing.Size(227, 296);
            this.LblErreur.TabIndex = 6;
            this.LblErreur.Text = "Erreur";
            this.LblErreur.Visible = false;
            // 
            // JR_FrmCompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 644);
            this.Controls.Add(this.tctrlCompteRendu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JR_FrmCompteRendu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comptes rendus des interventions";
            this.Activated += new System.EventHandler(this.JR_FrmCompteRendu_Activated);
            this.Load += new System.EventHandler(this.JR_FrmCompteRendu_Load);
            this.tctrlCompteRendu.ResumeLayout(false);
            this.tabConsultation.ResumeLayout(false);
            this.tabConsultation.PerformLayout();
            this.GbxListeCompteRendu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeCompteRendu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlCompteRendu;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabMiseAJour;
        private System.Windows.Forms.GroupBox GbxListeCompteRendu;
        private System.Windows.Forms.DataGridView DtgListeCompteRendu;
        private System.Windows.Forms.MonthCalendar MCalCompteRendu;
        private System.Windows.Forms.Button BtnToutAfficher;
        private CircularProgressControl.CircularProgressControl ProgressControlVisiteur;
        private System.Windows.Forms.Label LblChargement;
        private System.Windows.Forms.Label LblErreur;
    }
}
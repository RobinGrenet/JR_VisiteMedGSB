namespace JR_VisiteMedGSB
{
    partial class JR_FrmPracticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JR_FrmPracticien));
            this.tctrlPracticien = new System.Windows.Forms.TabControl();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelPraticien = new System.Windows.Forms.TableLayoutPanel();
            this.PnlFicheDetail = new System.Windows.Forms.Panel();
            this.LblVille = new System.Windows.Forms.Label();
            this.LblCP = new System.Windows.Forms.Label();
            this.LblAdresse = new System.Windows.Forms.Label();
            this.LblVilleLibelle = new System.Windows.Forms.Label();
            this.LblCPLibelle = new System.Windows.Forms.Label();
            this.LblAdresseLibelle = new System.Windows.Forms.Label();
            this.GbxListePraticien = new System.Windows.Forms.GroupBox();
            this.DtgListePraticien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnToutAfficher = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.LblErreur = new System.Windows.Forms.Label();
            this.LblChargement = new System.Windows.Forms.Label();
            this.IndicateurProgression = new CircularProgressControl.CircularProgressControl();
            this.LbxFonctionPracticien = new System.Windows.Forms.ListBox();
            this.tabMiseAJour = new System.Windows.Forms.TabPage();
            this.tctrlPracticien.SuspendLayout();
            this.tabConsultation.SuspendLayout();
            this.TableLayoutPanelPraticien.SuspendLayout();
            this.PnlFicheDetail.SuspendLayout();
            this.GbxListePraticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListePraticien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlPracticien
            // 
            this.tctrlPracticien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctrlPracticien.Controls.Add(this.tabConsultation);
            this.tctrlPracticien.Controls.Add(this.tabMiseAJour);
            this.tctrlPracticien.Location = new System.Drawing.Point(13, 13);
            this.tctrlPracticien.Name = "tctrlPracticien";
            this.tctrlPracticien.SelectedIndex = 0;
            this.tctrlPracticien.Size = new System.Drawing.Size(968, 619);
            this.tctrlPracticien.TabIndex = 0;
            // 
            // tabConsultation
            // 
            this.tabConsultation.Controls.Add(this.TableLayoutPanelPraticien);
            this.tabConsultation.Location = new System.Drawing.Point(4, 22);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(960, 593);
            this.tabConsultation.TabIndex = 0;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelPraticien
            // 
            this.TableLayoutPanelPraticien.ColumnCount = 3;
            this.TableLayoutPanelPraticien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.TableLayoutPanelPraticien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.TableLayoutPanelPraticien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.TableLayoutPanelPraticien.Controls.Add(this.panel1, 2, 0);
            this.TableLayoutPanelPraticien.Controls.Add(this.PnlFicheDetail, 2, 1);
            this.TableLayoutPanelPraticien.Controls.Add(this.LbxFonctionPracticien, 0, 0);
            this.TableLayoutPanelPraticien.Controls.Add(this.GbxListePraticien, 1, 0);
            this.TableLayoutPanelPraticien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelPraticien.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelPraticien.Name = "TableLayoutPanelPraticien";
            this.TableLayoutPanelPraticien.RowCount = 2;
            this.TableLayoutPanelPraticien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.TableLayoutPanelPraticien.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelPraticien.Size = new System.Drawing.Size(954, 587);
            this.TableLayoutPanelPraticien.TabIndex = 0;
            // 
            // PnlFicheDetail
            // 
            this.PnlFicheDetail.Controls.Add(this.LblVille);
            this.PnlFicheDetail.Controls.Add(this.LblCP);
            this.PnlFicheDetail.Controls.Add(this.LblAdresse);
            this.PnlFicheDetail.Controls.Add(this.LblVilleLibelle);
            this.PnlFicheDetail.Controls.Add(this.LblCPLibelle);
            this.PnlFicheDetail.Controls.Add(this.LblAdresseLibelle);
            this.PnlFicheDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFicheDetail.Location = new System.Drawing.Point(638, 253);
            this.PnlFicheDetail.Name = "PnlFicheDetail";
            this.PnlFicheDetail.Size = new System.Drawing.Size(313, 331);
            this.PnlFicheDetail.TabIndex = 4;
            // 
            // LblVille
            // 
            this.LblVille.AutoSize = true;
            this.LblVille.Location = new System.Drawing.Point(112, 149);
            this.LblVille.Name = "LblVille";
            this.LblVille.Size = new System.Drawing.Size(27, 13);
            this.LblVille.TabIndex = 1;
            this.LblVille.Text = "N/A";
            // 
            // LblCP
            // 
            this.LblCP.AutoSize = true;
            this.LblCP.Location = new System.Drawing.Point(112, 115);
            this.LblCP.Name = "LblCP";
            this.LblCP.Size = new System.Drawing.Size(27, 13);
            this.LblCP.TabIndex = 1;
            this.LblCP.Text = "N/A";
            // 
            // LblAdresse
            // 
            this.LblAdresse.AutoSize = true;
            this.LblAdresse.Location = new System.Drawing.Point(112, 80);
            this.LblAdresse.Name = "LblAdresse";
            this.LblAdresse.Size = new System.Drawing.Size(27, 13);
            this.LblAdresse.TabIndex = 1;
            this.LblAdresse.Text = "N/A";
            // 
            // LblVilleLibelle
            // 
            this.LblVilleLibelle.AutoSize = true;
            this.LblVilleLibelle.Location = new System.Drawing.Point(6, 149);
            this.LblVilleLibelle.Name = "LblVilleLibelle";
            this.LblVilleLibelle.Size = new System.Drawing.Size(32, 13);
            this.LblVilleLibelle.TabIndex = 0;
            this.LblVilleLibelle.Text = "Ville :";
            // 
            // LblCPLibelle
            // 
            this.LblCPLibelle.AutoSize = true;
            this.LblCPLibelle.Location = new System.Drawing.Point(6, 115);
            this.LblCPLibelle.Name = "LblCPLibelle";
            this.LblCPLibelle.Size = new System.Drawing.Size(69, 13);
            this.LblCPLibelle.TabIndex = 0;
            this.LblCPLibelle.Text = "Code postal :";
            // 
            // LblAdresseLibelle
            // 
            this.LblAdresseLibelle.AutoSize = true;
            this.LblAdresseLibelle.Location = new System.Drawing.Point(6, 80);
            this.LblAdresseLibelle.Name = "LblAdresseLibelle";
            this.LblAdresseLibelle.Size = new System.Drawing.Size(51, 13);
            this.LblAdresseLibelle.TabIndex = 0;
            this.LblAdresseLibelle.Text = "Adresse :";
            // 
            // GbxListePraticien
            // 
            this.GbxListePraticien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxListePraticien.Controls.Add(this.DtgListePraticien);
            this.GbxListePraticien.Location = new System.Drawing.Point(320, 3);
            this.GbxListePraticien.Name = "GbxListePraticien";
            this.TableLayoutPanelPraticien.SetRowSpan(this.GbxListePraticien, 2);
            this.GbxListePraticien.Size = new System.Drawing.Size(312, 581);
            this.GbxListePraticien.TabIndex = 2;
            this.GbxListePraticien.TabStop = false;
            this.GbxListePraticien.Text = "Nombre de praticiens : ";
            // 
            // DtgListePraticien
            // 
            this.DtgListePraticien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgListePraticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListePraticien.Location = new System.Drawing.Point(6, 19);
            this.DtgListePraticien.Name = "DtgListePraticien";
            this.DtgListePraticien.Size = new System.Drawing.Size(300, 556);
            this.DtgListePraticien.TabIndex = 1;
            this.DtgListePraticien.DataSourceChanged += new System.EventHandler(this.DtgListePraticien_DataSourceChanged);
            this.DtgListePraticien.SelectionChanged += new System.EventHandler(this.DtgListePraticien_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnToutAfficher);
            this.panel1.Controls.Add(this.BtnAnnuler);
            this.panel1.Controls.Add(this.LblErreur);
            this.panel1.Controls.Add(this.LblChargement);
            this.panel1.Controls.Add(this.IndicateurProgression);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(638, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 244);
            this.panel1.TabIndex = 5;
            // 
            // BtnToutAfficher
            // 
            this.BtnToutAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnToutAfficher.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnToutAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToutAfficher.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToutAfficher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnToutAfficher.Location = new System.Drawing.Point(83, 6);
            this.BtnToutAfficher.Name = "BtnToutAfficher";
            this.BtnToutAfficher.Size = new System.Drawing.Size(227, 59);
            this.BtnToutAfficher.TabIndex = 17;
            this.BtnToutAfficher.Text = "Tout afficher";
            this.BtnToutAfficher.UseVisualStyleBackColor = false;
            this.BtnToutAfficher.Click += new System.EventHandler(this.BtnToutAfficher_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(9, 122);
            this.BtnAnnuler.MaximumSize = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 16;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Visible = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // LblErreur
            // 
            this.LblErreur.ForeColor = System.Drawing.Color.Red;
            this.LblErreur.Location = new System.Drawing.Point(6, 161);
            this.LblErreur.Name = "LblErreur";
            this.LblErreur.Size = new System.Drawing.Size(306, 77);
            this.LblErreur.TabIndex = 15;
            this.LblErreur.Text = "Erreur";
            this.LblErreur.Visible = false;
            // 
            // LblChargement
            // 
            this.LblChargement.AutoSize = true;
            this.LblChargement.Location = new System.Drawing.Point(39, 93);
            this.LblChargement.Name = "LblChargement";
            this.LblChargement.Size = new System.Drawing.Size(73, 13);
            this.LblChargement.TabIndex = 14;
            this.LblChargement.Text = "Chargement...";
            this.LblChargement.Visible = false;
            // 
            // IndicateurProgression
            // 
            this.IndicateurProgression.BackColor = System.Drawing.Color.Transparent;
            this.IndicateurProgression.Interval = 60;
            this.IndicateurProgression.Location = new System.Drawing.Point(6, 83);
            this.IndicateurProgression.MinimumSize = new System.Drawing.Size(28, 28);
            this.IndicateurProgression.Name = "IndicateurProgression";
            this.IndicateurProgression.Rotation = CircularProgressControl.CircularProgressControl.Direction.CLOCKWISE;
            this.IndicateurProgression.Size = new System.Drawing.Size(32, 32);
            this.IndicateurProgression.StartAngle = 270F;
            this.IndicateurProgression.TabIndex = 13;
            this.IndicateurProgression.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.IndicateurProgression.Visible = false;
            // 
            // LbxFonctionPracticien
            // 
            this.LbxFonctionPracticien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbxFonctionPracticien.FormattingEnabled = true;
            this.LbxFonctionPracticien.Location = new System.Drawing.Point(3, 3);
            this.LbxFonctionPracticien.Name = "LbxFonctionPracticien";
            this.TableLayoutPanelPraticien.SetRowSpan(this.LbxFonctionPracticien, 2);
            this.LbxFonctionPracticien.Size = new System.Drawing.Size(311, 576);
            this.LbxFonctionPracticien.TabIndex = 6;
            this.LbxFonctionPracticien.SelectedValueChanged += new System.EventHandler(this.LbxFonctionPracticien_SelectedValueChanged);
            // 
            // tabMiseAJour
            // 
            this.tabMiseAJour.Location = new System.Drawing.Point(4, 22);
            this.tabMiseAJour.Name = "tabMiseAJour";
            this.tabMiseAJour.Padding = new System.Windows.Forms.Padding(3);
            this.tabMiseAJour.Size = new System.Drawing.Size(960, 593);
            this.tabMiseAJour.TabIndex = 1;
            this.tabMiseAJour.Text = "Mise à jour";
            this.tabMiseAJour.UseVisualStyleBackColor = true;
            // 
            // JR_FrmPracticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 644);
            this.Controls.Add(this.tctrlPracticien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JR_FrmPracticien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des praticiens";
            this.Activated += new System.EventHandler(this.JR_FrmPracticien_Activated);
            this.Load += new System.EventHandler(this.JR_FrmPracticien_Load);
            this.tctrlPracticien.ResumeLayout(false);
            this.tabConsultation.ResumeLayout(false);
            this.TableLayoutPanelPraticien.ResumeLayout(false);
            this.PnlFicheDetail.ResumeLayout(false);
            this.PnlFicheDetail.PerformLayout();
            this.GbxListePraticien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgListePraticien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlPracticien;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabMiseAJour;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelPraticien;
        private System.Windows.Forms.Panel PnlFicheDetail;
        private System.Windows.Forms.Label LblVille;
        private System.Windows.Forms.Label LblCP;
        private System.Windows.Forms.Label LblAdresse;
        private System.Windows.Forms.Label LblVilleLibelle;
        private System.Windows.Forms.Label LblCPLibelle;
        private System.Windows.Forms.Label LblAdresseLibelle;
        private System.Windows.Forms.GroupBox GbxListePraticien;
        private System.Windows.Forms.DataGridView DtgListePraticien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnToutAfficher;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Label LblErreur;
        private System.Windows.Forms.Label LblChargement;
        private CircularProgressControl.CircularProgressControl IndicateurProgression;
        private System.Windows.Forms.ListBox LbxFonctionPracticien;
    }
}
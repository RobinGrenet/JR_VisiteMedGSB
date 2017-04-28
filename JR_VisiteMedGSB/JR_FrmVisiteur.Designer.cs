namespace JR_VisiteMedGSB
{
    partial class JR_FrmVisiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JR_FrmVisiteur));
            this.tctrlVisiteur = new System.Windows.Forms.TabControl();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.SplitContainerVisiteur = new System.Windows.Forms.SplitContainer();
            this.GbxListeVisiteur = new System.Windows.Forms.GroupBox();
            this.DtgListeVisiteur = new System.Windows.Forms.DataGridView();
            this.BtnToutAfficher = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.LblErreur = new System.Windows.Forms.Label();
            this.LblChargement = new System.Windows.Forms.Label();
            this.IndicateurProgression = new CircularProgressControl.CircularProgressControl();
            this.PnlFicheDetail = new System.Windows.Forms.Panel();
            this.LblVille = new System.Windows.Forms.Label();
            this.LblCP = new System.Windows.Forms.Label();
            this.LblAdresse = new System.Windows.Forms.Label();
            this.LblVilleLibelle = new System.Windows.Forms.Label();
            this.LblCPLibelle = new System.Windows.Forms.Label();
            this.LblAdresseLibelle = new System.Windows.Forms.Label();
            this.MCalVisiteur = new System.Windows.Forms.MonthCalendar();
            this.tabMiseAJour = new System.Windows.Forms.TabPage();
            this.DtpDateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.TbxVilleModif = new System.Windows.Forms.TextBox();
            this.TbxCPModif = new System.Windows.Forms.TextBox();
            this.TbxAdresseModif = new System.Windows.Forms.TextBox();
            this.TbxPrenomModif = new System.Windows.Forms.TextBox();
            this.TbxNomModif = new System.Windows.Forms.TextBox();
            this.TbxMatriculeModif = new System.Windows.Forms.TextBox();
            this.LblDateEmbaucheModif = new System.Windows.Forms.Label();
            this.LblVilleModif = new System.Windows.Forms.Label();
            this.LblCPModif = new System.Windows.Forms.Label();
            this.LblAdresseModif = new System.Windows.Forms.Label();
            this.LblPrenomModif = new System.Windows.Forms.Label();
            this.LblNomModif = new System.Windows.Forms.Label();
            this.LblMatriculeModif = new System.Windows.Forms.Label();
            this.BtnAnnulerModif = new System.Windows.Forms.Button();
            this.LblErreurModif = new System.Windows.Forms.Label();
            this.LblChargementModif = new System.Windows.Forms.Label();
            this.IndicateurProgressionModif = new CircularProgressControl.CircularProgressControl();
            this.DtgListeVisiteurModif = new System.Windows.Forms.DataGridView();
            this.tctrlVisiteur.SuspendLayout();
            this.tabConsultation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerVisiteur)).BeginInit();
            this.SplitContainerVisiteur.Panel1.SuspendLayout();
            this.SplitContainerVisiteur.Panel2.SuspendLayout();
            this.SplitContainerVisiteur.SuspendLayout();
            this.GbxListeVisiteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeVisiteur)).BeginInit();
            this.PnlFicheDetail.SuspendLayout();
            this.tabMiseAJour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeVisiteurModif)).BeginInit();
            this.SuspendLayout();
            // 
            // tctrlVisiteur
            // 
            this.tctrlVisiteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctrlVisiteur.Controls.Add(this.tabConsultation);
            this.tctrlVisiteur.Controls.Add(this.tabMiseAJour);
            this.tctrlVisiteur.Location = new System.Drawing.Point(12, 12);
            this.tctrlVisiteur.Name = "tctrlVisiteur";
            this.tctrlVisiteur.SelectedIndex = 0;
            this.tctrlVisiteur.Size = new System.Drawing.Size(969, 620);
            this.tctrlVisiteur.TabIndex = 0;
            // 
            // tabConsultation
            // 
            this.tabConsultation.Controls.Add(this.SplitContainerVisiteur);
            this.tabConsultation.Location = new System.Drawing.Point(4, 22);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(961, 594);
            this.tabConsultation.TabIndex = 0;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            // 
            // SplitContainerVisiteur
            // 
            this.SplitContainerVisiteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainerVisiteur.Location = new System.Drawing.Point(6, 6);
            this.SplitContainerVisiteur.Name = "SplitContainerVisiteur";
            // 
            // SplitContainerVisiteur.Panel1
            // 
            this.SplitContainerVisiteur.Panel1.Controls.Add(this.GbxListeVisiteur);
            // 
            // SplitContainerVisiteur.Panel2
            // 
            this.SplitContainerVisiteur.Panel2.Controls.Add(this.BtnToutAfficher);
            this.SplitContainerVisiteur.Panel2.Controls.Add(this.BtnAnnuler);
            this.SplitContainerVisiteur.Panel2.Controls.Add(this.LblErreur);
            this.SplitContainerVisiteur.Panel2.Controls.Add(this.LblChargement);
            this.SplitContainerVisiteur.Panel2.Controls.Add(this.IndicateurProgression);
            this.SplitContainerVisiteur.Panel2.Controls.Add(this.PnlFicheDetail);
            this.SplitContainerVisiteur.Panel2.Controls.Add(this.MCalVisiteur);
            this.SplitContainerVisiteur.Size = new System.Drawing.Size(949, 585);
            this.SplitContainerVisiteur.SplitterDistance = 327;
            this.SplitContainerVisiteur.TabIndex = 2;
            // 
            // GbxListeVisiteur
            // 
            this.GbxListeVisiteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxListeVisiteur.Controls.Add(this.DtgListeVisiteur);
            this.GbxListeVisiteur.Location = new System.Drawing.Point(3, 3);
            this.GbxListeVisiteur.Name = "GbxListeVisiteur";
            this.GbxListeVisiteur.Size = new System.Drawing.Size(321, 579);
            this.GbxListeVisiteur.TabIndex = 1;
            this.GbxListeVisiteur.TabStop = false;
            this.GbxListeVisiteur.Text = "Nombre de visiteurs : ";
            // 
            // DtgListeVisiteur
            // 
            this.DtgListeVisiteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgListeVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListeVisiteur.Location = new System.Drawing.Point(6, 19);
            this.DtgListeVisiteur.Name = "DtgListeVisiteur";
            this.DtgListeVisiteur.Size = new System.Drawing.Size(309, 554);
            this.DtgListeVisiteur.TabIndex = 1;
            this.DtgListeVisiteur.DataSourceChanged += new System.EventHandler(this.DtgListeVisiteur_DataSourceChanged);
            this.DtgListeVisiteur.SelectionChanged += new System.EventHandler(this.DtgListeVisiteur_SelectionChanged);
            // 
            // BtnToutAfficher
            // 
            this.BtnToutAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnToutAfficher.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnToutAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToutAfficher.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToutAfficher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnToutAfficher.Location = new System.Drawing.Point(388, 19);
            this.BtnToutAfficher.Name = "BtnToutAfficher";
            this.BtnToutAfficher.Size = new System.Drawing.Size(227, 59);
            this.BtnToutAfficher.TabIndex = 12;
            this.BtnToutAfficher.Text = "Tout afficher";
            this.BtnToutAfficher.UseVisualStyleBackColor = false;
            this.BtnToutAfficher.Click += new System.EventHandler(this.BtnToutAfficher_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(251, 48);
            this.BtnAnnuler.MaximumSize = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 11;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Visible = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // LblErreur
            // 
            this.LblErreur.ForeColor = System.Drawing.Color.Red;
            this.LblErreur.Location = new System.Drawing.Point(248, 87);
            this.LblErreur.Name = "LblErreur";
            this.LblErreur.Size = new System.Drawing.Size(367, 93);
            this.LblErreur.TabIndex = 10;
            this.LblErreur.Text = "Erreur";
            this.LblErreur.Visible = false;
            // 
            // LblChargement
            // 
            this.LblChargement.AutoSize = true;
            this.LblChargement.Location = new System.Drawing.Point(281, 19);
            this.LblChargement.Name = "LblChargement";
            this.LblChargement.Size = new System.Drawing.Size(73, 13);
            this.LblChargement.TabIndex = 9;
            this.LblChargement.Text = "Chargement...";
            this.LblChargement.Visible = false;
            // 
            // IndicateurProgression
            // 
            this.IndicateurProgression.BackColor = System.Drawing.Color.Transparent;
            this.IndicateurProgression.Interval = 60;
            this.IndicateurProgression.Location = new System.Drawing.Point(248, 9);
            this.IndicateurProgression.MinimumSize = new System.Drawing.Size(28, 28);
            this.IndicateurProgression.Name = "IndicateurProgression";
            this.IndicateurProgression.Rotation = CircularProgressControl.CircularProgressControl.Direction.CLOCKWISE;
            this.IndicateurProgression.Size = new System.Drawing.Size(32, 32);
            this.IndicateurProgression.StartAngle = 270F;
            this.IndicateurProgression.TabIndex = 8;
            this.IndicateurProgression.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.IndicateurProgression.Visible = false;
            // 
            // PnlFicheDetail
            // 
            this.PnlFicheDetail.Controls.Add(this.LblVille);
            this.PnlFicheDetail.Controls.Add(this.LblCP);
            this.PnlFicheDetail.Controls.Add(this.LblAdresse);
            this.PnlFicheDetail.Controls.Add(this.LblVilleLibelle);
            this.PnlFicheDetail.Controls.Add(this.LblCPLibelle);
            this.PnlFicheDetail.Controls.Add(this.LblAdresseLibelle);
            this.PnlFicheDetail.Location = new System.Drawing.Point(3, 183);
            this.PnlFicheDetail.Name = "PnlFicheDetail";
            this.PnlFicheDetail.Size = new System.Drawing.Size(612, 399);
            this.PnlFicheDetail.TabIndex = 1;
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
            // MCalVisiteur
            // 
            this.MCalVisiteur.Location = new System.Drawing.Point(9, 9);
            this.MCalVisiteur.MaxSelectionCount = 31;
            this.MCalVisiteur.Name = "MCalVisiteur";
            this.MCalVisiteur.TabIndex = 0;
            this.MCalVisiteur.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MCalVisiteur_DateChanged);
            // 
            // tabMiseAJour
            // 
            this.tabMiseAJour.Controls.Add(this.DtpDateEmbauche);
            this.tabMiseAJour.Controls.Add(this.BtnModifier);
            this.tabMiseAJour.Controls.Add(this.TbxVilleModif);
            this.tabMiseAJour.Controls.Add(this.TbxCPModif);
            this.tabMiseAJour.Controls.Add(this.TbxAdresseModif);
            this.tabMiseAJour.Controls.Add(this.TbxPrenomModif);
            this.tabMiseAJour.Controls.Add(this.TbxNomModif);
            this.tabMiseAJour.Controls.Add(this.TbxMatriculeModif);
            this.tabMiseAJour.Controls.Add(this.LblDateEmbaucheModif);
            this.tabMiseAJour.Controls.Add(this.LblVilleModif);
            this.tabMiseAJour.Controls.Add(this.LblCPModif);
            this.tabMiseAJour.Controls.Add(this.LblAdresseModif);
            this.tabMiseAJour.Controls.Add(this.LblPrenomModif);
            this.tabMiseAJour.Controls.Add(this.LblNomModif);
            this.tabMiseAJour.Controls.Add(this.LblMatriculeModif);
            this.tabMiseAJour.Controls.Add(this.BtnAnnulerModif);
            this.tabMiseAJour.Controls.Add(this.LblErreurModif);
            this.tabMiseAJour.Controls.Add(this.LblChargementModif);
            this.tabMiseAJour.Controls.Add(this.IndicateurProgressionModif);
            this.tabMiseAJour.Controls.Add(this.DtgListeVisiteurModif);
            this.tabMiseAJour.Location = new System.Drawing.Point(4, 22);
            this.tabMiseAJour.Name = "tabMiseAJour";
            this.tabMiseAJour.Padding = new System.Windows.Forms.Padding(3);
            this.tabMiseAJour.Size = new System.Drawing.Size(961, 594);
            this.tabMiseAJour.TabIndex = 1;
            this.tabMiseAJour.Text = "Mise à jour";
            this.tabMiseAJour.UseVisualStyleBackColor = true;
            // 
            // DtpDateEmbauche
            // 
            this.DtpDateEmbauche.Location = new System.Drawing.Point(601, 431);
            this.DtpDateEmbauche.Name = "DtpDateEmbauche";
            this.DtpDateEmbauche.Size = new System.Drawing.Size(200, 20);
            this.DtpDateEmbauche.TabIndex = 19;
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(449, 497);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(75, 23);
            this.BtnModifier.TabIndex = 18;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // TbxVilleModif
            // 
            this.TbxVilleModif.Location = new System.Drawing.Point(601, 398);
            this.TbxVilleModif.Name = "TbxVilleModif";
            this.TbxVilleModif.Size = new System.Drawing.Size(175, 20);
            this.TbxVilleModif.TabIndex = 17;
            // 
            // TbxCPModif
            // 
            this.TbxCPModif.Location = new System.Drawing.Point(601, 366);
            this.TbxCPModif.Name = "TbxCPModif";
            this.TbxCPModif.Size = new System.Drawing.Size(175, 20);
            this.TbxCPModif.TabIndex = 17;
            // 
            // TbxAdresseModif
            // 
            this.TbxAdresseModif.Location = new System.Drawing.Point(601, 330);
            this.TbxAdresseModif.Name = "TbxAdresseModif";
            this.TbxAdresseModif.Size = new System.Drawing.Size(175, 20);
            this.TbxAdresseModif.TabIndex = 17;
            // 
            // TbxPrenomModif
            // 
            this.TbxPrenomModif.Location = new System.Drawing.Point(601, 300);
            this.TbxPrenomModif.Name = "TbxPrenomModif";
            this.TbxPrenomModif.Size = new System.Drawing.Size(175, 20);
            this.TbxPrenomModif.TabIndex = 17;
            // 
            // TbxNomModif
            // 
            this.TbxNomModif.Location = new System.Drawing.Point(601, 273);
            this.TbxNomModif.Name = "TbxNomModif";
            this.TbxNomModif.Size = new System.Drawing.Size(175, 20);
            this.TbxNomModif.TabIndex = 17;
            // 
            // TbxMatriculeModif
            // 
            this.TbxMatriculeModif.Location = new System.Drawing.Point(601, 243);
            this.TbxMatriculeModif.Name = "TbxMatriculeModif";
            this.TbxMatriculeModif.Size = new System.Drawing.Size(175, 20);
            this.TbxMatriculeModif.TabIndex = 17;
            // 
            // LblDateEmbaucheModif
            // 
            this.LblDateEmbaucheModif.AutoSize = true;
            this.LblDateEmbaucheModif.Location = new System.Drawing.Point(446, 437);
            this.LblDateEmbaucheModif.Name = "LblDateEmbaucheModif";
            this.LblDateEmbaucheModif.Size = new System.Drawing.Size(97, 13);
            this.LblDateEmbaucheModif.TabIndex = 16;
            this.LblDateEmbaucheModif.Text = "Date d\'embauche :";
            // 
            // LblVilleModif
            // 
            this.LblVilleModif.AutoSize = true;
            this.LblVilleModif.Location = new System.Drawing.Point(446, 401);
            this.LblVilleModif.Name = "LblVilleModif";
            this.LblVilleModif.Size = new System.Drawing.Size(32, 13);
            this.LblVilleModif.TabIndex = 16;
            this.LblVilleModif.Text = "Ville :";
            // 
            // LblCPModif
            // 
            this.LblCPModif.AutoSize = true;
            this.LblCPModif.Location = new System.Drawing.Point(446, 369);
            this.LblCPModif.Name = "LblCPModif";
            this.LblCPModif.Size = new System.Drawing.Size(69, 13);
            this.LblCPModif.TabIndex = 16;
            this.LblCPModif.Text = "Code postal :";
            // 
            // LblAdresseModif
            // 
            this.LblAdresseModif.AutoSize = true;
            this.LblAdresseModif.Location = new System.Drawing.Point(446, 333);
            this.LblAdresseModif.Name = "LblAdresseModif";
            this.LblAdresseModif.Size = new System.Drawing.Size(51, 13);
            this.LblAdresseModif.TabIndex = 16;
            this.LblAdresseModif.Text = "Adresse :";
            // 
            // LblPrenomModif
            // 
            this.LblPrenomModif.AutoSize = true;
            this.LblPrenomModif.Location = new System.Drawing.Point(446, 303);
            this.LblPrenomModif.Name = "LblPrenomModif";
            this.LblPrenomModif.Size = new System.Drawing.Size(49, 13);
            this.LblPrenomModif.TabIndex = 16;
            this.LblPrenomModif.Text = "Prénom :";
            // 
            // LblNomModif
            // 
            this.LblNomModif.AutoSize = true;
            this.LblNomModif.Location = new System.Drawing.Point(446, 276);
            this.LblNomModif.Name = "LblNomModif";
            this.LblNomModif.Size = new System.Drawing.Size(35, 13);
            this.LblNomModif.TabIndex = 16;
            this.LblNomModif.Text = "Nom :";
            // 
            // LblMatriculeModif
            // 
            this.LblMatriculeModif.AutoSize = true;
            this.LblMatriculeModif.Location = new System.Drawing.Point(446, 246);
            this.LblMatriculeModif.Name = "LblMatriculeModif";
            this.LblMatriculeModif.Size = new System.Drawing.Size(56, 13);
            this.LblMatriculeModif.TabIndex = 16;
            this.LblMatriculeModif.Text = "Matricule :";
            // 
            // BtnAnnulerModif
            // 
            this.BtnAnnulerModif.Location = new System.Drawing.Point(446, 45);
            this.BtnAnnulerModif.MaximumSize = new System.Drawing.Size(75, 23);
            this.BtnAnnulerModif.Name = "BtnAnnulerModif";
            this.BtnAnnulerModif.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnulerModif.TabIndex = 15;
            this.BtnAnnulerModif.Text = "Annuler";
            this.BtnAnnulerModif.UseVisualStyleBackColor = true;
            this.BtnAnnulerModif.Visible = false;
            this.BtnAnnulerModif.Click += new System.EventHandler(this.BtnAnnulerModif_Click);
            // 
            // LblErreurModif
            // 
            this.LblErreurModif.ForeColor = System.Drawing.Color.Red;
            this.LblErreurModif.Location = new System.Drawing.Point(443, 84);
            this.LblErreurModif.Name = "LblErreurModif";
            this.LblErreurModif.Size = new System.Drawing.Size(367, 93);
            this.LblErreurModif.TabIndex = 14;
            this.LblErreurModif.Text = "Erreur";
            this.LblErreurModif.Visible = false;
            // 
            // LblChargementModif
            // 
            this.LblChargementModif.AutoSize = true;
            this.LblChargementModif.Location = new System.Drawing.Point(476, 16);
            this.LblChargementModif.Name = "LblChargementModif";
            this.LblChargementModif.Size = new System.Drawing.Size(73, 13);
            this.LblChargementModif.TabIndex = 13;
            this.LblChargementModif.Text = "Chargement...";
            this.LblChargementModif.Visible = false;
            // 
            // IndicateurProgressionModif
            // 
            this.IndicateurProgressionModif.BackColor = System.Drawing.Color.Transparent;
            this.IndicateurProgressionModif.Interval = 60;
            this.IndicateurProgressionModif.Location = new System.Drawing.Point(443, 6);
            this.IndicateurProgressionModif.MinimumSize = new System.Drawing.Size(28, 28);
            this.IndicateurProgressionModif.Name = "IndicateurProgressionModif";
            this.IndicateurProgressionModif.Rotation = CircularProgressControl.CircularProgressControl.Direction.CLOCKWISE;
            this.IndicateurProgressionModif.Size = new System.Drawing.Size(32, 32);
            this.IndicateurProgressionModif.StartAngle = 270F;
            this.IndicateurProgressionModif.TabIndex = 12;
            this.IndicateurProgressionModif.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.IndicateurProgressionModif.Visible = false;
            // 
            // DtgListeVisiteurModif
            // 
            this.DtgListeVisiteurModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListeVisiteurModif.Dock = System.Windows.Forms.DockStyle.Left;
            this.DtgListeVisiteurModif.Location = new System.Drawing.Point(3, 3);
            this.DtgListeVisiteurModif.Name = "DtgListeVisiteurModif";
            this.DtgListeVisiteurModif.Size = new System.Drawing.Size(434, 588);
            this.DtgListeVisiteurModif.TabIndex = 0;
            this.DtgListeVisiteurModif.SelectionChanged += new System.EventHandler(this.DtgListeVisiteurModif_SelectionChanged);
            // 
            // JR_FrmVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 644);
            this.Controls.Add(this.tctrlVisiteur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JR_FrmVisiteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des visiteurs";
            this.Activated += new System.EventHandler(this.JR_FrmVisiteur_Activated);
            this.Load += new System.EventHandler(this.JR_FrmVisiteur_Load);
            this.tctrlVisiteur.ResumeLayout(false);
            this.tabConsultation.ResumeLayout(false);
            this.SplitContainerVisiteur.Panel1.ResumeLayout(false);
            this.SplitContainerVisiteur.Panel2.ResumeLayout(false);
            this.SplitContainerVisiteur.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerVisiteur)).EndInit();
            this.SplitContainerVisiteur.ResumeLayout(false);
            this.GbxListeVisiteur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeVisiteur)).EndInit();
            this.PnlFicheDetail.ResumeLayout(false);
            this.PnlFicheDetail.PerformLayout();
            this.tabMiseAJour.ResumeLayout(false);
            this.tabMiseAJour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeVisiteurModif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlVisiteur;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabMiseAJour;
        private System.Windows.Forms.SplitContainer SplitContainerVisiteur;
        private System.Windows.Forms.GroupBox GbxListeVisiteur;
        private System.Windows.Forms.DataGridView DtgListeVisiteur;
        private System.Windows.Forms.MonthCalendar MCalVisiteur;
        private System.Windows.Forms.Panel PnlFicheDetail;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Label LblErreur;
        private System.Windows.Forms.Label LblChargement;
        private CircularProgressControl.CircularProgressControl IndicateurProgression;
        private System.Windows.Forms.Label LblVille;
        private System.Windows.Forms.Label LblCP;
        private System.Windows.Forms.Label LblAdresse;
        private System.Windows.Forms.Label LblVilleLibelle;
        private System.Windows.Forms.Label LblCPLibelle;
        private System.Windows.Forms.Label LblAdresseLibelle;
        private System.Windows.Forms.Button BtnToutAfficher;
        private System.Windows.Forms.DataGridView DtgListeVisiteurModif;
        private System.Windows.Forms.Button BtnAnnulerModif;
        private System.Windows.Forms.Label LblErreurModif;
        private System.Windows.Forms.Label LblChargementModif;
        private CircularProgressControl.CircularProgressControl IndicateurProgressionModif;
        private System.Windows.Forms.Label LblDateEmbaucheModif;
        private System.Windows.Forms.Label LblVilleModif;
        private System.Windows.Forms.Label LblCPModif;
        private System.Windows.Forms.Label LblAdresseModif;
        private System.Windows.Forms.Label LblPrenomModif;
        private System.Windows.Forms.Label LblNomModif;
        private System.Windows.Forms.Label LblMatriculeModif;
        private System.Windows.Forms.TextBox TbxVilleModif;
        private System.Windows.Forms.TextBox TbxCPModif;
        private System.Windows.Forms.TextBox TbxAdresseModif;
        private System.Windows.Forms.TextBox TbxPrenomModif;
        private System.Windows.Forms.TextBox TbxNomModif;
        private System.Windows.Forms.TextBox TbxMatriculeModif;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.DateTimePicker DtpDateEmbauche;
    }
}
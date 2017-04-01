namespace JR_VisiteMedGSB
{
    partial class JR_FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JR_FrmPrincipal));
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.Fichier_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FichierFermer_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FichierQuitter_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Visiteur_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.VisiteurConsultation_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.VisiteurMAJ_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Praticien_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PraticienConsultation_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PraticienMAJ_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteRendu_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteRenduConsultation_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteRenduMAJ_MenuPrincipalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier_MenuPrincipalButton,
            this.Visiteur_MenuPrincipalButton,
            this.Praticien_MenuPrincipalButton,
            this.CompteRendu_MenuPrincipalButton});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(1052, 24);
            this.msMenuPrincipal.TabIndex = 1;
            this.msMenuPrincipal.Text = "menuStrip1";
            // 
            // Fichier_MenuPrincipalButton
            // 
            this.Fichier_MenuPrincipalButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FichierFermer_MenuPrincipalButton,
            this.FichierQuitter_MenuPrincipalButton});
            this.Fichier_MenuPrincipalButton.Name = "Fichier_MenuPrincipalButton";
            this.Fichier_MenuPrincipalButton.Size = new System.Drawing.Size(54, 20);
            this.Fichier_MenuPrincipalButton.Text = "&Fichier";
            // 
            // FichierFermer_MenuPrincipalButton
            // 
            this.FichierFermer_MenuPrincipalButton.Name = "FichierFermer_MenuPrincipalButton";
            this.FichierFermer_MenuPrincipalButton.Size = new System.Drawing.Size(152, 22);
            this.FichierFermer_MenuPrincipalButton.Text = "F&ermer";
            this.FichierFermer_MenuPrincipalButton.ToolTipText = "Ferme le formulaire actif";
            this.FichierFermer_MenuPrincipalButton.Click += new System.EventHandler(this.FichierFermer_MenuPrincipalButton_Click);
            // 
            // FichierQuitter_MenuPrincipalButton
            // 
            this.FichierQuitter_MenuPrincipalButton.Name = "FichierQuitter_MenuPrincipalButton";
            this.FichierQuitter_MenuPrincipalButton.Size = new System.Drawing.Size(152, 22);
            this.FichierQuitter_MenuPrincipalButton.Text = "&Quitter";
            this.FichierQuitter_MenuPrincipalButton.Click += new System.EventHandler(this.FichierQuitter_MenuPrincipalButton_Click);
            // 
            // Visiteur_MenuPrincipalButton
            // 
            this.Visiteur_MenuPrincipalButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisiteurConsultation_MenuPrincipalButton,
            this.VisiteurMAJ_MenuPrincipalButton});
            this.Visiteur_MenuPrincipalButton.Name = "Visiteur_MenuPrincipalButton";
            this.Visiteur_MenuPrincipalButton.Size = new System.Drawing.Size(58, 20);
            this.Visiteur_MenuPrincipalButton.Text = "&Visiteur";
            // 
            // VisiteurConsultation_MenuPrincipalButton
            // 
            this.VisiteurConsultation_MenuPrincipalButton.Name = "VisiteurConsultation_MenuPrincipalButton";
            this.VisiteurConsultation_MenuPrincipalButton.Size = new System.Drawing.Size(142, 22);
            this.VisiteurConsultation_MenuPrincipalButton.Text = "&Consultation";
            this.VisiteurConsultation_MenuPrincipalButton.Click += new System.EventHandler(this.VisiteurConsultation_MenuPrincipalButton_Click);
            // 
            // VisiteurMAJ_MenuPrincipalButton
            // 
            this.VisiteurMAJ_MenuPrincipalButton.Name = "VisiteurMAJ_MenuPrincipalButton";
            this.VisiteurMAJ_MenuPrincipalButton.Size = new System.Drawing.Size(142, 22);
            this.VisiteurMAJ_MenuPrincipalButton.Text = "&Mise à jour";
            this.VisiteurMAJ_MenuPrincipalButton.Click += new System.EventHandler(this.VisiteurMAJ_MenuPrincipalButton_Click);
            // 
            // Praticien_MenuPrincipalButton
            // 
            this.Praticien_MenuPrincipalButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PraticienConsultation_MenuPrincipalButton,
            this.PraticienMAJ_MenuPrincipalButton});
            this.Praticien_MenuPrincipalButton.Name = "Praticien_MenuPrincipalButton";
            this.Praticien_MenuPrincipalButton.Size = new System.Drawing.Size(65, 20);
            this.Praticien_MenuPrincipalButton.Text = "&Praticien";
            // 
            // PraticienConsultation_MenuPrincipalButton
            // 
            this.PraticienConsultation_MenuPrincipalButton.Name = "PraticienConsultation_MenuPrincipalButton";
            this.PraticienConsultation_MenuPrincipalButton.Size = new System.Drawing.Size(142, 22);
            this.PraticienConsultation_MenuPrincipalButton.Text = "&Consultation";
            this.PraticienConsultation_MenuPrincipalButton.Click += new System.EventHandler(this.PraticienConsultation_MenuPrincipalButton_Click);
            // 
            // PraticienMAJ_MenuPrincipalButton
            // 
            this.PraticienMAJ_MenuPrincipalButton.Name = "PraticienMAJ_MenuPrincipalButton";
            this.PraticienMAJ_MenuPrincipalButton.Size = new System.Drawing.Size(142, 22);
            this.PraticienMAJ_MenuPrincipalButton.Text = "&Mise à jour";
            this.PraticienMAJ_MenuPrincipalButton.Click += new System.EventHandler(this.PraticienMAJ_MenuPrincipalButton_Click);
            // 
            // CompteRendu_MenuPrincipalButton
            // 
            this.CompteRendu_MenuPrincipalButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompteRenduConsultation_MenuPrincipalButton,
            this.CompteRenduMAJ_MenuPrincipalButton});
            this.CompteRendu_MenuPrincipalButton.Name = "CompteRendu_MenuPrincipalButton";
            this.CompteRendu_MenuPrincipalButton.Size = new System.Drawing.Size(159, 20);
            this.CompteRendu_MenuPrincipalButton.Text = "C&ompte-rendus des visites";
            // 
            // CompteRenduConsultation_MenuPrincipalButton
            // 
            this.CompteRenduConsultation_MenuPrincipalButton.Name = "CompteRenduConsultation_MenuPrincipalButton";
            this.CompteRenduConsultation_MenuPrincipalButton.Size = new System.Drawing.Size(142, 22);
            this.CompteRenduConsultation_MenuPrincipalButton.Text = "&Consultation";
            this.CompteRenduConsultation_MenuPrincipalButton.Click += new System.EventHandler(this.CompteRenduConsultation_MenuPrincipalButton_Click);
            // 
            // CompteRenduMAJ_MenuPrincipalButton
            // 
            this.CompteRenduMAJ_MenuPrincipalButton.Name = "CompteRenduMAJ_MenuPrincipalButton";
            this.CompteRenduMAJ_MenuPrincipalButton.Size = new System.Drawing.Size(142, 22);
            this.CompteRenduMAJ_MenuPrincipalButton.Text = "&Mise à jour";
            this.CompteRenduMAJ_MenuPrincipalButton.Click += new System.EventHandler(this.CompteRenduMAJ_MenuPrincipalButton_Click);
            // 
            // JR_FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 643);
            this.Controls.Add(this.msMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuPrincipal;
            this.Name = "JR_FrmPrincipal";
            this.Text = "GSB ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JR_FrmPrincipal_Load);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem Fichier_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem FichierQuitter_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem Visiteur_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem VisiteurConsultation_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem VisiteurMAJ_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem Praticien_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem PraticienConsultation_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem PraticienMAJ_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem CompteRendu_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem CompteRenduConsultation_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem CompteRenduMAJ_MenuPrincipalButton;
        private System.Windows.Forms.ToolStripMenuItem FichierFermer_MenuPrincipalButton;
    }
}


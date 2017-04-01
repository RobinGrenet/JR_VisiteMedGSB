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
            this.PnlFicheDetail = new System.Windows.Forms.Panel();
            this.MCalVisiteur = new System.Windows.Forms.MonthCalendar();
            this.tabMiseAJour = new System.Windows.Forms.TabPage();
            this.tctrlVisiteur.SuspendLayout();
            this.tabConsultation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerVisiteur)).BeginInit();
            this.SplitContainerVisiteur.Panel1.SuspendLayout();
            this.SplitContainerVisiteur.Panel2.SuspendLayout();
            this.SplitContainerVisiteur.SuspendLayout();
            this.GbxListeVisiteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeVisiteur)).BeginInit();
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
            this.GbxListeVisiteur.Text = "Nombre de visiteur : ";
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
            // 
            // PnlFicheDetail
            // 
            this.PnlFicheDetail.Location = new System.Drawing.Point(3, 183);
            this.PnlFicheDetail.Name = "PnlFicheDetail";
            this.PnlFicheDetail.Size = new System.Drawing.Size(612, 399);
            this.PnlFicheDetail.TabIndex = 1;
            // 
            // MCalVisiteur
            // 
            this.MCalVisiteur.Location = new System.Drawing.Point(9, 9);
            this.MCalVisiteur.Name = "MCalVisiteur";
            this.MCalVisiteur.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerVisiteur)).EndInit();
            this.SplitContainerVisiteur.ResumeLayout(false);
            this.GbxListeVisiteur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeVisiteur)).EndInit();
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
    }
}
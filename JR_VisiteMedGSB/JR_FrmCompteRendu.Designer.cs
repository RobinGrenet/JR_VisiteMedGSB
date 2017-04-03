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
            this.SplitContainerCompteRendu = new System.Windows.Forms.SplitContainer();
            this.GbxListeCompteRendu = new System.Windows.Forms.GroupBox();
            this.DtgListeCompteRendu = new System.Windows.Forms.DataGridView();
            this.PnlFicheDetail = new System.Windows.Forms.Panel();
            this.MCalCompteRendu = new System.Windows.Forms.MonthCalendar();
            this.tabMiseAJour = new System.Windows.Forms.TabPage();
            this.tctrlCompteRendu.SuspendLayout();
            this.tabConsultation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerCompteRendu)).BeginInit();
            this.SplitContainerCompteRendu.Panel1.SuspendLayout();
            this.SplitContainerCompteRendu.Panel2.SuspendLayout();
            this.SplitContainerCompteRendu.SuspendLayout();
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
            this.tabConsultation.Controls.Add(this.SplitContainerCompteRendu);
            this.tabConsultation.Location = new System.Drawing.Point(4, 22);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(961, 594);
            this.tabConsultation.TabIndex = 0;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            // 
            // SplitContainerCompteRendu
            // 
            this.SplitContainerCompteRendu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainerCompteRendu.Location = new System.Drawing.Point(6, 5);
            this.SplitContainerCompteRendu.Name = "SplitContainerCompteRendu";
            // 
            // SplitContainerCompteRendu.Panel1
            // 
            this.SplitContainerCompteRendu.Panel1.Controls.Add(this.GbxListeCompteRendu);
            // 
            // SplitContainerCompteRendu.Panel2
            // 
            this.SplitContainerCompteRendu.Panel2.Controls.Add(this.PnlFicheDetail);
            this.SplitContainerCompteRendu.Panel2.Controls.Add(this.MCalCompteRendu);
            this.SplitContainerCompteRendu.Size = new System.Drawing.Size(949, 585);
            this.SplitContainerCompteRendu.SplitterDistance = 351;
            this.SplitContainerCompteRendu.TabIndex = 3;
            // 
            // GbxListeCompteRendu
            // 
            this.GbxListeCompteRendu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxListeCompteRendu.Controls.Add(this.DtgListeCompteRendu);
            this.GbxListeCompteRendu.Location = new System.Drawing.Point(3, 3);
            this.GbxListeCompteRendu.Name = "GbxListeCompteRendu";
            this.GbxListeCompteRendu.Size = new System.Drawing.Size(345, 579);
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
            this.DtgListeCompteRendu.Size = new System.Drawing.Size(333, 554);
            this.DtgListeCompteRendu.TabIndex = 1;
            // 
            // PnlFicheDetail
            // 
            this.PnlFicheDetail.Location = new System.Drawing.Point(3, 183);
            this.PnlFicheDetail.Name = "PnlFicheDetail";
            this.PnlFicheDetail.Size = new System.Drawing.Size(588, 399);
            this.PnlFicheDetail.TabIndex = 1;
            // 
            // MCalCompteRendu
            // 
            this.MCalCompteRendu.Location = new System.Drawing.Point(9, 9);
            this.MCalCompteRendu.Name = "MCalCompteRendu";
            this.MCalCompteRendu.TabIndex = 0;
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
            // JR_FrmCompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 644);
            this.Controls.Add(this.tctrlCompteRendu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JR_FrmCompteRendu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compte-rendus d\'interventions";
            this.Activated += new System.EventHandler(this.JR_FrmCompteRendu_Activated);
            this.Load += new System.EventHandler(this.JR_FrmCompteRendu_Load);
            this.tctrlCompteRendu.ResumeLayout(false);
            this.tabConsultation.ResumeLayout(false);
            this.SplitContainerCompteRendu.Panel1.ResumeLayout(false);
            this.SplitContainerCompteRendu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerCompteRendu)).EndInit();
            this.SplitContainerCompteRendu.ResumeLayout(false);
            this.GbxListeCompteRendu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeCompteRendu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlCompteRendu;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabMiseAJour;
        private System.Windows.Forms.SplitContainer SplitContainerCompteRendu;
        private System.Windows.Forms.GroupBox GbxListeCompteRendu;
        private System.Windows.Forms.DataGridView DtgListeCompteRendu;
        private System.Windows.Forms.Panel PnlFicheDetail;
        private System.Windows.Forms.MonthCalendar MCalCompteRendu;
    }
}
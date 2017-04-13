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
            this.BtnActualiser = new System.Windows.Forms.Button();
            this.MCalCompteRendu = new System.Windows.Forms.MonthCalendar();
            this.GbxListeCompteRendu = new System.Windows.Forms.GroupBox();
            this.DtgListeCompteRendu = new System.Windows.Forms.DataGridView();
            this.tabMiseAJour = new System.Windows.Forms.TabPage();
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
            this.tabConsultation.Controls.Add(this.BtnActualiser);
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
            // BtnActualiser
            // 
            this.BtnActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualiser.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualiser.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualiser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnActualiser.Location = new System.Drawing.Point(722, 520);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.Size = new System.Drawing.Size(227, 59);
            this.BtnActualiser.TabIndex = 2;
            this.BtnActualiser.Text = "Actualiser";
            this.BtnActualiser.UseVisualStyleBackColor = false;
            this.BtnActualiser.Click += new System.EventHandler(this.BtnRafraichir_Click);
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
        private System.Windows.Forms.Button BtnActualiser;
    }
}
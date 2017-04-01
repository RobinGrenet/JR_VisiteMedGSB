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
            this.tabMiseAJour = new System.Windows.Forms.TabPage();
            this.tctrlPracticien.SuspendLayout();
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
            this.tctrlPracticien.Size = new System.Drawing.Size(915, 614);
            this.tctrlPracticien.TabIndex = 0;
            // 
            // tabConsultation
            // 
            this.tabConsultation.Location = new System.Drawing.Point(4, 22);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(907, 588);
            this.tabConsultation.TabIndex = 0;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            // 
            // tabMiseAJour
            // 
            this.tabMiseAJour.Location = new System.Drawing.Point(4, 22);
            this.tabMiseAJour.Name = "tabMiseAJour";
            this.tabMiseAJour.Padding = new System.Windows.Forms.Padding(3);
            this.tabMiseAJour.Size = new System.Drawing.Size(907, 588);
            this.tabMiseAJour.TabIndex = 1;
            this.tabMiseAJour.Text = "Mise à jour";
            this.tabMiseAJour.UseVisualStyleBackColor = true;
            // 
            // JR_FrmPracticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 639);
            this.Controls.Add(this.tctrlPracticien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JR_FrmPracticien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des praticiens";
            this.Activated += new System.EventHandler(this.JR_FrmPracticien_Activated);
            this.Load += new System.EventHandler(this.JR_FrmPracticien_Load);
            this.tctrlPracticien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlPracticien;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabMiseAJour;
    }
}
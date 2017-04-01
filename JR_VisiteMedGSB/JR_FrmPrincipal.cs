using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JR_VisiteMedGSB_ClassLibrary;

namespace JR_VisiteMedGSB
{
    public partial class JR_FrmPrincipal : Form
    {
        #region objet globaux
        internal static String TabFrmVisiteur; //Désigne l'onglet ciblé du formulaire Visiteur
        internal static String TabFrmPraticien; //Désigne l'onglet ciblé du formulaire Praticien
        internal static String TabFrmCompteRendu; //Désigne l'onglet ciblé du formulaire Praticien
        #endregion
        public JR_FrmPrincipal()
        {
            InitializeComponent();
        }

        private void JR_FrmPrincipal_Load(object sender, EventArgs e)
        {
            JR_ProcedureStock.CreerChaineConnexion();
        }

        private void FichierQuitter_MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FichierFermer_MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void VisiteurConsultation_MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            TabFrmVisiteur = "Consultation";
            if (Application.OpenForms["JR_FrmVisiteur"] == null)
            {
                JR_FrmVisiteur FrmVisiteur = new JR_FrmVisiteur();
                FrmVisiteur.MdiParent = this;
                FrmVisiteur.Show();
            }
            else
            {
                Application.OpenForms["JR_FrmVisiteur"].Activate();
            }
        }

        private void VisiteurMAJ_MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            TabFrmVisiteur = "MAJ";
            if (Application.OpenForms["JR_FrmVisiteur"] == null)
            {
                JR_FrmVisiteur FrmVisiteur = new JR_FrmVisiteur();
                FrmVisiteur.MdiParent = this;
                FrmVisiteur.Show();
            }
            else
            {
                Application.OpenForms["JR_FrmVisiteur"].Activate();
            }
        }

        private void PraticienConsultation_MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            TabFrmPraticien = "Consultation";
            if (Application.OpenForms["JR_FrmPracticien"] == null)
            {
                JR_FrmPracticien FrmPraticien = new JR_FrmPracticien();
                FrmPraticien.MdiParent = this;
                FrmPraticien.Show();
            }
            else
            {
                Application.OpenForms["JR_FrmPracticien"].Activate();
            }
        }

        private void PraticienMAJ_MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            TabFrmPraticien = "MAJ";
            if (Application.OpenForms["JR_FrmPracticien"] == null)
            {
                JR_FrmPracticien FrmPraticien = new JR_FrmPracticien();
                FrmPraticien.MdiParent = this;
                FrmPraticien.Show();
            }
            else
            {
                Application.OpenForms["JR_FrmPracticien"].Activate();
            }
        }

        private void CompteRenduConsultation_MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            TabFrmCompteRendu = "Consultation";
            if (Application.OpenForms["JR_FrmCompteRendu"] == null)
            {
                JR_FrmCompteRendu FrmCompteRendu = new JR_FrmCompteRendu();
                FrmCompteRendu.MdiParent = this;
                FrmCompteRendu.Show();
            }
            else
            {
                Application.OpenForms["JR_FrmCompteRendu"].Activate();
            }
        }

        private void CompteRenduMAJ_MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            TabFrmCompteRendu = "MAJ";
            if (Application.OpenForms["JR_FrmCompteRendu"] == null)
            {
                JR_FrmCompteRendu FrmCompteRendu = new JR_FrmCompteRendu();
                FrmCompteRendu.MdiParent = this;
                FrmCompteRendu.Show();
            }
            else
            {
                Application.OpenForms["JR_FrmCompteRendu"].Activate();
            }
        }
    }
}

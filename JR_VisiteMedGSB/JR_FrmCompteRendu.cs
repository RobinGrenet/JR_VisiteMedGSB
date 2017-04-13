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
    public partial class JR_FrmCompteRendu : Form
    {
        public JR_FrmCompteRendu()
        {
            InitializeComponent();
        }

        private void JR_FrmCompteRendu_Load(object sender, EventArgs e)
        {
            #region Modification de propriété
            JR_GestionForm.ModificationProprieteCommune(this);
            #endregion

            #region Sélection de l'onglet actif
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmCompteRendu, tctrlCompteRendu);
            #endregion

            #region Mise en forme de la DataGridView
            DtgListeCompteRendu.MiseEnForme();
            #endregion

            #region Chargement de la DtgListeCompteRendu
            String erreur;

            try
            {
                JR_ProcedureStock.connexionBD(out erreur);
                DtgListeCompteRendu.DataSource = JR_ProcedureStock.ExecToDatatable("PS_ListeCompteRendu", ref erreur);
            }
            finally
            {
                JR_ProcedureStock.deconnexionBD();
            }

            if (erreur != null)
            {
                MessageBox.Show(erreur, "Erreur lors de la récupération des comptes rendus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Affichage du nombre de rapports dans la GroupBox
            GbxListeCompteRendu.Text = "Nombre de rapports : " + DtgListeCompteRendu.RowCount;
            #endregion
        }

        private void JR_FrmCompteRendu_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmCompteRendu, tctrlCompteRendu);
        }

        private void MCalCompteRendu_DateChanged(object sender, DateRangeEventArgs e)
        {
            String erreur;
            KeyValuePair<String, DateTime> paramDateDebut = new KeyValuePair<string, DateTime>("DateDebut", e.Start);
            KeyValuePair<String, DateTime> paramDateFin = new KeyValuePair<string, DateTime>("DateFin", e.End);
            try
            {
                JR_ProcedureStock.connexionBD(out erreur);
                DtgListeCompteRendu.DataSource = JR_ProcedureStock.ExecToDatatable("PS_ListeCompteRenduDate", paramDateDebut, paramDateFin, ref erreur);
            }
            finally
            {
                JR_ProcedureStock.deconnexionBD();
            }

            if (erreur != null)
            {
                MessageBox.Show(erreur, "Erreur de récupération des comptes rendus entre le " + e.Start.ToString("dd/MM/yyyy") + " et le " + e.End.ToString("dd/MM/yyyy"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DtgListeCompteRendu_DataSourceChanged(object sender, EventArgs e)
        {
            GbxListeCompteRendu.Text = "Nombre de rapports : " + DtgListeCompteRendu.RowCount;
        }

        private void BtnRafraichir_Click(object sender, EventArgs e)
        {
            #region Chargement de la DtgListeCompteRendu
            String erreur;

            try
            {
                JR_ProcedureStock.connexionBD(out erreur);
                DtgListeCompteRendu.DataSource = JR_ProcedureStock.ExecToDatatable("PS_ListeCompteRendu", ref erreur);
            }
            finally
            {
                JR_ProcedureStock.deconnexionBD();
            }

            if (erreur != null)
            {
                MessageBox.Show(erreur, "Erreur lors de la récupération des comptes rendus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion
        }
    }
}

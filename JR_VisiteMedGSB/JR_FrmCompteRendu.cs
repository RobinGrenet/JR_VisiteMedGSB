using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        #region Objets globaux
        CancellationTokenSource sourceJetonAnnulation;
        Int32 compteurChargementActifConsultation = 0;
        #endregion

        #region Méthodes
        private async Task ChargeListeRapportAsync()
        {
            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste des rapports...", ref compteurChargementActifConsultation);
            LblErreur.Visible = false;

            try
            {
                DtgListeCompteRendu.DataSource = await JR_ProcedureStock.ExecToDatatableAsync("PS_ListeCompteRendu", sourceJetonAnnulation.Token);
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                LblErreur.Text = ex.Message;
                LblErreur.Visible = true;
            }
            finally
            {
                JR_GestionForm.FinChargement(IndicateurProgression, BtnAnnuler, LblChargement, ref compteurChargementActifConsultation);
            }
        }

        private async Task ChargeListeRapportAsync(params SqlParameter[] argsProc)
        {
            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste des rapports...", ref compteurChargementActifConsultation);
            LblErreur.Visible = false;

            try
            {
                DtgListeCompteRendu.DataSource = await JR_ProcedureStock.ExecToDatatableAsync("PS_ListeCompteRenduDate", sourceJetonAnnulation.Token, argsProc);
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                LblErreur.Text = ex.Message;
                LblErreur.Visible = true;
            }
            finally
            {
                JR_GestionForm.FinChargement(IndicateurProgression, BtnAnnuler, LblChargement, ref compteurChargementActifConsultation);
            }
        }
        #endregion

        #region Procédures évènementielles
        private async void JR_FrmCompteRendu_Load(object sender, EventArgs e)
        {
            #region Lancement de la tache de chargement
            sourceJetonAnnulation = new CancellationTokenSource();
            Task<DataTable> tacheChargementRapport = JR_ProcedureStock.ExecToDatatableAsync("PS_ListeCompteRendu", sourceJetonAnnulation.Token); 
            #endregion

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
            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste des rapports...", ref compteurChargementActifConsultation);
            try
            {
                DtgListeCompteRendu.DataSource = await tacheChargementRapport;
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                LblErreur.Text = ex.Message;
                LblErreur.Visible = true;
            }
            finally
            {
                JR_GestionForm.FinChargement(IndicateurProgression, BtnAnnuler, LblChargement, ref compteurChargementActifConsultation);
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

        private async void MCalCompteRendu_DateChanged(object sender, DateRangeEventArgs e)
        {
            SqlParameter paramDateDebut = new SqlParameter("DateDebut", SqlDbType.Date);
            SqlParameter paramDateFin = new SqlParameter("DateFin", SqlDbType.Date);
            paramDateDebut.Value = e.Start;
            paramDateFin.Value = e.End;

            await ChargeListeRapportAsync(paramDateDebut, paramDateFin);
        }

        private void DtgListeCompteRendu_DataSourceChanged(object sender, EventArgs e)
        {
            GbxListeCompteRendu.Text = "Nombre de rapports : " + DtgListeCompteRendu.RowCount;
        }

        private async void BtnRafraichir_Click(object sender, EventArgs e)
        {
            await ChargeListeRapportAsync();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            sourceJetonAnnulation.Cancel();
        }
        #endregion
    }
}

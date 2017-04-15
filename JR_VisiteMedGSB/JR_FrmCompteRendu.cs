using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #endregion

        #region Mes méthodes
        private async Task ChargeListeRapportAsync()
        {
            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgressionVisiteur, BtnAnnuler, LblChargement, "Chargement de la liste des rapports...");
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
                JR_GestionForm.FinChargement(IndicateurProgressionVisiteur, BtnAnnuler, LblChargement);
            }
        }

        private async Task ChargeListeRapportAsync(KeyValuePair<String, DateTime> paramDateDebut, KeyValuePair<String, DateTime> paramDateFin)
        {
            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgressionVisiteur, BtnAnnuler, LblChargement, "Chargement de la liste des rapports...");
            LblErreur.Visible = false;

            try
            {
                DtgListeCompteRendu.DataSource = await JR_ProcedureStock.ExecToDatatableAsync("PS_ListeCompteRenduDate", paramDateDebut, paramDateFin, sourceJetonAnnulation.Token);
            }
            catch (OperationCanceledException ex)
            {
            }
            catch (Exception ex)
            {
                LblErreur.Text = ex.Message;
                LblErreur.Visible = true;
            }
            finally
            {
                JR_GestionForm.FinChargement(IndicateurProgressionVisiteur, BtnAnnuler, LblChargement);
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
            JR_GestionForm.DebutChargement(IndicateurProgressionVisiteur, BtnAnnuler, LblChargement, "Chargement de la liste des rapports...");
            try
            {
                DtgListeCompteRendu.DataSource = await tacheChargementRapport;
            }
            catch (OperationCanceledException ex)
            {
            }
            catch (Exception ex)
            {
                LblErreur.Text = ex.Message;
                LblErreur.Visible = true;
            }
            finally
            {
                JR_GestionForm.FinChargement(IndicateurProgressionVisiteur, BtnAnnuler, LblChargement);
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
            KeyValuePair<String, DateTime> paramDateDebut = new KeyValuePair<String, DateTime>("DateDebut", e.Start);
            KeyValuePair<String, DateTime> paramDateFin = new KeyValuePair<String, DateTime>("DateFin", e.End);

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

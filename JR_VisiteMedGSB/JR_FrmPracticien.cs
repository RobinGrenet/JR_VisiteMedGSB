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
using System.Threading;
using System.Data.SqlClient;

namespace JR_VisiteMedGSB
{
    public partial class JR_FrmPracticien : Form
    {
        public JR_FrmPracticien()
        {
            InitializeComponent();
        }

        #region objets globaux
        CancellationTokenSource sourceJetonAnnulation;
        Int32 compteurChargementActifConsultation = 0;
        #endregion

        #region Méthodes
        private async Task ChargeListePraticienAsync()
        {
            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste praticiens...", ref compteurChargementActifConsultation);
            LblErreur.Visible = false;

            try
            {
                DtgListePraticien.DataSource = await JR_ProcedureStock.ExecToDatatableAsync("PS_ListePraticien", sourceJetonAnnulation.Token);
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

        private async Task ChargeListePraticienAsync(Object codeFonction)
        {
            SqlParameter paramCodeFonction = new SqlParameter("codeFonction", SqlDbType.Char, 3);
            paramCodeFonction.Value = codeFonction;

            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste des praticiens...", ref compteurChargementActifConsultation);
            LblErreur.Visible = false;

            try
            {
                DtgListePraticien.DataSource = await JR_ProcedureStock.ExecToDatatableAsync("PS_ListeTypePraticien", sourceJetonAnnulation.Token, paramCodeFonction);
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

        private async Task ChargeDetailPraticienAsync(Object numPraticien)
        {
            DataTable dtDetailPraticien = null;

            SqlParameter paramNumPraticien = new SqlParameter("numPraticien", SqlDbType.Int);
            paramNumPraticien.Value = numPraticien;

            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement des détail du praticien...", ref compteurChargementActifConsultation);
            LblErreur.Visible = false;

            try
            {
                dtDetailPraticien = await JR_ProcedureStock.ExecToDatatableAsync("PS_DetailPraticien", sourceJetonAnnulation.Token, paramNumPraticien);
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

            if (dtDetailPraticien != null)
            {
                LblAdresse.Text = dtDetailPraticien.Rows[0].Field<String>("Adresse");
                LblCP.Text = dtDetailPraticien.Rows[0].Field<String>("CP");
                LblVille.Text = dtDetailPraticien.Rows[0].Field<String>("Ville");
            }
        }
        #endregion

        #region Procédures évènementielles
        private async void JR_FrmPracticien_Load(object sender, EventArgs e)
        {
            #region Lancement de la tache de chargement de la liste des praticiens et de leurs fonctions
            sourceJetonAnnulation = new CancellationTokenSource();
            Task<DataTable> tacheChargementFonction = JR_ProcedureStock.ExecToDatatableAsync("PS_ListeFonctionPracticien", sourceJetonAnnulation.Token);
            Task<DataTable> tacheChargementPraticien = JR_ProcedureStock.ExecToDatatableAsync("PS_ListePraticien", sourceJetonAnnulation.Token);
            #endregion

            #region Modification de propriété
            JR_GestionForm.ModificationProprieteCommune(this);
            #endregion

            #region Sélection de l'onglet actif
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmPraticien, tctrlPracticien);
            #endregion

            #region Mise en forme de la DataGridView
            DtgListePraticien.MiseEnForme();
            #endregion

            #region Chargement de la liste des praticiens et de leurs fonctions
            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste des fonctions des praticiens...", ref compteurChargementActifConsultation);
            try
            {
                LbxFonctionPracticien.DataSource = await tacheChargementFonction;
                LbxFonctionPracticien.DisplayMember = "Libellé";
                LbxFonctionPracticien.ValueMember = "Code";

                LblChargement.Text = "Chargement de la liste des praticiens...";
                DtgListePraticien.DataSource = await tacheChargementPraticien;
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
        }

        private void JR_FrmPracticien_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmPraticien, tctrlPracticien);
        }

        private void DtgListePraticien_DataSourceChanged(object sender, EventArgs e)
        {
            GbxListePraticien.Text = "Nombre de praticiens : " + DtgListePraticien.RowCount;
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            sourceJetonAnnulation.Cancel();
        }

        private async void DtgListePraticien_SelectionChanged(object sender, EventArgs e)
        {
            await ChargeDetailPraticienAsync(DtgListePraticien.CurrentRow.Cells[0].Value);
        }

        private async void BtnToutAfficher_Click(object sender, EventArgs e)
        {
            await ChargeListePraticienAsync();
        }

        private async void LbxFonctionPracticien_SelectedValueChanged(object sender, EventArgs e)
        {
            await ChargeListePraticienAsync(LbxFonctionPracticien.SelectedValue);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JR_VisiteMedGSB_ClassLibrary;
using System.Threading;

namespace JR_VisiteMedGSB
{
    public partial class JR_FrmVisiteur : Form
    {
        public JR_FrmVisiteur()
        {
            InitializeComponent();
        }

        #region objets globaux
        Int32 compteurChargementActifConsultation = 0;
        Int32 compteurChargementActifModification = 0;
        CancellationTokenSource sourceJetonAnnulation;
        CancellationTokenSource sourceJetonAnnulationModif;
        #endregion

        #region Méthodes
        private async Task ChargeListeVisiteurAsync()
        {
            DataTable dtListeVisiteur = null;

            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste visiteurs...", ref compteurChargementActifConsultation);
            LblErreur.Visible = false;

            try
            {
                dtListeVisiteur = await JR_ProcedureStock.ExecToDatatableAsync("PS_ListeVisiteur", sourceJetonAnnulation.Token);
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

            if (dtListeVisiteur != null)
            {
                DtgListeVisiteur.DataSource = dtListeVisiteur;
                DtgListeVisiteurModif.DataSource = dtListeVisiteur;
            }
        }

        private async Task ChargeListeVisiteurAsync(DateTime dateDebut, DateTime dateFin)
        {
            DataTable dtListeVisiteur = null;

            SqlParameter paramDateDebut = new SqlParameter("dateDebut", SqlDbType.Date);
            SqlParameter paramDateFin = new SqlParameter("dateFin", SqlDbType.Date);
            paramDateDebut.Value = dateDebut;
            paramDateFin.Value = dateFin;

            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste visiteurs...", ref compteurChargementActifConsultation);
            LblErreur.Visible = false;

            try
            {
                dtListeVisiteur = await JR_ProcedureStock.ExecToDatatableAsync("PS_ListeVisiteurDate", sourceJetonAnnulation.Token, paramDateDebut, paramDateFin);
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
            if (dtListeVisiteur != null)
            {
                DtgListeVisiteur.DataSource = dtListeVisiteur;
                DtgListeVisiteurModif.DataSource = dtListeVisiteur;
            }
        }

        private async Task ChargeDetailVisiteurAsync(String numVisiteur)
        {
            DataTable dtDetailVisiteur = null;

            SqlParameter paramNumVisiteur = new SqlParameter("numVisiteur", SqlDbType.Char, 4);
            paramNumVisiteur.Value = numVisiteur;

            if (sourceJetonAnnulation != null)
            {
                sourceJetonAnnulation.Cancel();
            }
            sourceJetonAnnulation = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement des détail du visiteur...", ref compteurChargementActifConsultation);
            LblErreur.Visible = false;

            try
            {
                dtDetailVisiteur = await JR_ProcedureStock.ExecToDatatableAsync("PS_DetailVisiteur", sourceJetonAnnulation.Token, paramNumVisiteur);
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

            if (dtDetailVisiteur != null)
            {
                LblAdresse.Text = dtDetailVisiteur.Rows[0].Field<String>("Adresse");
                LblCP.Text = dtDetailVisiteur.Rows[0].Field<String>("CP");
                LblVille.Text = dtDetailVisiteur.Rows[0].Field<String>("Ville");
            }
        }

        private async Task ChargeListeVisiteurModifAsync()
        {
            if (sourceJetonAnnulationModif != null)
            {
                sourceJetonAnnulationModif.Cancel();
            }
            sourceJetonAnnulationModif = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgressionModif, BtnAnnulerModif, LblChargementModif, "Chargement de la liste visiteurs...", ref compteurChargementActifModification);
            LblErreurModif.Visible = false;

            try
            {
                DtgListeVisiteurModif.DataSource = await JR_ProcedureStock.ExecToDatatableAsync("PS_ListeVisiteur", sourceJetonAnnulationModif.Token);
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                LblErreurModif.Text = ex.Message;
                LblErreurModif.Visible = true;
            }
            finally
            {
                JR_GestionForm.FinChargement(IndicateurProgressionModif, BtnAnnulerModif, LblChargementModif, ref compteurChargementActifModification);
            }
        }

        private async Task ChargeDetailVisiteurModifAsync(String numVisiteur)
        {
            DataTable dtDetailVisiteurModif = null;

            SqlParameter paramNumVisiteur = new SqlParameter("numVisiteur", SqlDbType.Char, 4);
            paramNumVisiteur.Value = numVisiteur;

            if (sourceJetonAnnulationModif != null)
            {
                sourceJetonAnnulationModif.Cancel();
            }
            sourceJetonAnnulationModif = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgressionModif, BtnAnnulerModif, LblChargementModif, "Chargement de la liste visiteurs...", ref compteurChargementActifModification);
            LblErreurModif.Visible = false;

            try
            {
                dtDetailVisiteurModif = await JR_ProcedureStock.ExecToDatatableAsync("PS_DetailVisiteurModif", sourceJetonAnnulationModif.Token, paramNumVisiteur);
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                LblErreurModif.Text = ex.Message;
                LblErreurModif.Visible = true;
            }
            finally
            {
                JR_GestionForm.FinChargement(IndicateurProgressionModif, BtnAnnulerModif, LblChargementModif, ref compteurChargementActifModification);
            }

            if (dtDetailVisiteurModif != null)
            {
                TbxMatriculeModif.Text = dtDetailVisiteurModif.Rows[0].Field<String>("Matricule");
                TbxNomModif.Text = dtDetailVisiteurModif.Rows[0].Field<String>("Nom");
                TbxPrenomModif.Text = dtDetailVisiteurModif.Rows[0].Field<String>("Prénom");
                TbxAdresseModif.Text = dtDetailVisiteurModif.Rows[0].Field<String>("Adresse");
                TbxCPModif.Text = dtDetailVisiteurModif.Rows[0].Field<String>("CP");
                TbxVilleModif.Text = dtDetailVisiteurModif.Rows[0].Field<String>("Ville");
                DtpDateEmbauche.Value = dtDetailVisiteurModif.Rows[0].Field<DateTime>("DateEmbauche");
            }
        }

        private async Task ModifierVisiteur(String matricule, String nom, String prenom, String adresse, String CP, String ville, DateTime dateEmbauche)
        {
            SqlParameter paramMatricule = new SqlParameter("matricule", SqlDbType.Char, 4);
            SqlParameter paramNom = new SqlParameter("nom", SqlDbType.VarChar, 25);
            SqlParameter paramPrenom = new SqlParameter("prenom", SqlDbType.VarChar, 50);
            SqlParameter paramAdresse = new SqlParameter("adresse", SqlDbType.VarChar, 50);
            SqlParameter paramCP = new SqlParameter("CP", SqlDbType.Char, 5);
            SqlParameter paramVille = new SqlParameter("ville", SqlDbType.VarChar, 30);
            SqlParameter paramDateEmbauche = new SqlParameter("dateEmbauche", SqlDbType.Date);
            
            paramMatricule.Value = matricule;
            paramNom.Value = nom;
            paramPrenom.Value = prenom;
            paramAdresse.Value = adresse;
            paramCP.Value = CP;
            paramVille.Value = ville;
            paramDateEmbauche.Value = dateEmbauche;

            if (sourceJetonAnnulationModif != null)
            {
                sourceJetonAnnulationModif.Cancel();
            }
            sourceJetonAnnulationModif = new CancellationTokenSource();

            JR_GestionForm.DebutChargement(IndicateurProgressionModif, BtnAnnulerModif, LblChargementModif, "Modification du visiteur " + nom + " " + prenom + "...", ref compteurChargementActifModification);
            LblErreurModif.Visible = false;

            try
            {
                await JR_ProcedureStock.ExecAsync("PS_ModifierVisiteur", sourceJetonAnnulationModif.Token, paramMatricule, paramNom, paramPrenom, paramAdresse, paramCP, paramVille, paramDateEmbauche);
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                LblErreurModif.Text = ex.Message;
                LblErreurModif.Visible = true;
            }
            finally
            {
                JR_GestionForm.FinChargement(IndicateurProgressionModif, BtnAnnulerModif, LblChargementModif, ref compteurChargementActifModification);
            }
        }
        #endregion

        #region Procédures évènementielles
        private async void JR_FrmVisiteur_Load(object sender, EventArgs e)
        {
            #region Lancement de la tache de chargement
            sourceJetonAnnulation = new CancellationTokenSource();
            Task<DataTable> tacheChargementVisiteur = JR_ProcedureStock.ExecToDatatableAsync("PS_ListeVisiteur", sourceJetonAnnulation.Token);
            #endregion

            #region Modification de propriété
            JR_GestionForm.ModificationProprieteCommune(this);
            #endregion

            #region sélection de l'onglet actif
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmVisiteur, tctrlVisiteur);
            #endregion

            #region Mise en forme de la DataGridView
            DtgListeVisiteur.MiseEnForme();
            DtgListeVisiteurModif.MiseEnForme();
            #endregion

            #region Chargement de la liste des visiteurs
            JR_GestionForm.DebutChargement(IndicateurProgression, BtnAnnuler, LblChargement, "Chargement de la liste des visiteurs...", ref compteurChargementActifModification);
            DataTable dtListeVisiteur = null;
            try
            {
                dtListeVisiteur = await tacheChargementVisiteur;
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
                JR_GestionForm.FinChargement(IndicateurProgression, BtnAnnuler, LblChargement, ref compteurChargementActifModification);
            }
            if (dtListeVisiteur != null)
            {
                DtgListeVisiteur.DataSource = dtListeVisiteur;
                DtgListeVisiteurModif.DataSource = dtListeVisiteur;
            }
            #endregion
        }

        private void JR_FrmVisiteur_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmVisiteur, tctrlVisiteur);
        }

        private void DtgListeVisiteur_DataSourceChanged(object sender, EventArgs e)
        {
            GbxListeVisiteur.Text = "Nombre de visiteurs : " + DtgListeVisiteur.RowCount;
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            sourceJetonAnnulation.Cancel();
        }

        private async void DtgListeVisiteur_SelectionChanged(object sender, EventArgs e)
        {
            await ChargeDetailVisiteurAsync(DtgListeVisiteur.CurrentRow.Cells["Numéro"].Value.ToString());
        }

        private async void BtnToutAfficher_Click(object sender, EventArgs e)
        {
            await ChargeListeVisiteurAsync();
        }

        private async void MCalVisiteur_DateChanged(object sender, DateRangeEventArgs e)
        {
            await ChargeListeVisiteurAsync(e.Start, e.End);
        }

        private async void DtgListeVisiteurModif_SelectionChanged(object sender, EventArgs e)
        {
            await ChargeDetailVisiteurModifAsync(DtgListeVisiteurModif.CurrentRow.Cells["Numéro"].Value.ToString());
        }

        private void BtnAnnulerModif_Click(object sender, EventArgs e)
        {
            sourceJetonAnnulationModif.Cancel();
        }
        #endregion

        private async void BtnModifier_Click(object sender, EventArgs e)
        {
            await ModifierVisiteur(TbxMatriculeModif.Text, TbxNomModif.Text, TbxPrenomModif.Text, TbxAdresseModif.Text, TbxCPModif.Text, TbxVilleModif.Text, DtpDateEmbauche.Value);
            await ChargeListeVisiteurAsync();
        }
    }
}

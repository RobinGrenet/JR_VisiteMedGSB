using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace JR_VisiteMedGSB_ClassLibrary
{
    public static class JR_ProcedureStock
    {
        #region Attributs
        private static SqlConnection connexion;
        #endregion

        #region Méthodes
        public static void CreerChaineConnexion()
        {
            // Fichier de configuration
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Construit la chaîne de connexion
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder
            {
                DataSource = Environment.MachineName,
                InitialCatalog = "VisiteMedGSB",
                UserID = "sa",
                Password = "info"
            };

            // Ajoute le chaîne de connexion au fichier de configuration
            config.ConnectionStrings.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString = sqlBuilder.ConnectionString;

            // Enregistre la configuration
            config.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static Boolean connexionBD()
        {
            if (JR_ProcedureStock.connexion == null)
            {
                JR_ProcedureStock.connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString);
            }
            JR_ProcedureStock.connexion.Open();
            return JR_ProcedureStock.connexion.State == ConnectionState.Open;
        }

        public static Boolean connexionBD(out String erreur)
        {
            erreur = null;
            if (JR_ProcedureStock.connexion == null)
            {
                JR_ProcedureStock.connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString);
            }
            try
            {
                JR_ProcedureStock.connexion.Open();
            }
            catch (SqlException e)
            {
                erreur = e.Message;
            }

            return JR_ProcedureStock.connexion.State == ConnectionState.Open;
        }

        public static void deconnexionBD()
        {
            if (JR_ProcedureStock.connexion != null)
            {
                JR_ProcedureStock.connexion.Close();
            }
        }

        public static DataTable ExecToDatatable(String nomProc)
        {
            DataTable dtResultat = new DataTable();
            if (JR_ProcedureStock.connexion.State == ConnectionState.Open)
            {
                using (SqlCommand commande = new SqlCommand(nomProc, JR_ProcedureStock.connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = commande.ExecuteReader())
                    {
                        dtResultat.Load(reader);
                    }
                }
            }
            return dtResultat;
        }

        public static DataTable ExecToDatatable(String nomProc, ref String erreur)
        {
            DataTable dtResultat = new DataTable();
            if (JR_ProcedureStock.connexion.State == ConnectionState.Open)
            {
                using (SqlCommand commande = new SqlCommand(nomProc, JR_ProcedureStock.connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        using (SqlDataReader reader = commande.ExecuteReader())
                        {
                            dtResultat.Load(reader);
                        }
                    }
                    catch (SqlException e)
                    {
                        if (erreur == null)
                        {
                            erreur = e.Message;
                        }
                        else
                        {
                            erreur += "\n" + e.Message;
                        }
                    }
                }
            }
            return dtResultat;
        }

        public static DataTable ExecToDatatable(String nomProc, KeyValuePair<String, DateTime> dateDebut, KeyValuePair<String, DateTime> dateFin, ref String erreur)
        {
            DataTable dtResultat = new DataTable();
            if (JR_ProcedureStock.connexion.State == ConnectionState.Open)
            {
                using (SqlCommand commande = new SqlCommand(nomProc, JR_ProcedureStock.connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;
                    commande.Parameters.Add(dateDebut.Key, SqlDbType.Date).Value = dateDebut.Value;
                    commande.Parameters.Add(dateFin.Key, SqlDbType.Date).Value = dateFin.Value;
                    try
                    {
                        using (SqlDataReader reader = commande.ExecuteReader())
                        {
                            dtResultat.Load(reader);
                        }
                    }
                    catch (SqlException e)
                    {
                        if (erreur == null)
                        {
                            erreur = e.Message;
                        }
                        else
                        {
                            erreur += "\n" + e.Message;
                        }
                    }
                }
            }
            return dtResultat;
        }

        public static String ExecScalar(String nomProc)
        {
            String resultat = String.Empty;
            if (JR_ProcedureStock.connexion.State == ConnectionState.Open)
            {
                using (SqlCommand commande = new SqlCommand(nomProc, JR_ProcedureStock.connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;
                    resultat = commande.ExecuteScalar().ToString();
                }
            }
            return resultat;
        }

        public static String ExecScalar(String nomProc, ref String erreur)
        {
            String resultat = String.Empty;
            if (JR_ProcedureStock.connexion.State == ConnectionState.Open)
            {
                using (SqlCommand commande = new SqlCommand(nomProc, JR_ProcedureStock.connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        resultat = commande.ExecuteScalar().ToString();
                    }
                    catch (SqlException e)
                    {
                        if (erreur == null)
                        {
                            erreur = e.Message;
                        }
                        else
                        {
                            erreur += "\n" + e.Message;
                        }
                    }
                }
            }
            return resultat;
        }

        public static int Exec(String nomProc)
        {
            int nbLignes = 0;
            if (JR_ProcedureStock.connexion.State == ConnectionState.Open)
            {
                using (SqlCommand commande = new SqlCommand(nomProc, JR_ProcedureStock.connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;
                    nbLignes = commande.ExecuteNonQuery();
                }
            }
            return nbLignes;
        } 
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace JR_VisiteMedGSB_ClassLibrary
{
    public static class JR_ProcedureStock
    {
        #region Messages d'erreur
        private const String erreurRequete = "Erreur lors de l'exécution de la requête : ";
        private const String erreurConnexion = "Erreur lors de la connexion au serveur de base de données : "; 
        #endregion

        /// <summary>
        /// Créé la chaîne de connexion pour SQL Server et enregistre la chaîne dans le fichier de configuration
        /// </summary>
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

        /// <summary>
        /// Exécute la procédure stockée en lui passant les arguments fournis et retoune le résultat dans une DataTable
        /// </summary>
        /// <param name="nomProc">le nom de la procédure stockée</param>
        /// <param name="argsProc">zero ou plusieurs arguments à passer à la procédure stockée</param>
        /// <returns></returns>
        public static DataTable ExecToDatatable(String nomProc, params SqlParameter[] argsProc)
        {
            DataTable dtResultat = new DataTable();
            using (SqlConnection connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString))
            using (SqlCommand commande = new SqlCommand(nomProc, connexion))
            {
                commande.CommandType = CommandType.StoredProcedure;
                foreach (var param in argsProc)
                {
                    commande.Parameters.Add(param);
                }
                try
                {
                    connexion.Open();
                    try
                    {
                        using (SqlDataReader reader = commande.ExecuteReader())
                        {
                            dtResultat.Load(reader);
                        }
                    }
                    catch (SqlException e)
                    {
                        throw new Exception(erreurRequete + e.Message, e);
                    }
                }
                catch (SqlException e)
                {
                    throw new Exception(erreurConnexion + e.Message, e);
                }
            }
            return dtResultat;
        }

        /// <summary>
        /// Une version asynchrone de ExecToDatatable() qui exécute la procédure stockée et retoune le résultat dans une DataTable, en passant en argument la date de début et de fin
        /// </summary>
        /// <param name="nomProc">le nom de la procédure stockée</param>
        /// <param name="jetonAnnulation">le jeton d'annulation</param>
        /// <param name="argsProc">zero ou plusieurs arguments à passer à la procédure stockée</param>
        /// <returns>une tâche pouvant être attendue contenant une DataTable</returns>
        public async static Task<DataTable> ExecToDatatableAsync(String nomProc, CancellationToken jetonAnnulation = new CancellationToken(), params SqlParameter[] argsProc)
        {
            jetonAnnulation.ThrowIfCancellationRequested();

            DataTable dtResultat = new DataTable();
            using (SqlConnection connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString))
            using (SqlCommand commande = new SqlCommand(nomProc, connexion))
            {
                commande.CommandType = CommandType.StoredProcedure;
                foreach (var param in argsProc)
                {
                    commande.Parameters.Add(param);
                }
                try
                {
                    await connexion.OpenAsync(jetonAnnulation);
                    try
                    {
                        using (SqlDataReader reader = await commande.ExecuteReaderAsync(jetonAnnulation))
                        {
                            await Task.Run(() => dtResultat.Load(reader), jetonAnnulation);
                        }
                    }
                    catch (SqlException e)
                    {
                        throw new Exception(erreurRequete + e.Message, e);
                    }
                }
                catch (SqlException e)
                {
                    throw new Exception(erreurConnexion + e.Message, e);
                }
            }
            return dtResultat;
        }
        
        /// <summary>
        /// Exécute la procédure stockée et retourne un résultat unique
        /// </summary>
        /// <param name="nomProc">le nom de la procédure stockée</param>
        /// <returns>un objet contenant le résultat de la requête</returns>
        public static Object ExecScalar(String nomProc)
        {
            Object resultat = new Object();
            using (SqlConnection connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString))
            using (SqlCommand commande = new SqlCommand(nomProc, connexion))
            {
                commande.CommandType = CommandType.StoredProcedure;
                try
                {
                    connexion.Open();
                    try
                    {
                        resultat = commande.ExecuteScalar();
                    }
                    catch (SqlException e)
                    {
                        throw new Exception(erreurRequete + e.Message, e);
                    }
                }
                catch (SqlException e)
                {
                    throw new Exception(erreurConnexion + e.Message, e);
                }
            }
            return resultat;
        }

        /// <summary>
        /// Une version asynchrone de ExecScalar qui exécute la procédure stockée et retourne un résultat unique
        /// </summary>
        /// <param name="nomProc">le nom de la procédure stockée</param>
        /// <returns>une tâche pouvant être attendue contenant un objet</returns>
        public async static Task<Object> ExecScalarAsync(String nomProc)
        {
            Object resultat = new Object();
            using (SqlConnection connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString))
            using (SqlCommand commande = new SqlCommand(nomProc, connexion))
            {
                commande.CommandType = CommandType.StoredProcedure;
                try
                {
                    await connexion.OpenAsync();
                    try
                    {
                        resultat = await commande.ExecuteScalarAsync();
                    }
                    catch (SqlException e)
                    {
                        throw new Exception(erreurRequete + e.Message, e);
                    }
                }
                catch (SqlException e)
                {
                    throw new Exception(erreurConnexion + e.Message, e);
                }
            }
            return resultat;
        }

        /// <summary>
        /// Exécute la procédure stockée et retourne le nombre de lignes affectées
        /// </summary>
        /// <param name="nomProc">le nom de la procédure stockée</param>
        /// <returns>le nombre de lignes affectées</returns>
        public static int Exec(String nomProc, params SqlParameter[] argsProc)
        {
            int nbLignes = 0;
            using (SqlConnection connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString))
            using (SqlCommand commande = new SqlCommand(nomProc, connexion))
            {
                commande.CommandType = CommandType.StoredProcedure;
                try
                {
                    connexion.Open();
                    try
                    {
                        nbLignes = commande.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        throw new Exception(erreurRequete + e.Message, e);
                    }
                }
                catch (SqlException e)
                {
                    throw new Exception(erreurConnexion + e.Message, e);
                }
            }
            return nbLignes;
        }

        /// <summary>
        /// Une version asynchrone de Exec qui exécute la procédure stockée et retourne le nombre de lignes affectées
        /// </summary>
        /// <param name="nomProc">le nom de la procédure stockée</param>
        /// <returns>une tâche pouvant être attendue contenant un entier</returns>
        public async static Task<int> ExecAsync(String nomProc, CancellationToken jetonAnnulation = new CancellationToken(), params SqlParameter[] argsProc)
        {
            jetonAnnulation.ThrowIfCancellationRequested();

            int nbLignes = 0;

            using (SqlConnection connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_VisiteMedGSB"].ConnectionString))
            using (SqlCommand commande = new SqlCommand(nomProc, connexion))
            {
                commande.CommandType = CommandType.StoredProcedure;
                foreach (var param in argsProc)
                {
                    commande.Parameters.Add(param);
                }
                try
                {
                    await connexion.OpenAsync(jetonAnnulation);
                    try
                    {
                        nbLignes = await commande.ExecuteNonQueryAsync(jetonAnnulation);
                    }
                    catch (SqlException e)
                    {
                        throw new Exception(erreurRequete + e.Message, e);
                    }
                }
                catch (SqlException e)
                {
                    throw new Exception(erreurConnexion + e.Message, e);
                }
            }
            return nbLignes;
        }
    }
}

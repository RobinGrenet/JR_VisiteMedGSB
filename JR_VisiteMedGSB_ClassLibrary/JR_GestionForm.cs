using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JR_VisiteMedGSB_ClassLibrary
{
    public static class JR_GestionForm
    {
        /// <summary>
        /// Permet la sélection de l'onglet cible dans le formulaire enfant sélectionné
        /// </summary>
        /// <param name="OngletCible">Paramètre de sélection de l'onglet</param>
        /// <param name="TabControlCible">Nom du controle contenant l'onglet</param>
        public static void SelectionOngletActif(String OngletCible, TabControl TabControlCible)
        {
            switch (OngletCible)
            {
                case "Consultation":
                    TabControlCible.SelectedIndex = 0;
                    break;
                case "MAJ":
                    TabControlCible.SelectedIndex = 1;
                    break;
                default:
                    TabControlCible.SelectedIndex = 0;
                    break;
            }
        }
        /// <summary>
        /// Permet la modification des propriétés communes aux formulaires enfants
        /// </summary>
        /// <param name="FormulaireCible">Formulaire enfant dont on modifie les propriétés</param>
        public static void ModificationProprieteCommune(Form FormulaireCible)
        {
            FormulaireCible.MaximizeBox = false;
            FormulaireCible.MinimizeBox = false;
            FormulaireCible.ControlBox = false;
            FormulaireCible.ShowIcon = false;
            FormulaireCible.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Permet la mise en forme de la DataGridView
        /// </summary>
        /// <param name="dataGrid"></param>
        public static void MiseEnForme(this DataGridView dataGrid)
        {
            DataGridViewCellStyle alternatingRowsCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle columnHeaderCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle RowsCellStyle = new DataGridViewCellStyle();

            alternatingRowsCellStyle.BackColor = Color.WhiteSmoke;
            alternatingRowsCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGrid.AlternatingRowsDefaultCellStyle = alternatingRowsCellStyle;

            columnHeaderCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            columnHeaderCellStyle.BackColor = Color.Gainsboro;
            columnHeaderCellStyle.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            columnHeaderCellStyle.ForeColor = SystemColors.WindowText;
            columnHeaderCellStyle.SelectionBackColor = SystemColors.Highlight;
            columnHeaderCellStyle.SelectionForeColor = SystemColors.HighlightText;
            columnHeaderCellStyle.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = columnHeaderCellStyle;

            RowsCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGrid.RowsDefaultCellStyle = RowsCellStyle;

            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersHeight = 25;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = System.Drawing.Color.Gainsboro;
            dataGrid.MultiSelect = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}

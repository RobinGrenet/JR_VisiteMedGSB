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
    public partial class JR_FrmPracticien : Form
    {
        public JR_FrmPracticien()
        {
            InitializeComponent();
        }

        private void JR_FrmPracticien_Load(object sender, EventArgs e)
        {
            #region Modification de propriété
            JR_GestionForm.ModificationProprieteCommune(this);
            #endregion

            #region Sélection de l'onglet actif
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmPraticien, tctrlPracticien);
            #endregion
        }

        private void JR_FrmPracticien_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmPraticien, tctrlPracticien);
        }
    }
}

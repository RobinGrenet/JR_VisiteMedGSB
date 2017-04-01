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
    public partial class JR_FrmVisiteur : Form
    {
        public JR_FrmVisiteur()
        {
            InitializeComponent();
        }
        #region objets globaux, procédures et fonctions
        
        #endregion
        private void JR_FrmVisiteur_Load(object sender, EventArgs e)
        {
            #region Modification de propriété
            JR_GestionForm.ModificationProprieteCommune(this);
            #endregion

            #region sélection de l'onglet actif
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmVisiteur, tctrlVisiteur);
            #endregion

            #region Chargement de la DtgListeVisiteur
            
            #endregion
        }

        private void JR_FrmVisiteur_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            JR_GestionForm.SelectionOngletActif(JR_FrmPrincipal.TabFrmVisiteur, tctrlVisiteur);
        }

    }
}

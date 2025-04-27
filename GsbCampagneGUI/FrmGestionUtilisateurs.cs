using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsbCampagneGUI
{
    public partial class FrmGestionUtilisateurs : Form
    {
        public FrmGestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            FrmAfficherUtilisateurs frmAfficherUtilisateurs = new FrmAfficherUtilisateurs();
            frmAfficherUtilisateurs.Show();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterUtilisateur frmAjouterUtilisateur = new FrmAjouterUtilisateur();
            frmAjouterUtilisateur.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using GsbCampagneBLL;
using GsbCampagneDAL;
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
    public partial class FrmAfficherUtilisateurs : Form
    {
        public FrmAfficherUtilisateurs()
        {
            InitializeComponent();
            List<Salarie> salarieManager = SalarieManager.GetInstance().GetLesSalaries();
            dgvUtilisateurs.DataSource = salarieManager;
            //dgvUtilisateurs.Columns["Id"].Visible = false;
            dgvUtilisateurs.Columns["Mdp"].Visible = false;
            dgvUtilisateurs.Columns["IdRole"].Visible = false;
            dgvUtilisateurs.Columns["Campagnes"].Visible = false;
            dgvUtilisateurs.Columns["JournalInterventions"].Visible = false;
            dgvUtilisateurs.Columns["Role"].Visible = false;
            dgvUtilisateurs.Columns["LibelleRole"].DisplayIndex = dgvUtilisateurs.Columns.Count - 1;
            dgvUtilisateurs.RowHeadersVisible = false;
            dgvUtilisateurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUtilisateurs.BackgroundColor = Color.White;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

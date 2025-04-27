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
    public partial class FrmAjouterUtilisateur : Form
    {
        public FrmAjouterUtilisateur()
        {
            InitializeComponent();
            cboRole.DataSource = RoleDAO.GetInstance().GetLesRoles();
            cboRole.DisplayMember = "Libelle";
            cboRole.ValueMember = "Id";
            cboRole.SelectedIndex = -1;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string erreurs = "";
            string nomEnMinuscule = txtNom.Text.ToLower();
            string prenomEnMinuscule = txtPrenom.Text.ToLower();
            if (nomEnMinuscule.Length == 0 )
            {
                erreurs += "Le nom de l'utilisateur doit être renseignée\n";
            }

            if(prenomEnMinuscule.Length == 0 )
            {
                erreurs += "Le prénom de l'utilisateur doit être renseignée\n";
            }

            char premiereLettrePrenom = txtPrenom.Text[0];
            string login = premiereLettrePrenom + txtNom.Text;
            

            for(int i = 0; i < prenomEnMinuscule.Length; i++)
            {
                char lettreTeste = prenomEnMinuscule[i];

                if (char.IsLetter(lettreTeste) == false)
                {
                    MessageBox.Show("Le prénom ne doit contenir que des lettres !");
                    break;
                }

            }

            for (int i = 0; i < nomEnMinuscule.Length; i++)
            {
                char lettreTeste = nomEnMinuscule[i];

                if(char.IsLetter(lettreTeste) == false)
                {

                }
            }
        }
    }
}

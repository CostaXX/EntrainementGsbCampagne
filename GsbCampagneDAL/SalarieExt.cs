using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbCampagneDAL;

namespace GsbCampagneDAL
{
    public partial class Salarie
    {
        public string LibelleRole
        {
            get
            {
                return Role.Libelle;
            }
        }
    }
}

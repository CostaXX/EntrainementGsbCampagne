using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbCampagneDAL
{
    public partial class RoleDAO
    {

        #region Singleton
        private static RoleDAO instance;
        public static RoleDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new RoleDAO();
            }
            return instance;
        }
        #endregion
        public List<Role> GetLesRoles()
        {
            using(var ctx = new GsbCampagnesEntities())
            {
                return ctx.Roles.ToList();
            }
        }
    }
}

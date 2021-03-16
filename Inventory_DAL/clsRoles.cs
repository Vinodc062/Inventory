using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProTracker_DAL.Interfaces;
using ProTracker_DAL.AccessObject;
using ProTracker_TO;

namespace ProTracker_DAL
{
    public class clsRoles : IRoleMaster
    {
        clsAccessDBObjects caObjects;
        String Query;

        public clsRoles(IDbase dbase)
        {
            caObjects = new clsAccessDBObjects(dbase);
        }

        public int CreateRole(RoleMaster roleMaster)
        {
            Query = "exec proc_Roles_Master '" + roleMaster.rm_RoleId + "','" + roleMaster.rm_RoleName + "','" + roleMaster.rm_Status + "','" + roleMaster.rm_User + "'";
            return Convert.ToInt32(caObjects.ExecuteQuery(Query));
        }

        public RoleMaster[] GetRoles()
        {
            DataTable dt = new DataTable();
            RoleMaster[] roleMasters;
            Query = "exec proc_GetRoles";
             dt = caObjects.ExecuteQueryReturnDataTable(Query);

            roleMasters = new RoleMaster[dt.Rows.Count];
            for (int i = 0; i <= dt.Rows.Count -1; i++)
            {
                RoleMaster roleMaster = new RoleMaster();
                roleMaster.rm_RoleId = Convert.ToInt32(dt.Rows[i]["rm_RoleId"]);
                roleMaster.rm_RoleName = Convert.ToString(dt.Rows[i]["rm_RoleName"]);
                roleMaster.rm_Status = Convert.ToBoolean(dt.Rows[i]["rm_Status"]);

                roleMasters[i] = roleMaster;
            }

            return roleMasters;
        }


    }
}

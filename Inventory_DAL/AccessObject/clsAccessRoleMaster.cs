using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProTracker_DAL.Interfaces;
using ProTracker_TO;

namespace ProTracker_DAL.AccessObject
{
    public class clsAccessRoleMaster
    {
        IRoleMaster _roleMaster;

        public clsAccessRoleMaster(IRoleMaster roleMaster)
        {
            this._roleMaster = roleMaster;
        }
        public int CreateRole(RoleMaster roleMaster)
        {
            return _roleMaster.CreateRole(roleMaster);
        }

        public RoleMaster[] GetRoles()
        {
            return _roleMaster.GetRoles();
        }
    }
}


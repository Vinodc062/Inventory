using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProTracker_TO;

namespace ProTracker_DAL.Interfaces
{
   public interface IRoleMaster
    {
        int CreateRole(RoleMaster roleMaster);

        RoleMaster[] GetRoles();

        //IEnumerable<RoleMaster> GetActiveRoles(bool Stautus);
    }
}

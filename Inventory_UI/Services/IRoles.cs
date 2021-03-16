using ProTracker_TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProTracker_UI.Services
{
    public interface IRoles
    {
        Task<int> CreateRole(RoleMaster roleMaster);
        Task<RoleMaster[]> GetRoles();
    }
}

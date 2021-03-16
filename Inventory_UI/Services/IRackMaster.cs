using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProTracker_TO;

namespace ProTracker_UI.Services
{
   public interface IRackMaster
    {
        Task<int> CreateRack(RackMaster rackMaster);
        Task<RackMaster[]> GetRacks();
    }
}

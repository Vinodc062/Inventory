using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProTracker_TO;

namespace ProTracker_UI.Services
{
    public interface IVehicle
    {
        Task<int> CreateVehicle(VehicleMaster vehicleMaster);

        Task<VehicleMaster[]> Getvehicles();
    }
}

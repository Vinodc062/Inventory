using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProTracker_TO;

namespace ProTracker_DAL.Interfaces
{
    public interface IVehicleMaster
    {
        int CreateVehicle(VehicleMaster vehicleMaster);
        VehicleMaster[] GetVehicle();
    }
}

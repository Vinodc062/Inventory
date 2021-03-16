using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProTracker_TO;
using ProTracker_DAL.Interfaces;

namespace ProTracker_DAL.AccessObject
{
   public class clsAccessVehiclemaster
    {
        IVehicleMaster _vehicleMaster;
        public clsAccessVehiclemaster(IVehicleMaster vehicleMaster)
        {
            _vehicleMaster = vehicleMaster;
        }
        public int CreateVehicle(VehicleMaster vehicleMaster)
        {
           return _vehicleMaster.CreateVehicle(vehicleMaster);
        }

        public VehicleMaster[] GetVehicle()
        {
            return _vehicleMaster.GetVehicle();
        }
    }
}

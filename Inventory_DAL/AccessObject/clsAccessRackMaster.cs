using ProTracker_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProTracker_TO;

namespace ProTracker_DAL.AccessObject
{
    public class clsAccessRackMaster
    {
        IRackMaster rackMaster;
        public clsAccessRackMaster(IRackMaster rackMaster)
        {
            this.rackMaster = rackMaster;
        }

        public int CreateRack(RackMaster rackMaster)
        {
            return this.rackMaster.CreateRack(rackMaster);
        }

        public RackMaster[] GetRacks()
        {
            return this.rackMaster.GetRacks();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProTracker_DAL.Interfaces;
using ProTracker_TO;
using ProTracker_DAL.AccessObject;
using System.Data;

namespace ProTracker_DAL
{
    public class clsVehicleMaster : IVehicleMaster
    {
        clsAccessDBObjects caObjects;
        String Query;

        public clsVehicleMaster(Interfaces.IDbase dbase)
        {
            caObjects = new clsAccessDBObjects(dbase);
        }

        public int CreateVehicle(VehicleMaster vehicleMaster)
        {
            Query = "exec proc_Vehicle_Master '" + vehicleMaster.vm_Vehicle_Id + "','" + vehicleMaster.vm_Vehicle_Number + "','" + vehicleMaster.vm_Vehicle_desc + "','" + vehicleMaster.vm_Status + "','" + vehicleMaster.vm_user + "'";
            return Convert.ToInt32(caObjects.ExecuteQuery(Query));
        }

        public VehicleMaster[] GetVehicle()
        {
            DataTable dt = new DataTable();
            VehicleMaster[] vehicleMasters;
            Query = "exec proc_GetVehicle";
            dt = caObjects.ExecuteQueryReturnDataTable(Query);

            vehicleMasters = new VehicleMaster[dt.Rows.Count];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                VehicleMaster vehicleMaster = new VehicleMaster();
                vehicleMaster.vm_Vehicle_Id = Convert.ToInt32(dt.Rows[i]["vm_Vehicle_Id"]);
                vehicleMaster.vm_Vehicle_Number = Convert.ToString(dt.Rows[i]["vm_Vehicle_Number"]);
                vehicleMaster.vm_Vehicle_desc = Convert.ToString(dt.Rows[i]["vm_Vehicle_desc"]);
                vehicleMaster.vm_Status = Convert.ToBoolean(dt.Rows[i]["vm_Status"]);
               // vehicleMaster.vm_user = Convert.ToInt32(dt.Rows[i]["vm_user"]);

                vehicleMasters[i] = vehicleMaster;
            }

            return vehicleMasters;
        }
    }
}

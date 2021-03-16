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
    public class clsRackMaster : IRackMaster
    {
        clsAccessDBObjects caObjects;
        String Query;

        public clsRackMaster(IDbase dbase)
        {
            caObjects = new clsAccessDBObjects(dbase);
        }

        public int CreateRack(RackMaster rackMaster)
        {
            Query = "exec proc_Rack_Master '" + rackMaster.rak_Rack_Id + "','" + rackMaster.rak_Rack_Number+ "','" + rackMaster.rak_Rack_Name + "','" + rackMaster.rak_User+ "'";
            return Convert.ToInt32(caObjects.ExecuteQuery(Query));
        }
        public RackMaster[] GetRacks()
        {
            DataTable dt = new DataTable();
            RackMaster[] rackMasters;
            Query = "exec proc_GetRacks";
            dt = caObjects.ExecuteQueryReturnDataTable(Query);

            rackMasters = new RackMaster[dt.Rows.Count];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                RackMaster rackMaster = new RackMaster();
                rackMaster.rak_Rack_Id = Convert.ToInt32(dt.Rows[i]["rak_Rack_Id"]);
                rackMaster.rak_Rack_Name = Convert.ToString(dt.Rows[i]["rak_Rack_Name"]);
                rackMaster.rak_Rack_Number = Convert.ToString(dt.Rows[i]["rak_Rack_Number"]);

                rackMasters[i] = rackMaster;
            }

            return rackMasters;
        }
    }
}

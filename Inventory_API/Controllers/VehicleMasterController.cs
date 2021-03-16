using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProTracker_TO;
using ProTracker_DAL.AccessObject;
using ProTracker_DAL;

namespace ProTracker_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleMasterController : Controller
    {

        private IConfiguration _configuration;
        clsAccessVehiclemaster _clsAccessVehiclemaster;

        public VehicleMasterController(IConfiguration configuration)
        {
            _configuration = configuration;
            _clsAccessVehiclemaster = new clsAccessVehiclemaster(new clsVehicleMaster(new DBase_SQL(_configuration)));
        }

        [HttpPost]
        [Route("CreateVehicle")]
        public int CreateVehicle(VehicleMaster vehicleMaster)
        {
            return _clsAccessVehiclemaster.CreateVehicle(vehicleMaster);
        }

        [HttpGet]
        [Route("GetVehicles")]
        public VehicleMaster[] GetVehicles()
        {
            return _clsAccessVehiclemaster.GetVehicle();
        }
    }
}

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
    public class RackMasterController : Controller
    {
        private IConfiguration _configuration;
        clsAccessRackMaster _clsAccessRackMaster;

        public RackMasterController(IConfiguration configuration)
        {
            _configuration = configuration;
            _clsAccessRackMaster = new clsAccessRackMaster(new clsRackMaster(new DBase_SQL(_configuration)));

        }
        [HttpPost]
        [Route("CreateRack")]
        public int CreateRack(RackMaster rackMaster)
        {
            return _clsAccessRackMaster.CreateRack(rackMaster);
        }

        [HttpGet]
        [Route("GetRacks")]
        public RackMaster[] GetRacks()
        {
            return _clsAccessRackMaster.GetRacks();
        }
    }
}

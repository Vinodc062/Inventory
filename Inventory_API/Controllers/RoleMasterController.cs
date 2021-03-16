using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProTracker_TO;
using ProTracker_DAL.AccessObject;
using ProTracker_DAL;
using Newtonsoft.Json;

namespace ProTracker_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleMasterController : Controller
    {

        private IConfiguration _configuration;
        clsAccessRoleMaster _clsAccessRoleMaster;

        public RoleMasterController(IConfiguration configuration)
        {
            _configuration = configuration;
            _clsAccessRoleMaster = new clsAccessRoleMaster(new clsRoles(new DBase_SQL(_configuration)));
        }

        [HttpPost]
        [Route("CreateRole")]
        public int CreateRole(RoleMaster roleMaster)
        {
            return _clsAccessRoleMaster.CreateRole(roleMaster);
        }

        [HttpGet]
        [Route("GetRoles")]
        public RoleMaster[] GetRoles()
        {
            return _clsAccessRoleMaster.GetRoles();
        }
    }
}

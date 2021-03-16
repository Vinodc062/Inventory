using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProTracker_DAL;
using ProTracker_DAL.AccessObject;
using ProTracker_DAL.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ProTracker_TO;

namespace ProTracker_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        //IInventoryConfig _inventoryConfig;
        private IConfiguration _conString;
        clsAccessUser accessUser;
        public LoginController(IConfiguration conString)
        {
            _conString = conString;
            accessUser = new clsAccessUser(new clsUsers(new DBase_SQL(_conString)));
        }

        [HttpPost]
        public String CreateUser(User user)
        {
           return accessUser.CreateUser(user);
        }

        [HttpGet]
        [Route("GetUser")]
        public String GetUser(int userId)
        {   
           return accessUser.GetUser(userId);
        }

        [HttpPost]
        [Route("AuthenticateUser")]
        public Int32  AuthenticateUser(Authenticate authenticate)
        {
            return accessUser.AuthenticateUser(authenticate);
        }
    }
}

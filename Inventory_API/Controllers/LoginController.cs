using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory_DAL;
using Inventory_DAL.AccessObject;
using Inventory_DAL.Interfaces;
using Inventory_DAL.TableObjects;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Inventory_API.Controllers
{
    [ApiController]
    [Route("api/LoginController")]
    public class LoginController : ControllerBase
    {
        //IInventoryConfig _inventoryConfig;
        private IConfiguration _conString;
        public LoginController(IConfiguration conString)
        {
            _conString = conString;
        }

        [HttpPost]
        public String CreateUser(User user)
        {
            clsAccessUser accessUser = new clsAccessUser(new clsUsers(new DBase_SQL(_conString)));
           return accessUser.CreateUser(user);
        }

        [HttpGet]
        public String GetUser(int userId)
        {   
            
            clsAccessUser accessUser = new clsAccessUser(new clsUsers(new DBase_SQL(_conString)));
           return accessUser.GetUser(userId);
        }
    }
}

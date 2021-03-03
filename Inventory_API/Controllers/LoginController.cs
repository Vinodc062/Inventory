using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory_DAL;
using Inventory_DAL.AccessObject;
using Inventory_DAL.Interfaces;
using Inventory_DAL.TableObjects;

namespace Inventory_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        //IInventoryConfig _inventoryConfig;

        //public LoginController(InventoryConfig inventoryConfig)
        //{
        //    this._inventoryConfig = inventoryConfig;
        //}

        [HttpGet]
        public String GetUser(int userId)
        {   
            clsAccessUser accessUser = new clsAccessUser(new clsUsers(new DBase_SQL()));
           return accessUser.GetUser(userId);
        }
    }
}

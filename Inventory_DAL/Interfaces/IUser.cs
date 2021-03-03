using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_DAL.TableObjects;

namespace Inventory_DAL
{
   public interface IUser
    {
        String CreateUser(User user);
        String GetUser(int User_id);

    }
}

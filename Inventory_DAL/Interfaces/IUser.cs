using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProTracker_TO;

namespace ProTracker_DAL
{
   public interface IUser
    {
        String CreateUser(User user);
        String GetUser(int User_id);

        Int32 AuthenticateUser(Authenticate authenticate);

    }
}

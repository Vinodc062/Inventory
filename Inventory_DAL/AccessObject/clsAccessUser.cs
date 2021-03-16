using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProTracker_TO;

namespace ProTracker_DAL.AccessObject
{
    public class clsAccessUser
    {
        IUser _user;
        public clsAccessUser(IUser user)
        {
            _user = user;
        }

        public string CreateUser(User user)
        {
            return _user.CreateUser(user);
        }

        public String GetUser(int User_id)
        {
            return _user.GetUser(User_id);
        }

        public Int32 AuthenticateUser(Authenticate authenticate)
        {
            return _user.AuthenticateUser(authenticate);
        }
    }
}

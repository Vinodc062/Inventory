using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
using ProTracker_DAL.AccessObject;
using ProTracker_TO;

namespace ProTracker_DAL
{
    public class clsUsers : IUser
    {
        clsAccessDBObjects caObjects;
        String Query;

        public clsUsers(Interfaces.IDbase dbase)
        {
            caObjects = new clsAccessDBObjects(dbase);
        }

        public Int32 AuthenticateUser(Authenticate authenticate)
        {
            Query = "EXEC proc_AuthenticateUser '" + authenticate.UserName + "','" + authenticate.Password + "'";
            return Convert.ToInt32(caObjects.ExecuteScalar(Query));
        }

        public string CreateUser(User user)
        {
            Query = "EXEC proc_User_Master '"+ user.um_User_Id +"', '"+ user.um_User_Name +"', '"+ user.um_First_Name +"','"+ user.um_Last_Name +"','"+ user.um_Status +"','"+ user.um_User +"'";
            return caObjects.ExecuteQuery(Query).ToString();
        }

        public String GetUser(int User_id)
        {
            Query = "select um_User_Name from User_Master where um_User_Id = " + User_id;
            DataTable ds = new DataTable();
            ds = caObjects.ExecuteQueryReturnDataTable(Query);

            return ds.Rows[0][0].ToString();
        }
    }
}

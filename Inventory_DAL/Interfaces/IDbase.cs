using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProTracker_DAL.Interfaces
{
    public interface IDbase
    {
        
        DataSet ExecuteQueryReturnDataset(String Query);

        DataTable ExecuteQueryReturnDataTable(String Query);

        int ExecuteQuery(String Query);

        dynamic ExecuteScalar(String Query);

    }
}

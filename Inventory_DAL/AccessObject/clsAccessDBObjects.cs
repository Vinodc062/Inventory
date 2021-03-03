using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Inventory_DAL.Interfaces;

namespace Inventory_DAL.AccessObject
{
    public class clsAccessDBObjects
    {
        IDbase _dbase;

        public clsAccessDBObjects(IDbase dbase)
        {
            _dbase = dbase;
        }

        public DataSet ExecuteQueryReturnDataset(string Query)
        {
            return _dbase.ExecuteQueryReturnDataset(Query);
        }

        public DataTable ExecuteQueryReturnDataTable(string Query)
        {
            return _dbase.ExecuteQueryReturnDataTable(Query);
        }

        public int ExecuteQuery(string Query)
        {
            return _dbase.ExecuteQuery(Query);
        }
    }
}

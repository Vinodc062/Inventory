using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_DAL.Interfaces;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Inventory_DAL
{
   public class DBase_SQL : IDbase
    {
        SqlConnection _sqlcon;
        IConfiguration configuration;
        IInventoryConfig inventoryConfig;
        SqlDataAdapter sqlda;
        DataSet ds;
        SqlCommand Sqlcomm;

        public DBase_SQL()
        {
           inventoryConfig = new InventoryConfig(configuration);
            this._sqlcon = new SqlConnection(inventoryConfig.GetConnectionString(inventoryConfig.SQLConnection));
        }

        public int ExecuteQuery(string Query)
        {
            checkConnection();
            Sqlcomm = new SqlCommand(Query, _sqlcon);
            return Sqlcomm.ExecuteNonQuery();
        }

        private void checkConnection()
        {
            if (_sqlcon.State == ConnectionState.Closed)
            {
                _sqlcon.Open();
            }
        }

        public DataSet ExecuteQueryReturnDataset(string Query)
        {
            ds = new DataSet();
            sqlda = new SqlDataAdapter(Query, _sqlcon);
            sqlda.Fill(ds);
            return ds;
        }

        public DataTable ExecuteQueryReturnDataTable(string Query)
        {
            ds = new DataSet();
            sqlda = new SqlDataAdapter(Query, _sqlcon);
            sqlda.Fill(ds);
            
            return ds.Tables[0];
        }

    }
}

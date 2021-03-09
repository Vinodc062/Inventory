using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProTracker_DAL.Interfaces;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProTracker_DAL;

namespace ProTracker_DAL
{
    public class DBase_SQL : IDbase
    {
        SqlConnection _sqlcon;
        IConfiguration configuration;
        IProTrackerConfig proTrackerConfig;
        SqlDataAdapter sqlda;
        DataSet ds;
        SqlCommand Sqlcomm;

        public DBase_SQL(IConfiguration configuration)
        {
            proTrackerConfig = new ProTrackerConfig(configuration);
            _sqlcon = new SqlConnection(proTrackerConfig.SQLConnection);
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

        public dynamic ExecuteScalar(string Query)
        {
            checkConnection();
            Sqlcomm = new SqlCommand(Query, _sqlcon);
            return Sqlcomm.ExecuteScalar().ToString();
        }
    }
}

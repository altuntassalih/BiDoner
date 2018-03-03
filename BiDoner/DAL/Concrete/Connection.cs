using BiDoner.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace BiDoner.DAL.Concrete
{
    public class Connection:IConnection
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public string dbname { get; set; }
        public Connection()
        {
            dbname = ConfigurationManager.AppSettings["Dbname"];
        }

        public IDbConnection GetConnection
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = string.Format(connectionString, dbname);
                conn.Open();
                return conn;
            }
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {


                }
            }


            disposedValue = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
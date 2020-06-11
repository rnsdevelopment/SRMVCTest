//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using Dapper;
//using Microsoft.Extensions.Configuration;

//namespace Core.Data
//{


//    public static class DataAccess
//    {

//        private static IConfiguration _config;

//        public static void Init(IConfiguration config)
//        {
//            _config = config;

//        }

//        public static string ConnectionString()
//        {
//            bool development = true;
//            string connectionName = development ? "RazorTest" : "RazorTestLive";
//            var connectionString = _config.GetConnectionString(connectionName);
//            return connectionString;
//        }

//    }

//    public interface IDataAccess
//    {
//        string ConnectionString();
//    }
//}

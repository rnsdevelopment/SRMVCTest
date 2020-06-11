using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Web.Utilities
{
    public static class Helper
    {
        public static string Connection(IConfiguration configuration)
        {
            bool development = true;
            string connectionName = development ? "RazorTest" : "RazorTestLive";
            return configuration.GetConnectionString(connectionName);
        }


    }

      

}

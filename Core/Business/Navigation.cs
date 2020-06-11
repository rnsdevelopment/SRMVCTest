using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business.Details;
using Core.Data;
using Dapper;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Business
{
    public class Navigation
    {

        public static List<NavItemDetails> HomepageNav(int companyId)
        {

            //var x = DataAccess.ConnectionString();

            List<NavItemDetails> navs = new List<NavItemDetails>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Core.Data.Connection.ConnectionString)) 
            {
                navs = connection.Query<NavItemDetails>("dbo.NavigationList @prmCompanyId", new { prmCompanyId = companyId }).ToList();
            }

            return navs;
        }

    }
}

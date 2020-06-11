using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business.Details
{
    public class NavItemDetails
    {
        public int CompanyId { get; set; }
        public int NavigationId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public Core.Constants.Generic Status { get; set; }

    }
}

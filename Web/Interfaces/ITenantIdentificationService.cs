using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Interfaces
{
    public interface ITenantIdentificationService
    {
        string GetCurrentTenant(HttpContext httpContext);
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Interfaces;

namespace Web.BaseClasses
{
    public abstract class BaseController : Controller
    {
        private readonly ITenantService _service;
        public BaseController(ITenantService service)
        {
            _service = service;
        }

        public string CurrentTennat
        {
            get
            {
                return _service.GetCurrentTenant();
            }
        }

    }
}

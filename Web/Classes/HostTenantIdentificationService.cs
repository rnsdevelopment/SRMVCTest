﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Interfaces;

namespace Web.Classes
{
    public sealed class HostTenantIdentificationService : ITenantIdentificationService
    {
        private readonly TenantMapping _tenants;

        public HostTenantIdentificationService(IConfiguration configuration)
        {
            this._tenants = configuration.GetTenantMapping();
        }

        public HostTenantIdentificationService(TenantMapping tenants)
        {
            this._tenants = tenants;
        }

        public IEnumerable<string> GetAllTenants()
        {
            return this._tenants.Tenants.Values;
        }

        public string GetCurrentTenant(HttpContext context)
        {
            if (!this._tenants.Tenants.TryGetValue(context.Request.Host.Host, out var tenant))
            {
                tenant = this._tenants.Default;
            }

            return tenant;
        }
    }
}

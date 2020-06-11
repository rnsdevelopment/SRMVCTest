using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Interfaces;

namespace Web.Classes
{
    public sealed class TenantViewLocationExpander : IViewLocationExpander
    {
        private ITenantService _service;
        private string _tenant;

        //public IEnumerable ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable
        //    viewLocations)
        //{
        //    foreach (string location in viewLocations)
        //    {
        //        yield return location.Replace("{0}", this._tenant + "/{0}");
        //        yield return location;
        //    }
        //}

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {

            //IEnumerable<string> subAreaViewLocation = new string[]
            //{
            //    "/Pages/"+this._tenant+"/{1}/{0}.cshtml"
            //};

            //viewLocations = subAreaViewLocation.Concat(viewLocations);
            //return viewLocations;


            foreach (string location in viewLocations)
            {
                //string loc = location.Replace("{0}", this._tenant + "/{0}");
                string loc = location.Replace("{1}", this._tenant + "/{1}");

                //yield return "/Pages/{1}/Company1/index.cshtml";
                //yield return location.Replace("{1}", this._tenant + "/{1}");

                yield return loc;
                yield return location;

            }
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            this._service = context.ActionContext.HttpContext.RequestServices.GetService<ITenantService>();
            this._tenant = this._service.GetCurrentTenant();
        }
    }
}

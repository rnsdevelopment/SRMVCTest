using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Utilities;

namespace Web.Utilities
{
    public static class UserSession
    {

        private static IHttpContextAccessor _httpContextAccessor;
        private static ISession _session => _httpContextAccessor.HttpContext.Session;

        public static void SetHttpContextAccessor(IHttpContextAccessor accessor)
        {
            _httpContextAccessor = accessor;
        }

        public enum SessionName
        {
            CompanyId,
            UserId,
            ComplexTest,
            DateTimeTest
        }


        public static Core.Business.Details.NavItemDetails ComplexItem
        {
            get { return GetSessionObjectValue<Core.Business.Details.NavItemDetails>(SessionName.ComplexTest); }
            set { AddSessionValue(SessionName.ComplexTest, value); }
        }

        public static DateTime DateTimeTest
        {
            get { return GetSessionDateTimeValue(SessionName.DateTimeTest); }
            set { AddSessionValue(SessionName.DateTimeTest, value); }
        }

        public static int UserId
        {
            get { return GetSessionValue(SessionName.UserId) != null ? Convert.ToInt32(GetSessionValue(SessionName.UserId)) : 0; }
            set { AddSessionValue(SessionName.UserId, value.ToString()); }
        }

        public static int CompanyId
        {
            get { return GetSessionValue(SessionName.CompanyId) != null ? Convert.ToInt32(GetSessionValue(SessionName.CompanyId)) : 0; }
            set { AddSessionValue(SessionName.CompanyId, value.ToString()); }
        }


        private static string GetSessionValue(SessionName name)
        {
            try
            {
                return _session.GetString(name.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }


        private static T GetSessionObjectValue<T>(SessionName name)
        {
            try
            {
                return _session.GetObjectFromJson<T>(name.ToString());
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        private static DateTime GetSessionDateTimeValue(SessionName name)
        {
            try
            {
                long ticks = Convert.ToInt64(_session.GetString(name.ToString()));
                return new DateTime(ticks);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }


        private static void AddSessionValue(SessionName name, string value)
        {
            _session.SetString(name.ToString(), value);
        }

        private static void AddSessionValue(SessionName name, object value)
        {
            _session.SetObjectAsJson(name.ToString(), value);
        }

        private static void AddSessionValue(SessionName name, DateTime value)
        {
            _session.SetString(name.ToString(), value.Ticks.ToString());
        }
    }
}

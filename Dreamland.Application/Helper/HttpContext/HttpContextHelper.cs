using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Helper.HttpContext
{
    public static class HttpContextHelper
    {
        private static IHttpContextAccessor HttpContextAccessor;
        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public static string MapUrl()
        {
            var request = HttpContextAccessor.HttpContext.Request;

            return request.ToString();
        }
    }
}

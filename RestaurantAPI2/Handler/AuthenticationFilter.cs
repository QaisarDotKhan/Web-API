using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System;
using System.Web;
using System.Linq;
using System.Web.Http.Controllers;
using System.Net;
using System.Text;
using System.Net.Http;

namespace RestaurantAPI2.Handler
{
    public class AuthenticationFilter: System.Web.Http.Filters.ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if(actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodeToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));
                string userName = decodeToken.Substring(0, decodeToken.IndexOf(":"));
                string userPassword = decodeToken.Substring(decodeToken.IndexOf(":") + 1);

            }
        }
    }
}

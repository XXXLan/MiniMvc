using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniMVC
{
    public class MvcHandler:IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public RequestContext RequerstContext { get; private set; }

        public MvcHandler(RequestContext requestContext)
        {
            this.RequerstContext = requestContext;
        }

        public void ProcessRequest(HttpContext context)
        {
            string controllerName = this.RequerstContext.RouteData.Controller;
            
        }
    }
}
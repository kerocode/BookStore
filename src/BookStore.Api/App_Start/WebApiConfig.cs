using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;
using BookStore.Web.Common;
using BookStore.Web.Common.Routing;
using BookStore.Common.Logging;
using System.Web.Http.ExceptionHandling;
using BookStore.Web.Common.ErrorHandling;

namespace BookStore.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            var constraintsResolver = new DefaultInlineConstraintResolver();
            constraintsResolver.ConstraintMap.Add("apiVersionConstraint", typeof(ApiVersionConstraint));
            config.MapHttpAttributeRoutes(constraintsResolver);

            config.Services.Replace(typeof(IHttpControllerSelector),
                new NamespaceHttpControllerSelector(config));
            //config.EnableSystemDiagnosticsTracing(); // replaced by custom writer 
            config.Services.Replace(typeof(System.Web.Http.Tracing.ITraceWriter),    
                new SimpleTraceWriter(WebContainerManager.Get<ILogManager>()));
            config.Services.Add(typeof(IExceptionLogger), 
                new SimpleExceptionLogger(WebContainerManager.Get<ILogManager>()));
            /*  // Web API configuration and services

              // Web API routes
              config.MapHttpAttributeRoutes();

              config.Routes.MapHttpRoute(
                  name: "DefaultApi",
                  routeTemplate: "api/{controller}/{id}",
                  defaults: new { id = RouteParameter.Optional }
              );*/
        }
    }
}

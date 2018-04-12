using SampleCoding.API.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;

namespace SampleCoding.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            EnableCrossSiteRequests(config);
            // Web API routes
            config.MapHttpAttributeRoutes();

            InvokeUnity(config);
        

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }

        public static void InvokeUnity(HttpConfiguration config)
        {
            var container = new UnityContainer();
            InjectUnityOfWork.InjectRepositories(ref container);
            config.DependencyResolver = new UnityResolver(container);
            System.Web.Mvc.DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
        }

        private static void EnableCrossSiteRequests(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute(
                origins: "http://localhost:51128",
                headers: "*",
                methods: "*");
            config.EnableCors(cors);
        }
    }
}

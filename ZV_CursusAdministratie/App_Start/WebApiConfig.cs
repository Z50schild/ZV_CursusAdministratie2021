using System.Web.Http;
using System.Web.Http.Cors;

namespace ZV_CursusAdministratie
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //enable CORS for Angular
            var cors = new EnableCorsAttribute("http://localhost:4200", "*", "*");
            config.EnableCors(cors);
            
            
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

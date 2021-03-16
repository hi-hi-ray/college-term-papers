using System.Web.Http;
using System.Web.Http.Cors;

namespace KeepEverything.RaysaDutra.WebAPIService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Libera o acesso para qualquer host
            //(origins: "http://www.example.com", headers: "*", methods: "get,post")
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Rotas de API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

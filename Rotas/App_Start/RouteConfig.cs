using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "TodasAsNoticias",
                url: "noticias/", // Boa pratica colocar a Url no final.
                defaults: new { controller = "Home", action = "TodasAsNoticias" }
            );

            routes.MapRoute(
                name: "Categoria Especifica",
                url: "noticias/{categoria}", // URL amigavel, adicionando a categoria na URL, de acordo com o que foi selecionado na pagina.
                defaults: new { controller = "Home", action = "MostrarCategoria" }
            );

            routes.MapRoute(
                name: "Mostra Noticio",
                url: "noticias/{categoria}/{titulo}/{noticiaId}", // URL amigavel, adicionando a categoria na URL, de acordo com o que foi selecionado na pagina.
                defaults: new { controller = "Home", action = "MostrarNoticia" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}

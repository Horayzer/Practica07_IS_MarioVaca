using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Api_REST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page"; 
                //ViewBag
                //Utiliza paginas Razor, clase que genera atributos dinamicos
                //Para enviar datos desde el codigo a la página

            return View();
        }
    }
}

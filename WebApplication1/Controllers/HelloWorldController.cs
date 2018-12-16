using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        //GET: /HelloWorld/Welcome/
        public ActionResult Welcome(string name, int id = 47)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.ID = id;
            return View();
        } 
    }
}
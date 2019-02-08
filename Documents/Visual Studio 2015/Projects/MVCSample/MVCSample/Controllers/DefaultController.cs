using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class DefaultController : Controller
    {
        //// GET: Default
        //public string Index()
        //{
        //    return "This is my default acttion";
        //}
        //public string Welcome(string name ,int n=1)
        //{
        //    return HttpUtility.HtmlEncode("Hello" + name + "n=" + n);
        ////}
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string name,int n=1)
        {
            ViewBag.Message = name;
            ViewBag.n = n;
            return View();
        }

    }
}
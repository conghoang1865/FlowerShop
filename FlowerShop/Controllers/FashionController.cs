using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop.Controllers
{
    public class FashionController : Controller
    {
        // GET: Fashion
        public ActionResult Index()
        {
            return View();
        }
    }
}
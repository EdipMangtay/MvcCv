using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class DeneyimController : Controller
    {
        DeneyimRepositoery repo = new DeneyimRepositoery();
        // GET: Deneyim
        public ActionResult Index()
        {
            var degerler = repo.list();
            return View();
        }
    }
}
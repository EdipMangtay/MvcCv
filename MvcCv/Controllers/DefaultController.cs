using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLHAKKINDAs.ToList();

            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimeler = db.TBLDENEYIMLERIMs.ToList();

            return PartialView(deneyimeler);
        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TBLEGIITMLERIMs.ToList();

            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yeteneklerim = db.TBLYETENEKLERIMs.ToList();
            return PartialView(yeteneklerim);

        }
        public PartialViewResult Hobilerim()
        {
            var hobilerim = db.TBLHOBILERIMs.ToList();
            return PartialView(hobilerim);

        }
        public PartialViewResult Sertifika()
        {
            var sertifikar = db.TBLSERTIFIKALARIMs.ToList();
            return PartialView(sertifikar);

        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(TBLILETISIM t)
        {
            t.TARIH = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLILETISIMs.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}
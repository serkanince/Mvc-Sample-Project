using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample05_TincymceSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ImageFileBrowser()
        {
            return View();
        }

        public ActionResult SaveImageFile()
        {
            //gelen image bilgisi kayıt yapılacak ve kayıt yapılan yerin url bilgisi geriye döndürülecek.
            //boş bırakıyorum çünkü bir çok farklı yöntem mevcut.ben örnek bir url döndürdüm.


            return new JsonResult()
            {
                Data = new { IsSave = true, Url = "https://www.lav.com.tr/Files/products/ADR25_AY016AF_MDM.jpg" },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}
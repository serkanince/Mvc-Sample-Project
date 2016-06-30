using Newtonsoft.Json;
using Sample04_HavaDurumu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample04_HavaDurumu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var havaDurumu = HavaDurumuGetir();
            ViewBag.Result = havaDurumu;

            return View();
        }

        public HavaDurumu HavaDurumuGetir()
        {
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;

                //Secret_Key düzenlenecek.
                //Ankara kısmı dinamik olarak parametre gelebilir.Örnek açısından eklendi.
                var responseString = client.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Ankara,TR&units=metric&appid=Secret_Key");

                var hava = JsonConvert.DeserializeObject<HavaDurumu>(responseString);
                hava.weather[0].icon = @"http://openweathermap.org/img/w/" + hava.weather[0].icon + ".png";
                return hava;
            }
        }
    }
}
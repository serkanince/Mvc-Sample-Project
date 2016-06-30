using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample04_HavaDurumu.Models
{
    public class HavaDurumu
    {
        public Weather[] weather { get; set; }
        public Main main { get; set; }
    }

    public class Weather
    {
        public string description { get; set; }
        public string icon { get; set; }

    }
    public class Main
    {
        public string temp { get; set; }
        public string temp_min { get; set; }
        public string temp_max { get; set; }

    }
}
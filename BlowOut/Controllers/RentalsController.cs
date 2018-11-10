using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {
        public static List<Instrument> instruments = new List<Instrument>{new Instrument("Clarinet", "/Graphics/clarinet.jpg", "$35.00", "$27.00"),
            new Instrument("Flute", "/Graphics/flute.jpg", "$40.00", "$25.00"),
            new Instrument("Saxaphone", "/Graphics/saxaphone.jpg", "$42.00", "$30.00"),
            new Instrument("Trombone", "/Graphics/trombone.jpg", "$60.00", "$35.00"),
            new Instrument("Trumpet", "/Graphics/trumpet.jpg", "$55.00", "$25.00"),
            new Instrument("Tuba", "/Graphics/tuba.jpg", "$70.00", "$50.00")
            };

        // GET: Rentals
        public ActionResult Index()
        {
            return View(instruments);
        }

        public ActionResult Instrument(string name, string imageSource, string newPrice, string oldPrice)
        {
            Instrument instrument = new Instrument(name, imageSource, newPrice, oldPrice);

            return View(instrument);
        }
    }
}
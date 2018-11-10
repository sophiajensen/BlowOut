using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class Instrument
    {
        public string name { get; set; }
        public string imageSource { get; set; }
        public string newPrice { get; set; }
        public string oldPrice { get; set; }

        public Instrument (string name, string imageSource, string newPrice, string oldPrice)
        {
            this.name = name;
            this.imageSource = imageSource;
            this.newPrice = newPrice;
            this.oldPrice = oldPrice;
        }

    }
}
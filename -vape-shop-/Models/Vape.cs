using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _vape_shop_.Models
{
    public class Vape
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public int Mark { get; set; }
        public int Price { get; set; }
        public int Picture { get; set; }
        public int Quantity { get; set; }
    }
}
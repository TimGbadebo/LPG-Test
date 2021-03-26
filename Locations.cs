using System;
using System.Collections.Generic;
using System.Text;

namespace LPG_Test
{
    public class Locations
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class Attractions
    {
        public double rating { get; set; }
        public string title { get; set; }
        public string cityId { get; set; }
        public string type { get; set; }
        public int id { get; set; }
    }
}

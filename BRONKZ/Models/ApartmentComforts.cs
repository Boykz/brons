using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class ApartmentComforts
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public bool Wifi { get; set; }
        public bool Parking { get; set; }
        public bool Appliances { get; set; }
        public bool TV { get; set; }
        public bool Furnishes { get; set; }
        public bool Washing_mashine { get; set; }
        public bool Eevator { get; set; }
        public bool Balkon { get; set; }
    }
}

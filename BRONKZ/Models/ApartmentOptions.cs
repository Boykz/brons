using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class ApartmentOptions
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public string Apartment_main_photo { get; set; }
        public string Apartment_photos { get; set; }
        public string Apartment_360_photo { get; set; }
        public string Apartment_video { get; set; }
        public string Apartment_lat_long { get; set; }
    }
}

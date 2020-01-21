using BRONKZ.HLPClasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class ApartmentFeatures
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public int Sleep_places { get; set; }
        public int Available_visitors { get; set; }
        public double Valume { get; set; }//obem
        public int House_floors { get; set; }
        public int Apartment_floor { get; set; }
        public int Status { get; set; } = ShareClass.NORMAL_STATUS;
    }
}

using BRONKZ.HLPClasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class ApartmentRules
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public DateTime Check_in_time { get; set; }
        public DateTime Check_out_time { get; set; }
        public int Min_book_day { get; set; }
        public int Status { get; set; } = ShareClass.NORMAL_STATUS;
    }
}

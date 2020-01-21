using BRONKZ.HLPClasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public int RenterId { get; set; }
        public Renters Renter { get; set; }
        public int DistrictId { get; set; }
        public Districts District { get; set; }
        public string Location { get; set; }
        public int Type  { get; set; }
        public int Price { get; set; }
        public int Status { get; set; } = ShareClass.NORMAL_STATUS;
    }
}

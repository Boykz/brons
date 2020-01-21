using BRONKZ.HLPClasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class Districts
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public Cities City { get; set; }
        public string Name { get; set; }
        public int Status { get; set; } = ShareClass.NORMAL_STATUS;
    }
}

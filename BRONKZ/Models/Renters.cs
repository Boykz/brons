using BRONKZ.HLPClasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class Renters
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public int Apartments { get; set; }
        public int Status { get; set; } = ShareClass.NORMAL_STATUS;

    }

}

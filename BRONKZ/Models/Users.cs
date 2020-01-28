using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class Users : IdentityUser
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}

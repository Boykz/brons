using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.ViewModels
{
    public class LoginViewModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public string returnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}

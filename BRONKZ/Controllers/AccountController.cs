using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRONKZ.Models;
using BRONKZ.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BRONKZ.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly SignInManager<Users> signInManager;
        public AccountController(SignInManager<Users> sign)
        {
            signInManager = sign;
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }


        public async Task<ActionResult> Login(string returnUrl)
        {
            LoginViewModel model = new LoginViewModel()
            {
                returnUrl = returnUrl,
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()

            };
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account", new { returnUrl = returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            return new ChallengeResult(provider, properties);
        }

        [Route("logins-callback")]

        public ActionResult ExternalLoginCallback()
        {
          
            return View();
        }

        [Route("signin-google")]

        public ActionResult SigninGoogle()
        {

            return View();
        }

    }
}
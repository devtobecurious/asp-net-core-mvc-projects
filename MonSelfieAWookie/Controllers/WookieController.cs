using Microsoft.AspNetCore.Mvc;
using MonSelfieAWookie.Tools;
using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Controllers
{
    public class WookieController : Controller
    {
        #region Public methods
        public IActionResult Index()
        {
            List<Wookie> wookies = new List<Wookie>()
            {
                new Wookie() { Id = 1, Surname = "Chewie", MainWeapon = new Weapon() { Id = 1, Label = "Blaster" }},
                new Wookie() 
                { 
                    Id = 1, 
                    Surname = "Chewie", 
                    MainWeapon = new Weapon() { Id = 1, Label = "Blaster" },
                    Selfies = new List<Selfie>()
                    {
                        new Selfie()
                    }
                }
            };

            return View(new Models.WookiesIndexViewModel()
            {
                Wookies = wookies.Convert()
            });
        }
        #endregion
    }
}

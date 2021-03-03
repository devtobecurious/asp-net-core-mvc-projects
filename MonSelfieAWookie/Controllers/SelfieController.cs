using Microsoft.AspNetCore.Mvc;
using MonSelfieAWookie.Models;
using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Controllers
{
    public class SelfieController : Controller
    {
        public IActionResult Index()
        {
            List<Selfie> selfies = new List<Selfie>()
            {
                new Selfie() { Id = 1, ImageUrl = "https://i.pinimg.com/originals/c7/52/33/c7523389c28dcb06791cccf8fca39ab8.jpg", Titre = "Titre1" },
                new Selfie() { Id = 1, ImageUrl = "https://www.funnylla.com/articles-images/207/one-fun-day-in-the-life-of-a-wookie_big.jpg", Titre = "Titre2" }
            };

            List<Weapon> weaponList = new List<Weapon>()
            {
                new Weapon() { Id = 1,  Label = "CrossBow" },
                new Weapon() { Id = 1,  Label = "Bow" },
                new Weapon() { Id = 1,  Label = "PistoLaser" },
            };

            this.ViewBag.WeaponList = weaponList;

            return View(new SelfiesIndexViewModel()
            {
                Selfies = selfies,
                Weapons = weaponList
            });
        }
    }
}

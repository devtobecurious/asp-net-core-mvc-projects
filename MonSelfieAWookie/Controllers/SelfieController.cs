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
        #region Fields
        private readonly ISelfieRepository _selfieRepository = null;
        #endregion

        #region Constructors
        public SelfieController(ISelfieRepository selfieRepository)
        {
            this._selfieRepository = selfieRepository;
        }
        #endregion

        #region Public methods
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromQuery] string image, string[] titre, string[] humeur)
        {
            return this.View();
        }

        public async Task<IActionResult> Index()
        {
            List<Weapon> weaponList = new List<Weapon>()
            {
                new Weapon() { Id = 1,  Label = "CrossBow" },
                new Weapon() { Id = 1,  Label = "Bow" },
                new Weapon() { Id = 1,  Label = "PistoLaser" },
            };

            this.ViewBag.WeaponList = weaponList;

            return View(new SelfiesIndexViewModel()
            {
                Selfies = this._selfieRepository.GetAll().ToList(),
                Weapons = weaponList
            });
        }
        #endregion
    }
}

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
        #region Fields
        private readonly IWookieRepository _repository = null;
        private readonly IWeaponRepository _weaponRepository = null;
        #endregion

        #region Constructors
        public WookieController(IWookieRepository repository, IWeaponRepository weaponRepository)
        {
            this._repository = repository;
            this._weaponRepository = weaponRepository;
        }
        #endregion

        #region Public methods
        public async Task<IActionResult> Index()
        {
            var result = await this._repository.GetAllAsync();
            var wookiesDto = result.ToList().Convert();

            return View("SuperIndex3", new Models.WookiesIndexViewModel()
            {
                Wookies = wookiesDto
            });
        }

        public IActionResult WookiesAsJson()
        {
            // return this.BadRequest();

            return this.Json(this._repository.GetAll().ToList().Convert());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            this.ViewBag.WeaponList = await this._weaponRepository.GetAllAsync();

            //return await Task.FromResult(this.View());

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Wookie wookie)
        {
            await this._repository.SaveOne(wookie);

            return await Task.FromResult(this.View(wookie));
        }
        #endregion
    }
}

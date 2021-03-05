using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MonSelfieAWookie.Models.Dtos;
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
        private readonly ILogger<WookieController> _logger = null;
        #endregion

        #region Constructors
        public WookieController(ILogger<WookieController> logger, IWookieRepository repository, IWeaponRepository weaponRepository, IWebHostEnvironment env, IOptions<SecurityItem> options)
        {
            this._repository = repository;
            this._weaponRepository = weaponRepository;
            this._logger = logger;
        }
        #endregion

        #region Public methods
        public async Task<IActionResult> Index(int id, string libelle)
        {
            this._logger.LogInformation("Ah que coucou, index");

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
        public async Task<IActionResult> Create(WookieDto wookie)
        {
            if (this.ModelState.IsValid)
            {
                await this._repository.SaveOne(wookie.Item);
            }
            return await Task.FromResult(this.View(wookie));
        }
        #endregion
    }
}

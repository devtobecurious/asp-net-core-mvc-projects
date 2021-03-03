﻿using Microsoft.AspNetCore.Mvc;
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
        #endregion

        #region Constructors
        public WookieController(IWookieRepository repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Public methods
        public IActionResult Index()
        {
            return View(new Models.WookiesIndexViewModel()
            {
                Wookies = this._repository.GetAll().ToList().Convert()
            });
        }
        #endregion
    }
}
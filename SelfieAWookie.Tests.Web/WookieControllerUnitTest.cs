using Microsoft.AspNetCore.Mvc;
using MonSelfieAWookie.Controllers;
using MonSelfieAWookie.Models;
using MonSelfieAWookie.Models.Dtos;
using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using Xunit;

namespace SelfieAWookie.Tests.Web
{
    public class FakeRepository : IWookieRepository
    {
        public IList<Wookie> GetAll()
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

            return wookies;
        }
    }

    public class WookieControllerUnitTest
    {
        #region Public methods
        [Fact]
        public void ShouldReturnListOfWookies()
        {
            IWookieRepository repository = new FakeRepository();

            // Arrange => je prépare
            WookieController controller = new WookieController(repository);

            // Act => je lance ma méthode, mon code à tester
            IActionResult result = controller.Index();

            // Assert => je vérifie
            // Assert.IsType(typeof(ViewResult), result);
            Assert.IsType<ViewResult>(result);
            ViewResult viewResult = result as ViewResult;

            Assert.IsType<WookiesIndexViewModel>(viewResult.Model);
            WookiesIndexViewModel viewModel = viewResult.Model as WookiesIndexViewModel;

            Assert.True(viewModel.Wookies.Count == 2);
        }
        #endregion
    }
}

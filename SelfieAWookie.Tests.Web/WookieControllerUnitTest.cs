using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonSelfieAWookie.Controllers;
using MonSelfieAWookie.Models;
using MonSelfieAWookie.Models.Dtos;
using SelfieAWookie.Core.Domain;
using SelfiesAWookie.Core.Infrastructure.Data;
using SelfiesAWookie.Core.Infrastructure.Wookies;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public Task<IList<Wookie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveOne(Wookie item)
        {
            throw new NotImplementedException();
        }
    }

    public class WookieControllerUnitTest
    {
        public WookieControllerUnitTest()
        {

        }

        #region Public methods
        [Fact]
        public void ShouldReturnListOfWookies()
        {
            // Arrange => je prépare
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("SelfieAWookie");

            using SelfieAWookieDbContext context = new SelfieAWookieDbContext(builder.Options);

            context.Wookies.Add(new Wookie()
            {
                Id = 1,
            });

            context.Wookies.Add(new Wookie()
            {
                Id = 2,
            });
            context.SaveChanges();

            IWookieRepository repository = new DbWookiesRepository(context);

            
            WookieController controller = new WookieController(repository);

            // Act => je lance ma méthode, mon code à tester
            IActionResult result = null; // controller.Index();

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

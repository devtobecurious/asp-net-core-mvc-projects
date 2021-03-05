using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Wookies
{
    public class MemoryWookieRepository : IWookieRepository
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
}

using SelfieAWookie.Core.Domain;
using Microsoft.EntityFrameworkCore;
using SelfiesAWookie.Core.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Weapons
{
    public class DbWeaponsRepository : IWeaponRepository
    {
        #region Fields
        private readonly SelfieAWookieDbContext _context = null;
        #endregion

        #region Constructors
        public DbWeaponsRepository(SelfieAWookieDbContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public methods
        public IList<Weapon> GetAll()
        {
            return this._context.Weapons.ToList();
        }

        public async Task<IList<Weapon>> GetAllAsync()
        {
            return await this._context.Weapons.ToListAsync();
        }

        public Task SaveOne(Weapon item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

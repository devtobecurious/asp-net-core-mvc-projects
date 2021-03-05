using SelfieAWookie.Core.Domain;
using SelfiesAWookie.Core.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Wookies
{
    public class DbWookiesRepository : IWookieRepository
    {
        #region Fields
        private readonly SelfieAWookieDbContext _context = null;
        #endregion

        #region Constructors
        public DbWookiesRepository(SelfieAWookieDbContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public methods
        public IList<Wookie> GetAll()
        {
            return this._context.Wookies.AsNoTracking().Include(item => item.MainWeapon)
                                                       .Include(item => item.Selfies).ToList();
        }

        public async Task<IList<Wookie>> GetAllAsync()
        {
            return await this._context.Wookies.AsNoTracking().Include(item => item.MainWeapon)
                                                             .Include(item => item.Selfies).ToListAsync();
        }

        public async Task SaveOne(Wookie item)
        {
            this._context.Wookies.Add(item);
            this._context.Entry(item.MainWeapon).State = EntityState.Detached;

            // this._context.Entry(item.MainWeapon).Property(item => item.Label).IsModified

            await this._context.SaveChangesAsync();
        }
        #endregion
    }
}

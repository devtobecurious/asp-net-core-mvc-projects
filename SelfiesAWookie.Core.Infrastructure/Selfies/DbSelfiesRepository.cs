using SelfieAWookie.Core.Domain;
using SelfiesAWookie.Core.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Selfies
{
    public class DbSelfiesRepository : ISelfieRepository
    {
        #region Fields
        private readonly SelfieAWookieDbContext _context = null;
        #endregion

        #region Constructors
        public DbSelfiesRepository(SelfieAWookieDbContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public methods
        public IList<Selfie> GetAll()
        {
            var query = from selfie in this._context.Selfies
                        select selfie;

            return query.ToList();
        }
        #endregion
    }
}

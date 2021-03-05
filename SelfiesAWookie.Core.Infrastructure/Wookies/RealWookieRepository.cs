using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Wookies
{
    public class RealWookieRepository : IWookieRepository
    {
        public IList<Wookie> GetAll()
        {
            throw new NotImplementedException();
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

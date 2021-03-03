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
    }
}

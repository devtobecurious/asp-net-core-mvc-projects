using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Domain
{
    public interface IWookieRepository
    {
        /// <summary>
        /// Returns whole list of wookies
        /// </summary>
        /// <returns></returns>
        IList<Wookie> GetAll();
    }
}

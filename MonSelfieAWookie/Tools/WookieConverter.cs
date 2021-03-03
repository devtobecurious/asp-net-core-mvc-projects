using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Tools
{
    public static class WookieConverter
    {
        #region Public methods
        /// <summary>
        /// Converts real models to dtos models
        /// </summary>
        /// <param name="wookies"></param>
        /// <returns></returns>
        public static List<Models.Dtos.WookieResumeDto> Convert(this List<Wookie> wookies)
        {
            return wookies.Select(item => new Models.Dtos.WookieResumeDto(item)).ToList();
        }
        #endregion
    }
}

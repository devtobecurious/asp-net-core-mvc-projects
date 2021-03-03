using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Domain
{
    /// <summary>
    /// Selfie 
    /// </summary>
    public class Selfie
    {
        #region Properties
        public int Id { get; set; }

        public string Titre { get; set; }

        public string ImageUrl { get; set; }

        public Wookie Owner { get; set; }
        #endregion
    }
}

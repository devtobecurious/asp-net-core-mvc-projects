using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models
{
    public class SelfiesIndexViewModel
    {
        #region Properties
        public List<Selfie> Selfies { get; set; }

        public List<Weapon> Weapons { get; set; }
        #endregion
    }
}

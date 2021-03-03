using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Domain
{
    public class Wookie
    {
        #region Properties
        public int Id { get; set; }

        public string Surname { get; set; }

        public List<Selfie> Selfies { get; set; }

        public Weapon MainWeapon { get; set; }

        public List<Weapon> HelpsWeapons { get; set; }
        #endregion
    }
}

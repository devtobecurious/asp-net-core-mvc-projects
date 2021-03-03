using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models.Dtos
{
    public class WookieResumeDto
    {
        #region Constructors
        public WookieResumeDto(Wookie wookie)
        {
            this.Surname = wookie.Surname;
            this.MainWeaponLabel = wookie.MainWeapon?.Label;
            this.AuxiliaryWeaponsNumber = (wookie.HelpsWeapons?.Count).GetValueOrDefault(0);
            this.SelfiesNumber = (wookie.Selfies?.Count).GetValueOrDefault(0);
        }
        #endregion

        #region Properties
        public string Surname { get; private set; }

        public string MainWeaponLabel { get; private set; }

        public int AuxiliaryWeaponsNumber { get; private set; }

        public int SelfiesNumber { get; private set; }
        #endregion
    }
}

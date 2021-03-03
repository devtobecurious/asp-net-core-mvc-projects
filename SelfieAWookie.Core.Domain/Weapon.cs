using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Domain
{
    public class Weapon
    {
        #region Properties
        public int Id { get; set; }
        public string Label { get; set; }
        public int TypeId { get; set; }
        #endregion
    }
}

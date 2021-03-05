using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models.Dtos
{
    public class WookieDto
    {
        #region Fields
        private Wookie _data = null;
        #endregion

        #region Constructors
        public WookieDto(Wookie data = null)
        {
            this._data = data;

            if (this._data is null)
            {
                this._data = new Wookie();
            }
        }
        #endregion

        #region Properties
        public Wookie Item => this._data;

        [Required]
        public string Surname { get => this._data.Surname; set => this._data.Surname = value; }
        #endregion
    }
}

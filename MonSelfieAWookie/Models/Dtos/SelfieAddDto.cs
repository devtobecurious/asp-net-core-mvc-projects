using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models.Dtos
{
    public class SelfieAddDto
    {
        #region Properties
        public string Titre { get; set; }

        [FromQuery]
        public string Image { get; set; }

        public string[] Humeur { get; set; }
        public string ChampAucunRapport { get; set; }
        #endregion
    }
}

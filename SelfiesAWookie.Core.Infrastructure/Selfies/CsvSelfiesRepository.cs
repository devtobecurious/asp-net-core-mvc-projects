﻿using SelfieAWookie.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfiesAWookie.Core.Infrastructure.Selfies
{
    public class CsvSelfiesRepository : ISelfieRepository
    {
        #region Public methods
        public IList<Selfie> GetAll()
        {
            throw new NotImplementedException("to be continued ;)");
        }

        public Task<IList<Selfie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveOne(Selfie item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

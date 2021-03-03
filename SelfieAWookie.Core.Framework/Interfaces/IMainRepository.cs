using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Core.Framework.Interfaces
{
    public interface IMainRepository<TObject> where TObject : class
    {
        IList<TObject> GetAll();
    }
}

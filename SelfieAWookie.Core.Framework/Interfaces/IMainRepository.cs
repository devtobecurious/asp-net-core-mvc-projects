using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Framework.Interfaces
{
    public interface IMainRepository<TObject> where TObject : class
    {
        IList<TObject> GetAll();

        Task<IList<TObject>> GetAllAsync();
    }
}

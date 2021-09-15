using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurent_App.Restaurent.DataAccesss.Repository
{
    interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int T);
        Task Insert(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}
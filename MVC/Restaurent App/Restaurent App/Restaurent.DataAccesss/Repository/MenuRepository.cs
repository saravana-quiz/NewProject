using Restaurent_App.Models;
using Restaurent_App.Restaurent.DataAccesss.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurent_App.Restaurent.DataAccesss.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext _dbObj;
        public MenuRepository(AppDbContext dbObj)
        {
            this._dbObj = dbObj;
        }
        public void Delete(Menu entity)
        {
            _dbObj.Remove(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbObj.FindAsync<Menu>(id);
            _dbObj.Remove(entity);
        }

        public Menu Get(int id)
        {
            return _dbObj.Set<Menu>().Find(id);
        }

        public IEnumerable<Menu> GetAll()
        {
            return _dbObj.Set<Menu>().ToList();
        }

        public async Task Insert(Menu entity)
        {
            await _dbObj.AddAsync<Menu>(entity);
        }

        public void Update(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}
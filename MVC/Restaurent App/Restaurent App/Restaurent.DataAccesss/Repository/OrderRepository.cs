using Restaurent_App.Models;
using Restaurent_App.Restaurent.DataAccesss.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurent_App.Restaurent.DataAccesss.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbObj;
        public OrderRepository(AppDbContext dbObj)
        {
            this._dbObj = dbObj;
        }
        public void Delete(Order entity)
        {
            _dbObj.Remove(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbObj.FindAsync<Order>(id);
            _dbObj.Remove(entity);
        }

        public Order Get(int T)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            return _dbObj.Set<Order>().ToList();
        }

        public async Task Insert(Order entity)
        {
            await _dbObj.AddAsync<Order>(entity);
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
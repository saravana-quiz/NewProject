using Restaurent_App.Models;
using Restaurent_App.Restaurent.DataAccesss.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurent_App.Restaurent.DataAccesss.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext _dbObj;
        private IGenericRepository<Menu> _menuList;
        private IGenericRepository<Order> _orders;


        public UnitofWork(AppDbContext dbObj)
        {
            this._dbObj = dbObj;
        }

        public IGenericRepository<Menu>MenuList => _menuList ??= new GenericRepository<Menu>(_dbObj);

        public IGenericRepository<Order>Orders => _orders ??= new GenericRepository<Order>(_dbObj);

        public void Dispose()
        {
            _dbObj.Dispose();
        }

        public void Save()
        {
            _dbObj.SaveChanges();
        }
    }
}
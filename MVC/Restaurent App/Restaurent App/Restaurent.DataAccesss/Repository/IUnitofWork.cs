using Restaurent_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurent_App.Restaurent.DataAccesss.Repository
{
    interface IUnitofWork : IDisposable
    {
        IGenericRepository<Menu> MenuList { get; }
        IGenericRepository<Order> Orders { get; }
        void Save();
    }
}
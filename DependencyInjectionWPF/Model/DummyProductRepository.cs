using DependencyInjectionWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWPF.Model
{
    public interface IProductRepository
    {
        List<ProductVM> GetAll();
    }

    class DummyProductRepository : IProductRepository
    {
        public List<ProductVM> GetAll()
        {
            return new List<ProductVM>()
           {
               new ProductVM() { Name = "6 Eieren", Price = 1.80 },
               new ProductVM() { Name = "Melk", Price = 0.80 },
               new ProductVM() { Name = "Oud brood", Price = 0 },
               new ProductVM() { Name = "Bacon", Price = 2.40 },
               new ProductVM() { Name = "Vaseline: XL", Price = 8  }
           };
        }
    }
}

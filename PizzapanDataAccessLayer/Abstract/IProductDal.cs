using PizzapanEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzapanDataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        public List<Product> GetProductsWithCategory();
    }
}

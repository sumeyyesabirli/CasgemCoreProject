using Microsoft.EntityFrameworkCore;
using PizzapanDataAccessLayer.Abstract;
using PizzapanDataAccessLayer.Concrete;
using PizzapanDataAccessLayer.Repositories;
using PizzapanEntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace PizzapanDataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategory()
        {
            using var context = new Context();
            return context.Products.Include(p => p.Category).ToList();
        }
    }
}

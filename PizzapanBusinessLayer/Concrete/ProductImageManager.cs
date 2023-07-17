using PizzapanBusinessLayer.Abstract;
using PizzapanDataAccessLayer.Abstract;
using PizzapanEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzapanBusinessLayer.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        private readonly IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public void TDelete(ProductImage entity)
        {
            _productImageDal.Delete(entity);
        }

        public ProductImage TGetById(int id)
        {
            return _productImageDal.GetById(id);
        }

        public List<ProductImage> TGetList()
        {
          return _productImageDal.GetList();
        }

        public void TInsert(ProductImage entity)
        {
            _productImageDal.Insert(entity);
        }

        public void TUpdate(ProductImage entity)
        {
           _productImageDal.Update(entity);
        }
    }
}

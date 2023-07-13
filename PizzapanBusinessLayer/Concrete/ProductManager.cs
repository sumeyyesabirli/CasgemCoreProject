﻿using PizzapanBusinessLayer.Abstract;
using PizzapanDataAccessLayer.Abstract;
using PizzapanDataAccessLayer.EntityFramework;
using PizzapanEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzapanBusinessLayer.Concrete
{
    internal class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
           _productDal.Delete(entity);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);            
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TInsert(Product entity)
        {
           _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
           _productDal.Update(entity);
        }
    }
}

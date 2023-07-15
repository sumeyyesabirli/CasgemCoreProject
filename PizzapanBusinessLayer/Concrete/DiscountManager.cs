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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TDelete(Discount entity)
        {
            throw new NotImplementedException();
        }

        public Discount TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Discount> TGetList()
        {
           return _discountDal.GetList();
        }

        public void TInsert(Discount entity)
        {
            _discountDal.Insert(entity);
        }

        public string TRandomCreateCode()
        {
            return _discountDal.RandomCreateCode();
        }

        public void TUpdate(Discount entity)
        {
            throw new NotImplementedException();
        }       
    }
}

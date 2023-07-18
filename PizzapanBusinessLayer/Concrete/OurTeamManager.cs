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
    public class OurTeamManager : IOurTeamService
    {
        private readonly IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void TDelete(OurTeam entity)
        {
            _ourTeamDal.Delete(entity);
        }

        public OurTeam TGetById(int id)
        {
            return _ourTeamDal.GetById(id);
        }

        public List<OurTeam> TGetList()
        {
            return _ourTeamDal.GetList();
        }

        public void TInsert(OurTeam entity)
        {
            _ourTeamDal.Insert(entity);
        }
        public void TUpdate(OurTeam entity)
        {
            _ourTeamDal.Update(entity);
        }
    }
}


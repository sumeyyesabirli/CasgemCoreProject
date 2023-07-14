using PizzapanDataAccessLayer.Abstract;
using PizzapanDataAccessLayer.Concrete;
using PizzapanDataAccessLayer.Repositories;
using PizzapanEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzapanDataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public List<Contact> GetContactBySubjectWithTesekkur()
        {
            using var context = new Context();
            var values = context.Contacts.Where(x=>x.Subject == "Teşekkür").ToList();
            return values;
        }
    }
}

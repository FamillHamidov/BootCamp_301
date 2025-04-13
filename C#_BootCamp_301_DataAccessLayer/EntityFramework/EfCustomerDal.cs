using C__BootCamp_301_DataAccessLayer.Abstract;
using C__BootCamp_301_DataAccessLayer.Repositories;
using C__BootCamp_301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__BootCamp_301_DataAccessLayer.EntityFramework
{
   public class EfCustomerDal:GenericRepository<Customer>, ICustomerDal
    {
    }
}

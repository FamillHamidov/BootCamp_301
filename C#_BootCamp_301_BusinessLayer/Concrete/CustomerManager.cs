using C__BootCamp_301_BusinessLayer.Abstract;
using C__BootCamp_301_DataAccessLayer.Abstract;
using C__BootCamp_301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__BootCamp_301_BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }
        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }
        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }
        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
        }
        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}

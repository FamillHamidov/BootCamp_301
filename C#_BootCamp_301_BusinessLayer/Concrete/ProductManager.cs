﻿using C__BootCamp_301_BusinessLayer.Abstract;
using C__BootCamp_301_DataAccessLayer.Abstract;
using C__BootCamp_301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__BootCamp_301_BusinessLayer.Concrete
{
    public class ProductManager : IProductService
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
        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }
        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }
        public List<object> TGetProductWithCategory()
        {
            return _productDal.GetProductWithCategory();
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

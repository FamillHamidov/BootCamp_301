using C__BootCamp_301_DataAccessLayer.Abstract;
using C__BootCamp_301_DataAccessLayer.Context;
using C__BootCamp_301_DataAccessLayer.Repositories;
using C__BootCamp_301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__BootCamp_301_DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductWithCategory()
        {
           var context=new CampContext();
            var categories=context.Products
                .Select(x=> new
                {
                    ProductId=x.Id,
                    ProductName=x.ProductName,
                    ProductStock=x.ProductStock,
                    ProductPrice=x.ProductPrice,
                    CategoryName=x.Category.CategoryName
                }).ToList();
            return categories.Cast<object>().ToList();
        }
    }
}

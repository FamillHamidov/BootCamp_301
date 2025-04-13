using C__BootCamp_301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__BootCamp_301_BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<object> TGetProductWithCategory();
    }
}

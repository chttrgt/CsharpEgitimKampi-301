using CEK301.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEK301.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<object> TGetProductsByCategory();
    }
}

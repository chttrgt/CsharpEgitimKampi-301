using CEK301.DataAccessLayer.Abstract;
using CEK301.DataAccessLayer.Context;
using CEK301.DataAccessLayer.Repositories;
using CEK301.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEK301.DataAccessLayer.EntityFramework
{

    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsByCategory()
        {
            var context = new CampContext();
            var products = context.Products.Select(x => new
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDescription = x.ProductDescription,
                CategoryName = x.Category.CategoryName

            }).ToList();

            return products.Cast<object>().ToList();
        }
    }
}

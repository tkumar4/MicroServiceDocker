using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DataLayer;
using Application.DataLayer.DataObjects;


namespace Application.Services
{
    public class ProductService
    {
        ProductContext _db;
        public ProductService(ProductContext db)
        {
            _db = db;
        }
        public Product  GetProduct(int ID)
        {
           Product obj = _db.Products.FirstOrDefault(o => o.ID == ID);
            return obj;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _db.Products.ToList();
        }
    }
}

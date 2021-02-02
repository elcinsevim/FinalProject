
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {

            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitInStock=15,UnitPrice=15 },
             new Product{ProductId=2,CategoryId=1,ProductName="kitap",UnitInStock=500,UnitPrice=3 },
              new Product{ProductId=3,CategoryId=2,ProductName="tabak",UnitInStock=150,UnitPrice=2 },
               new Product{ProductId=4,CategoryId=2,ProductName="klavye",UnitInStock=85,UnitPrice=15 },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete =_products.SingleOrDefault(p=>p.ProductId==product.ProductId);

                 _products.Remove(productToDelete); 
        }
       

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {

            //gönderdiğim ürün ıd sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
       
    }
}

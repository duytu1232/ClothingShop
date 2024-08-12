using ClothingShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.IteratorPattern
{
    public class ProductList1 : Aggregate<Product>
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Iterator<Product> CreateIterator()
        {
            return new ProductIterator(this);
        }
    }
}
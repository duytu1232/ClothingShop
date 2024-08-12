using ClothingShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.IteratorPattern
{
    public class ProductIterator : Iterator<Product>
    {
        public ProductIterator() { }
        private ProductList1 _productList1;
        private int _index = 0;

        public ProductIterator(ProductList1 productList)
        {
            _productList1 = productList;
        }

        public bool HasNext()
        {
            return _index < _productList1._products.Count;
        }

        public Product Next()
        {
            if (HasNext())
            {
                Product nextProduct = _productList1._products[_index];
                _index++;
                return nextProduct;
            }
            else
            {
                throw new InvalidOperationException("No more elements in the list.");
            }
        }
    }
}
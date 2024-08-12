using ClothingShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingShop.IteratorPattern
{
    public class ProductController2 : Controller
    {
        // GET: ProductController2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayProducts()
        {
            // Tạo danh sách sản phẩm
            var productList = new ProductList1();
            productList.AddProduct(new Product("Áo thun", 15.99));
            productList.AddProduct(new Product("Quần jeans", 29.99));
            productList.AddProduct(new Product("Giày thể thao", 39.99));

            // Tạo iterator và duyệt qua danh sách sản phẩm để hiển thị trên giao diện người dùng
            var iterator = productList.CreateIterator();
            while (iterator.HasNext())
            {
                var product = iterator.Next();
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }

            return View();
        }
    }
}
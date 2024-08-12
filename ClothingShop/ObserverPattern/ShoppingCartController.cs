using ClothingShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingShop.ObserverPattern
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController()
        {
            _shoppingCart = new ShoppingCart();
            var cartDisplay = new CartDisplay(_shoppingCart);
        }

        public ActionResult AddToCart(int productId)
        {
            // Lấy thông tin sản phẩm từ cơ sở dữ liệu
            Product product = GetProductById(productId);

            // Thêm sản phẩm vào giỏ hàng
            _shoppingCart.AddProduct(product);

            return RedirectToAction("Index", "Home");
        }

        private Product GetProductById(int productId)
        {
            // Lấy thông tin sản phẩm từ cơ sở dữ liệu dựa trên ID
            // Trong ví dụ này, tôi sẽ giả định có một phương thức để làm điều này.
            return new Product(productId, "Product Name", 10.99); // Giả sử đã lấy được thông tin sản phẩm
        }
    }
}
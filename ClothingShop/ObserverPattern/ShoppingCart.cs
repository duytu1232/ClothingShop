using ClothingShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.ObserverPattern
{
    public class ShoppingCart : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
            Notify();
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
            Notify();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }

    // Lớp cho giao diện người dùng (Observer)
    public class CartDisplay : IObserver
    {
        private ShoppingCart _shoppingCart;

        public CartDisplay(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
            _shoppingCart.Attach(this);
        }

        public void Update()
        {
            // Logic để cập nhật giao diện người dùng khi giỏ hàng thay đổi
            Console.WriteLine("Cart updated. Refreshing display...");
        }
    }

}
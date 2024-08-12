using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.ObserverPattern
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
    // Interface cho Observer
    public interface IObserver
    {
        void Update();
    }
}
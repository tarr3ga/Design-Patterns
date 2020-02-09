using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObserver
    {
        void update(int temp, int humidity, int pressure);
    }
}

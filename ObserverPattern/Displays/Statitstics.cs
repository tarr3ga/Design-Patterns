using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class Statitstics : IObserver, IDisplayElement
    {
        private int temperature;
        private int humidity;
        private ISubject weatherData;

        public Statitstics(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Statistics: " + temperature + "F Degrees and " + humidity + "% Humidity");
        }

        public void update(int temp, int humidity, int pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}

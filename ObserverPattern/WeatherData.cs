using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int temperature;
        private int humidity;
        private int pressure;

        public int Temperature { get => temperature; set => temperature = value; }
        public int Humidity { get => humidity; set => humidity = value; }
        public int Pressure { get => pressure; set => pressure = value; }

        public WeatherData()
        {

        }

        public WeatherData(int temperature, int humidity, int pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurmentsChanged();
        }

        public void setMeasurements(int temperature, int humidity, int pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurmentsChanged();
        }

        public void measurmentsChanged()
        {
            notifyObserver();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);

            if (i >= 0)
                observers.RemoveAt(i);
        }

        public void notifyObserver()
        {
            foreach(IObserver o in observers)
            {
                o.update(temperature, humidity, pressure);
            }
        }
    }
}

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();

            CurrentConditions current = new CurrentConditions(data);
            Forecast forecast = new Forecast(data);
            Statitstics statistics = new Statitstics(data);

            data.setMeasurements(75, 54, 2);
            data.setMeasurements(80, 48, 3);
            data.setMeasurements(65, 40, 2);
        }
    }
}

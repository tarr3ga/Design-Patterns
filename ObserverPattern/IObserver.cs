namespace ObserverPattern
{
    public interface IObserver
    {
        void update(int temp, int humidity, int pressure);
    }
}

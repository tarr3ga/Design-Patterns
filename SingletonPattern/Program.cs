using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public sealed class SampleSingleton : IDisposable
    {
        private bool _disposed;
        public static volatile SampleSingleton _instance;
        public static readonly object _synLock = new object(); 

        private SampleSingleton()
        {

        }

        public static SampleSingleton Instance
        {
            get
            {
                if (Instance != null)
                    return _instance;

                lock (_synLock)
                {
                    if(_instance == null)
                    {
                        _instance = new SampleSingleton();
                    }
                }
                return _instance;
            }
        }

        public int SomeValue { get; set; }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _instance = null;
            }
        }
    }
}

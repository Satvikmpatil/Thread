class Program4
{
    private static readonly object _lock = new();
    private static readonly Mutex _mutex = new();

    public static void Main(String[] args)
    {
        // Using lock
        void MyFunction()
        {
            lock (_lock)
            {
                Console.WriteLine("Hi (lock)");
            }
        }

        // Using Mutex
        void MyFunction2()
        {
            _mutex.WaitOne();   // Acquire
            Console.WriteLine("Hi sam (mutex)");
            _mutex.ReleaseMutex();  // Release
        }

        Thread myThread = new Thread(new ThreadStart(MyFunction));
        Thread myThread2 = new Thread(new ThreadStart(MyFunction2));
        myThread.Start();
        myThread2.Start();
        Console.WriteLine("Hi ram");
        myThread.Join();
        myThread2.Join();
    }
}

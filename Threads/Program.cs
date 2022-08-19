namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread myThread1 = new Thread(Print1); //ThreadStart delegate
            //Thread myThread1 = new Thread(new ThreadStart(Print1)); //Same as above
            Thread myThread2 = new Thread(Print2); //ParameterizedThreadStart delegate
            //Thread myThread2 = new Thread(new ParameterizedThreadStart(Print2)); //Same as above
            myThread1.Start();
            myThread2.Start(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                Thread.Sleep(300);
            }
        }
        static void Print1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"First Thread: {i}");
                Thread.Sleep(400);
            }
        }
        static void Print2(object a) //Only with object
        {
            for (int i = 0; i < (int)a; i++)
            {
                Console.WriteLine($"Second Thread: {i}");
                Thread.Sleep(500);
            }
        }
    }
}
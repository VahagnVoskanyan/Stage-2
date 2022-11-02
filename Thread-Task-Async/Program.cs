namespace Thread_Task_Async
{
    internal class Program
    {
        static void Method1()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Method-1: " + i);
                Thread.Sleep(30);
            }
            Console.WriteLine("Methooooooooood-1 end.");
        }
        static void Method2()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("\nMeeeeeeeeeeeethoooooooooooooood-2: " + i);
                Thread.Sleep(30);
            }
            Console.WriteLine("Methooooooooood-2 end.");
        }
        static void TaskMethod1()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("\nTaskMethod--1: " + i);
                Thread.Sleep(40);
            }
            Console.WriteLine("TaskMethooo00000ooood--1 end.");
        }
        static void TaskMethod2()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("\nTaskMethod--2: " + i);
                Thread.Sleep(40);
            }
            Console.WriteLine("TaskMethooo00000ooood--2 end.");
        }
        static void ThreadMethod1()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("\nThreadMethod---1: " + i);
                Thread.Sleep(50);
            }
            Thread.CurrentThread.Name = "Thread-1";
            Console.WriteLine("ThreadMethooo00000oooodddddd---1 end.");
        }
        static void ThreadMethod2()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("\nThreadMethod---2: " + i);
                Thread.Sleep(50);
            }
            Thread.CurrentThread.Name = "Thread-2";
            Console.WriteLine("ThreadMethooo00000oooodddddd---2 end.");
        }
        async static Task AsyncMethod1()
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < 40; i++)
                {
                    await Task.Delay(80);
                    Console.WriteLine("\nAsyncMethod----1: " + i);
                }
                Console.WriteLine("AsyncMethooooooooooooooooooooooood----1 end.");
            });
        }
        async static Task AsyncMethod2()
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < 40; i++)
                {
                    await Task.Delay(80);
                    Console.WriteLine("\nAsyncMethod----2: " + i);
                }
                Console.WriteLine("AsyncMethooooooooooooooooooooooood----2 end.");
            });
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => ThreadMethod1());
            Thread thread2 = new Thread(() => ThreadMethod2());

            Method1(); //Async tasks didn't start yet
            Task asynctask1 = AsyncMethod1();
            Task task1 = Task.Run(() => TaskMethod1());
            thread1.Start();
            Task asynctask2 = AsyncMethod2();
            Task task2 = Task.Run(() => TaskMethod2());
            thread2.Start();
            Method2();

            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(20); //This doesn't concern async methods
                Console.WriteLine("\nMain: " + i);
            }
            Console.WriteLine("Maaaaaaaaaaaaaaaaaiiiiiiiiiiiiiiiin end.");

            Task.WaitAll(asynctask1, asynctask2); //Console waits for tasks to end
                                                  //otherwise we won't see tasks work
            Task.WaitAll(task1, task2); //Separated from above for tests
        }
    }
}
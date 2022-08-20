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
            Person person = new Person("Zaven",28);
            Thread myThread3 = new Thread(Print3);
            myThread3.Start(person); //With multiply arguments
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
        static void Print2(object a) //Only with object type argument
        {
            for (int i = 0; i < (int)a; i++)
            {
                Console.WriteLine($"Second Thread: {i}");
                Thread.Sleep(500);
            }
        }
        class Person
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string Name { get; set; }
            public int Age { get; set; }
            public void Print()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
            }
        }
        static void Print3(object a) 
        {
            if (a is Person person)
            {
                for (int i = 0; i < 5; i++)
                {
                    person.Print();
                    Thread.Sleep(600);
                }
            }
        }
    }
}
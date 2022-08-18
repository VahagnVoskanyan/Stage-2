using System.Diagnostics;

namespace Ref_Out_In
{
    struct MyStruct
    {
        public decimal a;
        public decimal b;
        public decimal c;
        public decimal d;
        public decimal e;
    }
    internal class Program
    {
        static void Bar(ref int a)
        {
            a = 5;
        }
        static void Bar1(int[] arr)
        {
            arr[0] = 0;//Changes main arr[0], because array is reference type
            arr = null;//This was the copied link(No exception in Main)
            //arr[1] = 5; //Throws NullReferenceException
        }
        static void Bar2(ref int[] arr)
        {
            arr = null;
        }

        static void Foo1(ref MyStruct myStruct) { }//Here we don't copy 5 decimal fields of MyStruct
        static ref int Bar3(int[] arr)//Returns reference for 'ref' field
        {
            return ref arr[2];
        }
        static void Bar4(out int a)
        {
            //a++; //Compile Error "use of unassigned out parameter 'a'"
            a = 6;
            a++;
        }
        static void Foo2(in MyStruct myStruct) //Here we don't copy 5 decimal fields of MyStruct
                                               //And also we are secured that struct fields won't change
        {
            //myStruct.b = 6; //Compile Error "it is a readonly variable" 
            //myStruct.b++; //Compile Error "it is a readonly variable" 
        }
        static void Foo3(MyStruct myStruct) { }
        static void Main(string[] args)
        {
            int b = 0; //If we don't assign 'b'=> Compile Error "use of unassigned local variable 'a'"
            Bar(ref b);
            Console.WriteLine("b: " + b); //Returns b: 5

            int[] arr = { 1, 2, 3 };
            Bar1(arr);
            Console.WriteLine("arr[0]: " + arr[0]); //Returns arr[0]: 0

            /*Bar2(ref arr);
            Console.WriteLine(arr[0]); //Throws NullReferenceException*/

            ref int c = ref arr[1]; //Now they both shows to the same field
            c = 6; //Changes the arr[1] value
            Console.WriteLine("arr[1]: " + arr[1]); //Returns arr[1]: 6
            arr[1] = 3; //Changes the 'c' value
            Console.WriteLine("c: " + c); //Returns c: 3

            ref int d = ref Bar3(arr);

            int e;
            Bar4(out e); //We don't obliged assign 'e'
            Console.WriteLine("e: " + e); //Returns e: 7

            Bar4(out int f); //We can declare 'f' in method call
            Console.WriteLine("f: " + f); //Returns f: 7

            MyStruct myStruct = new MyStruct();
            Foo2(myStruct); //We don't obliged write 'in' in scopes
            Console.WriteLine("Wait...");

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < int.MaxValue / 2; i++)
            {
                Foo2(myStruct);
            }
            sw.Stop();
            Console.WriteLine("With 'in' keyword: " + sw.ElapsedMilliseconds);
            sw.Restart();
            for (int i = 0; i < int.MaxValue / 2; i++)
            {
                Foo3(myStruct);
            }
            sw.Stop();
            Console.WriteLine("Without 'in' keyword: " + sw.ElapsedMilliseconds);
        }
    }
}
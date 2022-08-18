using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Try_Catch_
{
    internal class Person
    {
        public Person()
        {
            Console.Write("Enter your name : ");
            Name = Console.ReadLine();
            Console.Write("Enter your age : ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter your phone number : 0");
            PhoneNumber = "0" + Console.ReadLine();
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '-' ||
                        value[i] == '$' ||
                        value[i] == '%' ||
                        value[i] == '&')
                    {
                        throw new Exception("Your name is invalid.");
                    }
                }
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16)
                {
                    throw new Exception("You are too small to register here.");
                }
                age = value;
            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length == 9)
                {
                    foreach (char item in value)
                    {
                        if (item < '0' || item > '9')
                        {
                            throw new Exception("Your number must contain only digits");
                        }
                    }
                }
                else { throw new Exception("Your number must contain 9 digits"); }
                phoneNumber = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("You registered successfully.");
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine($"Your phone number is: {phoneNumber}");
        }
    }
}

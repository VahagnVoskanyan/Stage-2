using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCount_delegate_
{
    internal class Salary
    {
        private List<decimal> Decreases = new List<decimal>();
        public void Decreas1(decimal n)
        {
            Decreases.Add(1000);
        }
        public void Decreas2(decimal n)
        {
            Decreases.Add(n * 7 / 100);
        }
        public void Decreas3(decimal n)
        {
            Decreases.Add(n * 9 / 100);
        }
        public void Decreas4(decimal n)
        {
            Decreases.Add(n * 11 / 100);
        }
        public void Result(decimal n)
        {
            foreach (var item in Decreases)
            {
                n -= item;
            }
            Console.WriteLine("The real salary is: " + n);
        }
        public void ShowDecreases()
        {
            Console.WriteLine("Decreases:");
            foreach (var item in Decreases)
            {
                Console.WriteLine(item);
            }
        }
    }
}

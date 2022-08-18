using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCount_delegate_event_
{
    internal class Salary
    {
        public delegate void SalaryCounter(decimal n); //Delegate
        event SalaryCounter SalaryCounterEvent; //Event
        SalaryCounter count; //Delegate instance
        public Salary()
        {
            count += Decreas1;
            count += Decreas2;
            count += Decreas3;
            count += Decreas4;
            count += Result;
            SalaryCounterEvent = count;
        }
        public void CountRealSalary(decimal n)
        {
            SalaryCounterEvent(n);
        }
        private List<decimal> Decreases = new List<decimal>();
        private void Decreas1(decimal n)
        {
            Decreases.Add(1000);
        }
        private void Decreas2(decimal n)
        {
            Decreases.Add(n * 7 / 100);
        }
        private void Decreas3(decimal n)
        {
            Decreases.Add(n * 9 / 100);
        }
        private void Decreas4(decimal n)
        {
            Decreases.Add(n * 11 / 100);
        }
        private void Result(decimal n)
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

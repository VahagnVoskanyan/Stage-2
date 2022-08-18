namespace SalaryCount_delegate_
{
    internal class Program
    {
        public delegate void SalaryCounter(decimal n);
        static void Main(string[] args)
        {
            Salary salary = new Salary();
            SalaryCounter count = salary.Decreas1;
            count += salary.Decreas2;
            count += salary.Decreas3;
            count += salary.Decreas4;
            count += salary.Result;
            count(210_000);
            salary.ShowDecreases();
        }
    }
}
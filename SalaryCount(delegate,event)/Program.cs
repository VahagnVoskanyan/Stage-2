namespace SalaryCount_delegate_event_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();
            salary.CountRealSalary(210_000);
            salary.ShowDecreases();
        }
    }
}
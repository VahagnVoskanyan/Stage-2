namespace Registration_Try_Catch_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                Console.WriteLine("\n");
                person.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nThank you for using this app.");
            }
        }
    }
}
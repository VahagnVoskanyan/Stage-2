namespace Async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = MethodAsync();
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("Maaaaaaaaaaaaaaaaain: " + i);
            }
            task.Wait(); //Waiting for async method ending before program ending
        }
        async static Task MethodAsync()
        {
            await Task.Run(() =>  //Main doesn't wait this to end
            {
                for (int i = 0; i < 300; i++)
                {
                    Console.WriteLine("Method: " + i);
                }
                Console.WriteLine("Methooooooooooooooooooooooood end.");
            });
        }
    }
}
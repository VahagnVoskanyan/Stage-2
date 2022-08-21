namespace Async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = MethodAsync();
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(10); //This doesn't concern MethodAsync()
                Console.WriteLine("Maaaaaaaaaaaaaaaaain: " + i);
            }
            task.Wait(); //Waiting for async method ending before program ending
        }
        async static Task MethodAsync()
        {
            await Task.Run(async () =>  //Main doesn't wait this to end
            {
                for (int i = 0; i < 220; i++)
                {
                    await Task.Delay(10); //Doesn't work without 'await'
                    //Thread.Sleep(10); //Similar with above but they aren't the same
                    Console.WriteLine("Method: " + i);
                }
                Console.WriteLine("Methooooooooooooooooooooooood end.");
            });
        }
    }
}
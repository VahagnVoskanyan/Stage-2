namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"D:\New Folder");
            if (Directory.Exists(@"D:\Desktop files\QT"))
            {
                Console.WriteLine("true");
            }
            string[] str = Directory.GetDirectories(@"D:\Desktop files\QT");
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }
    }
}
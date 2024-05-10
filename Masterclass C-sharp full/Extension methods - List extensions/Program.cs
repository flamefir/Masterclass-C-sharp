using Extension_methods___List_extensions.Extensions;

namespace Extension_methods___List_extensions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var list = new List<int> { 1};
            var result = list.TakeEverySecond();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }



}

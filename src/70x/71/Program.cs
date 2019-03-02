using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp71
{
    class Customer { }

    class Program
    {
        static async Task Go()
        {
            await Task.Run(() => Console.WriteLine("Hello, world!"));
        }

        static async Task Main(string[] args)
        {
            // async main
            await Go();

            // default literal
            Customer customer = default;
            Console.WriteLine(customer == null);

            // tuple
            var count = 5;
            var label = "Five";
            var pair = (count, label);
            Console.WriteLine(pair.count == 5);
            Console.WriteLine(pair.label == "Five");
        }
    }
}

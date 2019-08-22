using System;

namespace C80Indices {
    class Program {
        static void Main(string[] args) {
            var data = new string[] {
                "1",
                "2"
            };

            var x = data[^1];
            Console.WriteLine(x);
        }
    }
}

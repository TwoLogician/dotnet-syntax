using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;


namespace C80Indices {
    class Program {
        static string ToString(object obj) => JsonSerializer.Serialize(obj);

        static void A() {
            var data = new string[] {
                "1",
                "2"
            };

            var x = data[^1];
            Console.WriteLine(x);
        }

        static void B() {
            var str = "Hello, world!";
            var index = 0..^1;
            var sub = str[index];
            Console.WriteLine(sub);
        }

        static void C() {
            var str = "Hello, world!";
            var sub = str[1..^1];
            Console.WriteLine(ToString(sub));
        }

        static void D() {
            var a = new List<int> { 1, 2, 3, 4 }.ToArray();
            var sub = a[0..^1];
            Console.WriteLine(ToString(sub));
        }

        static void E() {
            // var a = 1..10:2;
            var a = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sub = a[0..8];
            foreach (var item in sub) {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args) {
            E();
        }
    }
}

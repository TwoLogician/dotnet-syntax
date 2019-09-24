using System;
using System.Text.Json;

namespace C30JsonApi {
    class O {
        public int A { set; get; }
        public int B { set; get; }
    }

    class Program {
        static void Main(string[] args) {
            var a = new {
                A = 100,
                B = 200
            };

            var json = JsonSerializer.Serialize(a);
            Console.WriteLine(json);

            var obj = JsonSerializer.Deserialize<O>(json);
            Console.WriteLine($"{obj.A} {obj.B}");
        }
    }
}

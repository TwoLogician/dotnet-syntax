using System;

namespace NullReference {
    class Program {
        static void Main(string[] args) {
            // string? s = null;
            string s = null;
            // Console.WriteLine(s);
            string[] names = {
                "Archimedes", "Pythagoras", "Euclid", "Socrates", "Plato"
            };

            Console.WriteLine(s);

            // foreach (var name in names[1..4]) {
            //     Console.WriteLine(name);
            // }
        }
    }
}

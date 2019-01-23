using System;

namespace NullReference {
    class Program {
        static void A(string? s) {
            s = null;
        }

        static void B(string s) {
            s = null;
        }

        static void Main(string[] args) {
            string[] names = {
                "Archimedes", "Pythagoras", "Euclid", "Socrates", "Plato"
            };
            Console.WriteLine(names.Length);
        }
    }
}

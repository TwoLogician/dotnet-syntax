using System;

namespace C80ReadOnly {
    struct Person {
        int a;

        public Person(int a) {
            this.a = a;
        }

        public readonly string A() {
            // a = 200;
            return "a";
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}

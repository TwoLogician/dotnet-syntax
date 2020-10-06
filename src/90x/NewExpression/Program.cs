using System;

namespace NewExpression {
    class Person {
        public string Name { set; get; }
    }

    class Program {
        static void Go(Person p) {

        }

        static void Main(string[] args) {
            Person s = new();

            Go(new() { Name = "Hello" });
        }
    }
}

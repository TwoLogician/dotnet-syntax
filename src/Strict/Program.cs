using System;

namespace Strict {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            // 1) Lock null
            lock (null) {

            }

            // 3) Struct
            var baz = Guid.NewGuid();
            if (baz == null) {

            }
        }
    }

    // 2) Static class
    static class Foo {
        static void Bar(object baz) {
            if (baz is Foo) {

            }
        }
    }

    // 4) Enum
    enum Cat { Fuchsia, White }
    class CatC {
        public void Bar() {
            var foo = 1 - Cat.Fuchsia;
            Console.WriteLine(foo);
        }

    }
}


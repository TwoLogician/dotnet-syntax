using System;

namespace Features {
    class FRange {
        public static void Range1() {
            var array = new string[] {
                "Item1",
                "Item2",
                "Item3",
                "Item4",
                "Item5",
            };

            Console.WriteLine("-- [1..3]");
            foreach (var item in array[1..3]) {
                Console.WriteLine(item);
            }

            Console.WriteLine("-- [1..]");
            foreach (var item in array[1..]) {
                Console.WriteLine(item);
            }

            Console.WriteLine("-- [..]");
            foreach (var item in array[..]) {
                Console.WriteLine(item);
            }

            Console.WriteLine("-- [..3]");
            foreach (var item in array[..3]) {
                Console.WriteLine(item);
            }

            Console.WriteLine("-- [1..^1]");
            foreach (var item in array[1..^1]) {
                Console.WriteLine(item);
            }
        }

        public static void Range2() {
            var array = new string[] {
                "Item1",
                "Item2",
                "Item3",
                "Item4",
                "Item5",
            };
            var r = 1..5;
            var r2 = 1..^1;
        }

        public static void Range3() {
            var a = "1234567890"[0..^1];
            Console.WriteLine(a);
        }
    }
}

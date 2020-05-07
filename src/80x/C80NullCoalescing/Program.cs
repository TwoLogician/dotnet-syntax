using System;
using System.Collections.Generic;

namespace C80NullCoalescing {
    class Program {

        static void A() {
            var isActive = true;
            var isDeleted = false;
            var show = (isActive, isDeleted) is (true, false) ? false : false;
            Console.WriteLine(show);
        }

        static void Main(string[] _) {

            List<int> a = null;
            a ??= new List<int>();

            List<int> x = null;
            A();
        }

    }
}
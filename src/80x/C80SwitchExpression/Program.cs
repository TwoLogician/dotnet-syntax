using System;

namespace C80SwitchExpression {

    class Person {
        public string Name { set; get; }
    }

    class Program {
        static void A() {
            var token = (true, true);
            var rs = token switch
            {
                (true, true) => true,
                (true, false) => false,
                (false, true) => false,
                (false, false) => false
            };
        }

        static string B(Person p) {
            return p?.Name switch
            {
                "wk" => "Hello, wk",
                _ => "?"
            };

        }

        static string C(Person p) {
            var text2 = p switch
            {
                { Name: "wk" } => "A",
                _ => "?"
            };
            return text2;
        }

        static void Main(string[] args) {
            var a = B(null);
            var c = C(new Person { Name = "wk" });
            Console.WriteLine(a);
            Console.WriteLine(c);
        }
    }
}

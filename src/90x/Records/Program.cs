using System;
using System.Text;

namespace Records {
    public record Person {
        public string LastName { get; set; }
        public string FirstName { get; }
        public Person(string first, string last) => (FirstName, LastName) = (first, last);

    }

    public record Teacher : Person {
        public string Subject { get; }
        public Teacher(string first, string last, string sub) :
            base(first, last) => Subject = sub;
    }

    class Program {
        static void Main(string[] args) {
            var p1 = new Person("wk", "kw");
            var p2 = new Person("wk", "kw");
            Console.WriteLine(p1 == p2);

            var p3 = p1 with { LastName = "kk" };
        }
    }
}

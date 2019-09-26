using System;

namespace C80PropertyPattern {
    class Address {
        public string State { set; get; }
        public string Country { set; get; }
    }

    class Program {
        static decimal Compute(Address location, decimal price) =>
            location switch
            {
                { State: "WA", Country: "Thailand" } => price * 5M,
                { State: "WA" } => price * 0.5M,
                _ => 0M
            };

        static void Main(string[] args) {
            var p1 = Compute(new Address { State = "WA" }, 10);
            var p2 = Compute(new Address { State = "WA", Country = "Thailand" }, 10);

            Console.WriteLine(p1);
            Console.WriteLine(p2)
        }
    }
}

using System;
using System.Threading.Tasks;

namespace Features {
    class FPattern {
        public static string Display(object o) {
            return o switch
            {
                DateTime d => d.ToString("dd/MM/yyyy"),
                int i => i.ToString("D10"),
                _ => o.ToString()
            };
        }
    }

    class Program {
        static async Task Main(string[] args) {

            var r1 = FPattern.Display(DateTime.Now);
            var r2 = FPattern.Display(1000);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
}

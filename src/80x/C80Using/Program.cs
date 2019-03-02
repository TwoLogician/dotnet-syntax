using System;
using System.IO;

namespace C80Using {
    class A7 : IDisposable {
        public void Dispose() {
        }
    }

    public class A8 {
        public void Dispose() {

        }
    }

    class Program {
        static void Main(string[] args) {
            var bytes = new byte[] { 1, 2, 3, 4 };
            using var memory = new MemoryStream(bytes);

            using var a7 = new A7();
            //using var a8 = new A8();
        }
    }
}

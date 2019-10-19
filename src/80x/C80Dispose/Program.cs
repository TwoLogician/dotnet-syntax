using System;

namespace C80Dispose {
    class A8 {
        public void Dispose() { }
    }
    class Program {
        static void Main(string[] args) {
            using var a8 = new A8();
        }
    }
}

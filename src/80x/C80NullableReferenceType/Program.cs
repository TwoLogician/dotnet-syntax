#nullable enable

using System;

namespace C80NullableReferenceType {
    class A {
        public string F1 { set; get; } = "Hello";
        public string F2 { set; get; } = "Hello";
    }
    class Program {
        static int Length(string s) {
            return s.Length;
        }

        static void Main(string[] args) {
            string s = "Hello";
            var length = Length(s);
        }
    }
}

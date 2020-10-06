using System;

namespace PatternMatching {
    static class Extensions {
        public static bool IsLetter(this char c) =>
            c is >= 'a' and <= 'z' or >= 'a' and <= 'Z';

        public static bool IsLetterOrSeparator(this char c) =>
            c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
    }
    class Program {
        static void Main(string[] args) {
            string e = null;
            if (e is not null) {

            }
        }
    }
}

using System;

namespace C80SwitchExpression {
    class Program {
        static void Main(string[] args) {
            var token = (true, true);
            var rs = token switch
            {
                (true, true) => true,
                (true, false) => false,
                (false, true) => false,
                (false, false) => false
            };
        }
    }
}

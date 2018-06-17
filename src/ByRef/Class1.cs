using System;

namespace ByRef
{
    public class MyInt {
        public static bool TryAdd(string data1, string data2,  out int result) {
            var d1 = Int32.TryParse(data1, out var value1);
            var d2 = Int32.TryParse(data2, out var value2);
            if (d1 && d2) {
                result = value1 + value2;
                return true;
            } else {
                result = 0;
                return false;
            }
        }
    }
}

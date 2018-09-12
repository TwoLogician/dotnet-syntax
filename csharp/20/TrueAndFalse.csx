// https://www.tabsoverspaces.com/233707-true-and-false-operators-in-csharp

class TF {
    public int Value { get; }
    public TF(int value) {
        Value = value;
    }

    public static bool operator true(TF value) {
        Console.WriteLine("true");
        return value.Value == 0;
    }

    public static bool operator false(TF value) {
        Console.WriteLine("false");
        return !(value.Value == 0);
    }
    public static TF operator &(TF a, TF b) => null;
}

var value = new TF(0);
if (value) {
    Console.WriteLine("OK");
}

// T.false(x) ? x : T.& (x, y)
// if (value && value) {
//     Console.WriteLine("No way");
// }
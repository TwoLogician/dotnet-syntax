public class App {
    public const Int32 I = 100;
    public static Boolean II = true;
    public static Boolean B = true;
    public static String S = "Hi";
    public static StringBuilder SB = new StringBuilder();
}

void Check<T>(ref T a, ref T b) {
    var rs = Object.ReferenceEquals(a, b);
    Console.WriteLine(rs);
}

Console.WriteLine(object.ReferenceEquals(App.B, App.B));
Console.WriteLine(object.ReferenceEquals(App.I, App.I));
Console.WriteLine(object.ReferenceEquals(App.S, App.S));
Console.WriteLine(object.ReferenceEquals(App.SB, App.SB));

object a = 100;
Check(ref App.II, ref App.II);
Check(ref a, ref a);
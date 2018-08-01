
public class B {
    public B(int i, out int j) {
        j = i;
    }
}


var b = new B(100, out var i);
Console.WriteLine(i);
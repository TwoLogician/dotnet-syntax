
public abstract class Addable {
    public object Value { get; private set; }
    public Addable(object o) => Value = o;
    public static Addable operator +(Addable a, Addable b) => a.Add(b);
    public abstract Addable Add(Addable input);
}

class D : Addable {
    public D(double obj) : base(obj) {
    }
    public override Addable Add(Addable input) {
        if (input.Value is double d) {
            return new D(d + (double)this.Value);
        }
        return null;
    }
}


T Add<T>(T a, T b) where T : Addable => (T)a.Add(b);

var rs = Add(new D(100), new D(200));
Console.WriteLine(rs.Value);

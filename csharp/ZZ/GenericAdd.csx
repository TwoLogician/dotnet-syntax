class MyNumber {
    public int Value { get; }
    public MyNumber(int a) => Value = a;
    public static MyNumber operator +(MyNumber a, MyNumber b) { return new MyNumber(a.Value + b.Value); }
}

class MyNumber2 : MyNumber {
    public MyNumber2(int n2) : base(n2 + 1) { }
}

void A1() {
    MyNumber Add0(MyNumber a, MyNumber b) {
        return a + b;
    }

    T Add<T>(T a, T b) where T : MyNumber {
        return (T)(a + b);
    }

    var rs = Add(new MyNumber2(100), new MyNumber2(200)); // Unable to cast object of type 'MyNumber' to type 'N2'
    Console.WriteLine(rs.Value);
}

class Addable {
    public int Value { get; private set; }
    public Addable(int value) => Value = value;
    public void Add(int a) {
        Value = Value + a;
    }
}

class Number2 : Addable {
    public Number2(int value) : base(value) { }
}

T Add<T>(T number, int value) where T : Addable {
    number.Add(value);
    return number;
}

var rs = Add(new Addable(100), 100);
var rs2 = Add(new Number2(100), 100);

Console.WriteLine(rs.Value);
Console.WriteLine(rs2.Value);


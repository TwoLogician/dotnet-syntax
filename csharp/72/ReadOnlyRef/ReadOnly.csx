class A {
    public int F { set; get; }
}

class C {
    private DateTime origin = DateTime.Now;
    private A a = new A();

    public ref readonly DateTime Origin => ref origin;
    public ref readonly A A => ref a;

    public int P1 { set; get; }
}

void check(in C c) {
    c.P1 = 200;
    c.A.F = 100;
    // c = new C();
    // c.Origin = DateTime.Now;
}

var c = new C();
check(c);

Console.WriteLine(c.P1);
Console.WriteLine(c.A);
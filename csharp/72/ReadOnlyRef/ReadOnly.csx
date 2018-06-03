class C {
    private DateTime origin = DateTime.Now;
    public ref readonly DateTime Origin => ref origin;
    public int P1 { set; get; }
}

void A(in C c) {
    c.P1 = 200;
    // c = new C();
    // c.Origin = DateTime.Now;
}

var c = new C();
A(c);

Console.WriteLine(c.P1);
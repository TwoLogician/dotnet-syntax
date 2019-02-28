class C {
    public int A { set; get; }
}

struct S {
    public S(C c) => C = c;
    public C C { set; get; }
}

void F1(S s) {
    s.C.A = 200;
}

var s = new S(new C { A = 100 });

Console.WriteLine(s.C.A);

F1(s);
Console.WriteLine(s.C.A);


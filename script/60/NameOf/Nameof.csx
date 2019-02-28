class C {
    public int A { set; get; }
    public int B { set; get; }
}

Console.WriteLine(nameof(C.A));
Console.WriteLine(nameof(C.B));

var a = new C();
Console.WriteLine(nameof(a.A));
Console.WriteLine(nameof(a.B));
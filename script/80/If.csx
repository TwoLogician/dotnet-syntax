var a = "1111";

if (a is string { Length: 4 } b) {
    Console.WriteLine("4");
}


if (a is { Length: 4, }) {
    Console.WriteLine("4");
}


class C {
    public int A { set; get; }
    public int D { set; get; }
}

var c = new C { A = 100, D = 200 };
var text = c is { A: 100, D: 200 } ? "True" : "False";

Console.WriteLine(text);
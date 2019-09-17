
class A {
    public List<String> F { set; get; } = new List<string>();
}

var a = new A {
    F = { "A", "B", "C" }
};

Console.WriteLine(a.F.Count);
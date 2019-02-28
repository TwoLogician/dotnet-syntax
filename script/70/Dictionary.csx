
var dict = new Dictionary<string, string> {
    ["A"] = "Aaa",
    ["B"] = "Bbb"
};

var (a, b) = dict.First();
Console.WriteLine($"{a} {b}");
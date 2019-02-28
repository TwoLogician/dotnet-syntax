using System.IO;

void Test() {
    var a = System.IO.Path.GetInvalidFileNameChars();

    Console.WriteLine(a.Count());
    Console.WriteLine(string.Concat(a));
}

string Clean(string input) {
    var chars = Path.GetInvalidFileNameChars();
    return chars.Aggregate(input, (acc, x) => acc.Replace($"{x}", "_"));
}

Console.WriteLine(Clean("::::a.txt"));
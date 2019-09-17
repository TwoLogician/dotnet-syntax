using System.IO;

void A() {
    using var f = new FileStream("README.md", FileMode.Open, FileAccess.Read);
    Console.WriteLine($"{f.ReadByte()}");
}

A();
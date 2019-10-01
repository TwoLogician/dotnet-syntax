var a = "1111";

if (a is string { Length: 4 } b) {
    Console.WriteLine("4");
}


if (a is { Length: 4, }) {
    Console.WriteLine("4");
}
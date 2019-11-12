#! "netcoreapp3.0"

List<string> list = null;

if (list?.Any() == false) {
    Console.WriteLine("1. Do nothing");
} else {
    Console.WriteLine("2. Doing ...");
}
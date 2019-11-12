#! "netcoreapp3.0"

List<string> list = null;

if (list?.Any() == false) {
    Console.WriteLine("1. Do nothing");
} else {
    Console.WriteLine("2. Doing ...");
}


if (null == true) {
    Console.WriteLine("null == true");
} else if (null == false) {
    Console.WriteLine("null == false");
}
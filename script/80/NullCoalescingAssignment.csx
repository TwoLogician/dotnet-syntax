#! "netcoreapp3.0"

void A() {
    List<int> numbers = null;
    numbers ??= new List<int>();
}
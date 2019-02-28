void f() {
    var a = 100;
    ref var b = ref a;
    b = 200;

    Console.WriteLine($"a = b {a == b}");
    Console.WriteLine($"reference = { Object.ReferenceEquals(a, b)}");
}

void ternary() { 
    var a = 100;
    var c = 500;
    var max = true;
    ref var b = ref (max) ? ref a : ref c; 
    Console.WriteLine($"a = b {b == a}");
    Console.WriteLine($"reference = {Object.ReferenceEquals(a,b)}");
}

f();
ternary();
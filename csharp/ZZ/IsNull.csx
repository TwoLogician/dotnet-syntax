
class A {
    public static bool operator ==(A a, A b) => false;
    public static bool operator !=(A a, A b) => true;
}

A a = null;

if (a != null) {
    Console.WriteLine("a is not null");
}

if (a is null) {
    Console.WriteLine("a is null");
}

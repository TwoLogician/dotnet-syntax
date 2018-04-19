using System;
using System.Runtime.InteropServices;

struct Test1 {
    byte b1;
    double d1;
    byte b2;
    double d2;
    byte b3;
}

struct Test2 {
    double d1;
    double d2;
    byte b1;
    byte b2;
    byte b3;
}

public class Test {
    public static void Size() {
        Console.WriteLine(Marshal.SizeOf(new Test1()));
        Console.WriteLine(Marshal.SizeOf(new Test2()));
    }
}
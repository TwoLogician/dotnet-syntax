using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
class MyClass {
    private int a;
    private int c;
    private int d;
    public string A(int x) => x.ToString("D10");
}

var rs = Marshal.SizeOf(typeof(MyClass));
Console.WriteLine(rs);
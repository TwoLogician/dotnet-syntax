#! "netcoreapp3.1"

using System;
using System.Runtime.CompilerServices;

void Log(string message,
    [CallerMemberName] string member = "",
    [CallerLineNumber] int line = 0,
    [CallerFilePath] string file = "") {

    Console.WriteLine("Caller method name - {0}", member);
    Console.WriteLine("Caller line number - {0}", line);
    Console.WriteLine("Caller file path - {0}", file);
}

Log("Hello");
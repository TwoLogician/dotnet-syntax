#! "netcoreapp3.0"

using System;
using System.Runtime.CompilerServices;

void Log(string message, [CallerMemberName] string memberName = "", [CallerLineNumber] int line = 0, [CallerFilePath] string file = "") {
    Console.WriteLine(memberName);
    Console.WriteLine(line);
    Console.WriteLine(file);
}

Log("Hello");
#! "netcoreapp2.0"

var isActive = true;
var isDeleted = false;

var show =
    (isActive, isDeleted) switch {
        (true, false) => true,
        _             => false
    };

Console.WriteLine("a");
Console.WriteLine(show);

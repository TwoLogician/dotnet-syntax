var a = 100;
var b = 200;

string s = true switch
{
    _ when a > 100 => "true",
    _ => "false"
};

Console.WriteLine(s);

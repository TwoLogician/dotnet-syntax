var a = (100, 200) == (100, 200);
Console.WriteLine(a);

class C { }

var c = new C();
Console.WriteLine((c, 100) == (c, 100));

Console.WriteLine((null, null) == (null, null));
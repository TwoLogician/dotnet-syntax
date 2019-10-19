var name = "wk";

var text1 = @$"
    Hello {name}
";

var text2 = $@"
    Hello {name}
";

Console.WriteLine(text1);
Console.WriteLine(text2);
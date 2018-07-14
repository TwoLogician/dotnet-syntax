var two = 2;
Expression<Func<int, int>> expr = x => x * two;

var rs = expr.Compile().Invoke(4);
Console.WriteLine(rs);
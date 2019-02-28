Func<string, bool> whereClause = default(Func<string, bool>);

(bool, string) Default() => default;

var (b, s) = Default();

Console.WriteLine(b);
Console.WriteLine(s);
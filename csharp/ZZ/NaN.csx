
var ins = 1.0 / 0;
var nan = 0.0 / 0.0;

Console.WriteLine(nan);
Console.WriteLine("{0}", ins);


var eq = double.NaN.Equals(double.NaN);
Console.WriteLine(eq);

var eq2 = double.NaN == double.NaN;
Console.WriteLine(eq2);

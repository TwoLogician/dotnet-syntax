#! "netcoreapp2.1"
#r "nuget:wk.LinqWriter,0.2.0"

using LinqWriter;

var a = new[] { 1, 2, 3, 4, 5 };
var aa = a.Prepend(200).Write("aa");
var bb = aa.Append(300).Write("bb");
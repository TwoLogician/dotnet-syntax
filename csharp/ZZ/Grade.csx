#! "netcoreapp2.0"
#r "nuget:BenchmarkDotNet, 0.10.14"

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes.Jobs;

BenchmarkRunner.Run<Grade>();

[InProcess]
[MemoryDiagnoser]
public class Grade {

    /*

     Method | Point |      Mean |     Error |    StdDev | Allocated |
----------- |------ |----------:|----------:|----------:|----------:|
 SwitchCase |    10 | 1.2900 ns | 0.0252 ns | 0.0210 ns |       0 B |
     IfElse |    10 | 1.6268 ns | 0.0519 ns | 0.0460 ns |       0 B |
       Dict |    10 | 5.3253 ns | 0.0251 ns | 0.0196 ns |       0 B |
 SwitchCase |    90 | 0.2526 ns | 0.0176 ns | 0.0147 ns |       0 B |
     IfElse |    90 | 0.2113 ns | 0.0731 ns | 0.1722 ns |       0 B |
       Dict |    90 | 5.2249 ns | 0.0151 ns | 0.0118 ns |       0 B |
     */

    [Params(10, 90)]
    public int Point { set; get; }

    [Benchmark]
    public string SwitchCase() {
        switch (Point) {
            case int s1 when s1 >= 80:
                return "A";
            case int s2 when s2 >= 70:
                return "B";
            case int s3 when s3 >= 60:
                return "C";
            case int s4 when s4 >= 50:
                return "D";
            default: return "F";
        }
    }

    [Benchmark]
    public string IfElse() {
        if (Point >= 80) return "A";
        else if (Point >= 70) return "B";
        else if (Point >= 60) return "C";
        else if (Point >= 50) return "D";
        else return "F";
    }

    Dictionary<int, string> grades = new Dictionary<int, string> {
        {0, "F"},
        {1, "F"},
        {2, "F"},
        {3, "F"},
        {4, "F"},
        { 5, "D"},
        { 6, "C"},
        { 7, "B"},
        { 8, "A"},
        { 9, "A"},
        { 10, "A"},
    };

    [Benchmark]
    public string Dict() {
        var grade = grades[(Point / 10)];
        return grade;
    }
}
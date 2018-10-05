#! "netcoreapp2.1"
#r "nuget:Microsoft.Extensions.DependencyInjection, 2.1.1"

using Microsoft.Extensions.DependencyInjection;

interface ICounter {
    int NextId { get; }
}

class Counter : ICounter {
    private int nextId = 1;
    public int NextId => nextId++;
}

class Program {
    private readonly ICounter counter;
    internal Program(ICounter c) => counter = c;

    internal void Run() {
        Console.WriteLine(counter.NextId);
        Console.WriteLine(counter.NextId);
        Console.WriteLine(counter.NextId);
    }
}

var provider = new ServiceCollection()
        .AddSingleton<ICounter, Counter>()
        .AddScoped<Program>()
        .BuildServiceProvider();

var program = provider.GetService<Program>();
program.Run();
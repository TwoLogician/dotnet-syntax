

async Task<int> F() =>
    _ = await Task.FromResult(100);

Console.WriteLine(await F());
async Task<int> V(int x) => await Task.FromResult(x + 1);

new List<int> { 1, 2, 3, 4, 5 }
.ForEach(async (x) => {
    var rs = await V(x);
    Console.WriteLine(rs);
});

Console.WriteLine("Done");
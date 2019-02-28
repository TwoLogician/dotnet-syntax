

Dictionary<(int, int), Action> Actions =
    new Dictionary<(int, int), Action> {
        [(1, 2)] = () => Console.WriteLine("1-2"),
        [(1, 3)] = () => Console.WriteLine("1-3"),
        [(1, 4)] = () => Console.WriteLine("1-4"),
        [(1, 5)] = () => Console.WriteLine("1-5"),
    };

Actions[(1, 2)]();
Actions[(1, 3)]();
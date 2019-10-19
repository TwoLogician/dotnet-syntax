
int Process(int a) {
    static int Add2(int x) => x + 2;
    return Add2(a);
}

Console.WriteLine(Process(100));
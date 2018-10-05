var a = new[] { "a", "A", "b" };

var aa = a.OrderBy(x => Guid.NewGuid());


class C {
    public string Name { set; get; }
}

TKey KeySelector<T, TKey>(Func<T, TKey> func, T t) {
    return func(t);
}

var key = KeySelector<C, object>(x => x.Name, new C { Name = "Hello" });
Console.WriteLine(key);
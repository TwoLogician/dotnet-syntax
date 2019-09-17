#nullable enable

class A<T> {
    public T Go(T a) {
        return default!;
    }
}

var a = new A<int?>();
Console.WriteLine(a.Go(2));

var b = new A<string?>();
Console.WriteLine(b.Go(null));
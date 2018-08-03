// 1
lock (null) { }

// 2
static class Foo {
    static void Bar(object baz) {
        if (baz is Foo) { }
    }
}

// 3
var baz = Guid.NewGuid();
if (baz == null) { }

// 4
enum Cat { Fuchsia, White };
static void Bar() {
    var foo = 1 - Cat.Fuchsia;
    Console.WriteLine(foo);
}

// 5
var v = new Func<string, string>(x => x);
var y = new Func<string, string>(ref v);
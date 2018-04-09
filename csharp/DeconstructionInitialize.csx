
class A {
    public int Id { set;get;}
    public string Name { set;get;}
    public A(int id, string name) => (Id, Name) = (id, name);
}

var a = new A(1, "wk");

Console.WriteLine(a.Id == 1);
Console.WriteLine(a.Name == "wk");
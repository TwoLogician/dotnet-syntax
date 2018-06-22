#! "netcoreapp2.1"
#r "nuget: NetStandard.Library, 2.0.3"

class C {
    public int Id { set; get; }
    public override bool Equals(object obj) =>
        obj is C c && Id == c.Id;
    public override int GetHashCode() => HashCode.Combine(Id);
}

Console.WriteLine(new C { Id = 1 }.Equals(new C { Id = 1 }));


public static E[] GetValues<E>() where E : System.Enum =>
     Enum.GetValues(typeof(E)) as E[];

enum Status { A, B, C, D };

var values = GetValues<Status>();

Console.WriteLine(string.Join(", ", values));
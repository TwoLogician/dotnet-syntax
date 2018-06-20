

public static E[] GetValues<E>() where E : System.Enum =>
     Enum.GetValues(typeof(E)) as E[];

public static string[] GetNames<E>() where E : System.Enum =>
     Enum.GetNames(typeof(E));

enum Status { A = 0, B = 1, C = 2, D = 3 };

Console.WriteLine(string.Join(" ", GetValues<Status>()));
Console.WriteLine(string.Join(" ", GetNames<Status>()));

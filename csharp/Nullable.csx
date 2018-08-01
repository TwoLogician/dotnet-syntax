int? a = null;

// Console.WriteLine(a.GetType());
Console.WriteLine(Nullable.GetUnderlyingType(typeof(int?)));
static class myclass {
    public static bool b = true;
    public static bool c = b;
}

Console.WriteLine(myclass.c);
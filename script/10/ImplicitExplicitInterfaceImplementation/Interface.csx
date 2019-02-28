
using System;

public interface IDateProvider {
    DateTime GetDate();
}


public class DefaultDateProvider : IDateProvider {
    public DateTime GetDate() {
        return DateTime.Now;
    }
}

public class MinDateProvider : IDateProvider {
    DateTime IDateProvider.GetDate() {
        return DateTime.MinValue;
    }
}

var def = new DefaultDateProvider();
Console.WriteLine(def.GetDate());


var def2 = new MinDateProvider();
//def2.GetDate();
IDateProvider def3 = def2;
Console.WriteLine(def3.GetDate());
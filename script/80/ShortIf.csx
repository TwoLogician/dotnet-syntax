class Point {
    public int X { set; get; }
    public int Y { set; get; }
}

var point = new Point { X = 100, Y = 200 };

var text = point switch
{
    { X: 100 } => "A",
    { Y: 200 } => "B",
    _ => "?"
};

Console.WriteLine(text);
class Point {
    public int X { set; get; }
    public int Y { set; get; }
}

var point = new Point { X = 0, Y = 0 };

string IsOrigin1(Point point) =>
    point.X == 0 && point.Y == 0 ? "True" : "False";

string IsOrigin2(Point point) =>
    point is { X: 0, Y: 0 } ? "True" : "False";

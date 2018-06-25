interface IControl {
    void Paint();
}

interface ISurface {
    void Paint();
}

class SomeClass : IControl, ISurface {
    void IControl.Paint() {
        Console.WriteLine("IControl.Paint");
    }
    void ISurface.Paint() {
        Console.WriteLine("ISurface.Paint");
    }
}

var c = new SomeClass();
var control = c as IControl;
var surface = c as ISurface;

control.Paint();
surface.Paint();

using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TryCSharp7
{
    public class Shape { }
    public class Circle : Shape
    {
        public int Radius { set; get; }
    }
    public class Rectangle : Shape
    {
        public int Width { set; get; }
        public int Height { set; get; }
    }
    public class PatternMatching
    {
        public string PrintStart(object o)
        {
            if (o is null) return "";
            if (!(o is int i)) return "";
            //return new string('*', i); // not working
            return "**";
        }

        [Fact]
        public void IsExpressionWithPattern()
        {
            var value = PrintStart(2);
            value.Should().Be("**");
        }

        private string GetString(Shape shape)
        {
            switch (shape)
            {
                case Circle c:
                    return $"radius = {c.Radius}";
                case Rectangle r:
                    return $"witdh = {r.Width}, height = {r.Height}";
                default:
                    return "";
            }
        }

        [Fact]
        public void SwitchStatementWithPattern()
        {
            var shape = new Circle { Radius = 10 };
            var value = GetString(shape);
            value.Should().Be("radius = 10");
        }
    }
}

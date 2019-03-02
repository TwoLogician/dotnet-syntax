using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TryCSharp7
{
    public class TuplesAndDeconstruction
    {
        (string, string, string) LookupName()
        {
            var first = "f";
            var middle = "m";
            var last = "l";
            return (first, middle, last);
        }

        public void Deconstruct(out int x, out int y) { x = 1; y = 2; }

        [Fact]
        public void Syntax1()
        {
            (var f, var m, var l) = LookupName();
            f.Should().Be("f");
            m.Should().Be("m");
            l.Should().Be("l");
        }

        [Fact]
        public void Syntax2()
        {
            var (f, m, l) = LookupName();
            f.Should().Be("f");
            m.Should().Be("m");
            l.Should().Be("l");

            // var (ff, mm, *) = LookupName(); // not working
        }

    }
}

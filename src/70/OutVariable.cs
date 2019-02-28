using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TryCSharp7
{
    public class OutVariable
    {
        public void Random(out int x, out int y)
        {
            x = 100;
            y = 200;
        }
        [Fact]
        public void Out()
        {
            Random(out int x, out int y);
            // x.Should().Be(100);  // not working
            // y.Should().Be(100);  // not working
        }
        [Fact]
        public void OutIgnore()
        {
            // Random(out int x, out *); // not working
        }
    }
}

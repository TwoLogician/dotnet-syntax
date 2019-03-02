using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TryCSharp7
{
    public class LiteralImprovements
    {
        [Fact]
        public void Start()
        {
            var d = 123_456;
            d.Should().Be(123456);
        }
    }
}

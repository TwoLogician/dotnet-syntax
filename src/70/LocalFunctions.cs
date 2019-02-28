using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TryCSharp7
{
    public class LocalFunctions
    {
        [Fact]
        public void Start()
        {
            int add(int x, int y) => x + y;

            add(10, 10).Should().Be(20);
        }
    }
}

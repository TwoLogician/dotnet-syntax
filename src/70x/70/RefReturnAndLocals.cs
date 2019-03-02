using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TryCSharp7
{
    public class RefReturnAndLocals
    {
        [Fact]
        public void Start()
        {
            int[] numbers = { 1, 2, 3 };
            ref int first = ref numbers[0];

            first = 10;

            numbers[0].Should().Be(10);
        }
    }
}

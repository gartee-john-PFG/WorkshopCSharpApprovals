namespace GildedRose.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using Xunit;

    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseShould
    {
        [Fact]
        public void FindTheGildedRoseClass()
        {
            Assert.True(1 == 1);
        }
    }
}

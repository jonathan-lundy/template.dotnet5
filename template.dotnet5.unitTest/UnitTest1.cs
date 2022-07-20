using System;
using Xunit;

namespace template.dotnet5.unitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var actual = "Successful test!";
            Assert.Equal("Successful test!", actual);
        }
    }
}

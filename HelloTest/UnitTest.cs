using System;
using Xunit;
using Hello;


namespace HelloTest
{
    public class UnitTest
    {
        [Fact]
        public void HelloworldTest()
        {
            var data = Hello.Program.WriteHelloWorld();
            Assert.Equal("Hello World!", data);
        }
    }
}

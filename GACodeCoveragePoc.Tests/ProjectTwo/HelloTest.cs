using ProjectTwo;

namespace GACodeCoveragePoc.Tests.ProjectTwo
{
    public class HelloTest
    {
        [Fact]
        public void SayHello_Pass()
        {
            
            Assert.Equal("Hello", Hello.SayHello());
        }
    }
}

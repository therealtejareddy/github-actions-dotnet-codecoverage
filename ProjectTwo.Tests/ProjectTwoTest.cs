namespace ProjectTwo.Tests
{
    public class ProjectTwoTest
    {
        [Fact]
        public void SayHello_Pass()
        {
            Assert.Equal("Hello",ProjectTwo.SayHello());
        }
    }
}
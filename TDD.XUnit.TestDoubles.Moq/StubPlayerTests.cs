using Moq;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.Moq
{
    public class StubPlayerTests
    {
        [Fact]
        public void RunRound_ShouldReturnValueFromFizzBuzz()
        {
            // arrange

            const int one = 1;
            const string oneString = "1";
            var stubFizzBuzz = new Mock<IFizzBuzz>();
            // Now this is stub
            stubFizzBuzz.Setup(stub => stub.GetValue(one)).Returns(oneString); 
            var player = new Player(stubFizzBuzz.Object);

            // act

            var result = player.RunRound(1);

            // assert

            Assert.Equal(result, oneString);
        }
    }
}

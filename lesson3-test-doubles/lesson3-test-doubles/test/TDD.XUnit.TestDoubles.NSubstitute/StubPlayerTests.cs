using NSubstitute;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.NSubstitute
{
    public class StubPlayerTests
    {
        [Fact]
        public void RunRound_ShouldReturnValueFromFizzBuzz()
        {
            // arrange

            const int one = 1;
            const string oneString = "1";
            var stubFizzBuzz = Substitute.For<IFizzBuzz>();
            // Now this is stub
            stubFizzBuzz.GetValue(one).Returns(oneString);
            var player = new Player(stubFizzBuzz);

            // act

            var result = player.RunRound(1);

            // assert

            Assert.Equal(result, oneString);
        }
    }
}

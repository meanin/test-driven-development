using Moq;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.Moq
{
    public class SpyPlayerTests
    {
        [Fact]
        public void RunRound_ShouldGetValueFromFizzBuzz()
        {
            // arrange

            const int one = 1;
            var mockFizzBuzz = new Mock<IFizzBuzz>();
            var player = new Player(mockFizzBuzz.Object);

            // act

            player.RunRound(one);
            player.RunRound(one);

            // assert

            // Now this is variation of Mock which record method execution count
            mockFizzBuzz.Verify(mock => mock.GetValue(one), Times.Exactly(2));
        }
    }
}

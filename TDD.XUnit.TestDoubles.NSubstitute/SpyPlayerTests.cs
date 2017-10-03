using NSubstitute;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.NSubstitute
{
    public class SpyPlayerTests
    {
        [Fact]
        public void RunRound_ShouldGetValueFromFizzBuzz()
        {
            // arrange

            const int one = 1;
            var mockFizzBuzz = Substitute.For<IFizzBuzz>();
            var player = new Player(mockFizzBuzz);

            // act

            player.RunRound(one);
            player.RunRound(one);

            // assert

            // Now this is mock
            mockFizzBuzz.Received(2).GetValue(one);
        }
    }
}

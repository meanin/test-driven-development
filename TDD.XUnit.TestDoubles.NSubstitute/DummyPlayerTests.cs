using NSubstitute;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.NSubstitute
{
    public class DummyPlayerTests
    {
        [Fact]
        public void RunRound_ShouldNotThrow()
        {
            // arrange

            var dummyFizzBuzz = Substitute.For<IFizzBuzz>();
            var player = new Player(dummyFizzBuzz);

            // act

            void Act() => player.RunRound(1);

            // assert

            // does not throw, unlike test does not pass
            Act();
        }
    }
}

using Rhino.Mocks;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.Rhino
{
    public class DummyPlayerTests
    {
        [Fact]
        public void RunRound_ShouldNotThrow()
        {
            // arrange

            var dummyFizzBuzz = new MockRepository().DynamicMock<IFizzBuzz>();
            var player = new Player(dummyFizzBuzz);

            // act

            void Act() => player.RunRound(1);

            // assert

            // does not throw, unlike test does not pass
            Act();
        }
    }
}

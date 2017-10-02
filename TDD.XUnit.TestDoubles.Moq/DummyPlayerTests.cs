using System;
using Moq;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.Moq
{
    public class DummyPlayerTests
    {
        [Fact]
        public void RunRound_ShouldNotThrow()
        {
            // arrange

            var dummyFizzBuzz = new Mock<IFizzBuzz>();
            var player = new Player(dummyFizzBuzz.Object);

            // act

            void Act() => player.RunRound(1);

            // assert

            // does not throw, unlike test does not pass
            Act();
        }
    }
}

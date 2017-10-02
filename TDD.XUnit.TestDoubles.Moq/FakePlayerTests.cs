using Moq;
using TDD.Classes;
using TDD.XUnit.TestDoubles.Moq.TestModels;
using Xunit;

namespace TDD.XUnit.TestDoubles.Moq
{
    public class FakePlayerTests
    {
        [Fact]
        public void RunRound_ShouldGetValueFromFizzBuzz()
        {
            // arrange
            
            var fakeFizzBuzz = new FizzBuzzFake();
            var player = new Player(fakeFizzBuzz);

            // act

            void Act() => player.RunRound(1);

            // assert
            Act();// does not throw, unlike test does not pass
        }
    }
}

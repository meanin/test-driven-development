using Moq;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.Moq
{
    public class MockPlayerTests
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

            // assert
            
            // Now this is mock
            mockFizzBuzz.Verify(mock => mock.GetValue(one)); 
        }
    }
}

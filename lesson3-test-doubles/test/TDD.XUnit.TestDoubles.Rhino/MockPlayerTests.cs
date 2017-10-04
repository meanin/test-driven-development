using Rhino.Mocks;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.Rhino
{
    public class MockPlayerTests
    {
        [Fact]
        public void RunRound_ShouldGetValueFromFizzBuzz()
        {
            // arrange

            const int one = 1;
            const string oneString = "1";
            var mockery = new MockRepository();
            var mockFizzBuzz = mockery.DynamicMock<IFizzBuzz>();
            Expect.Call(mockFizzBuzz.GetValue(one)).Return(oneString);
            var player = new Player(mockFizzBuzz);

            // act

            mockFizzBuzz.Replay();
            var result = player.RunRound(1);

            // assert

            mockery.Verify(mockFizzBuzz);
            Assert.Equal(result, oneString);
        }
    }
}

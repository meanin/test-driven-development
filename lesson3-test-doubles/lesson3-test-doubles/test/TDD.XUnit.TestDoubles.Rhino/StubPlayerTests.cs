using Rhino.Mocks;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestDoubles.Rhino
{
    public class StubPlayerTests
    {
        [Fact]
        public void RunRound_ShouldReturnValueFromFizzBuzz()
        {
            // arrange

            const int one = 1;
            const string oneString = "1";
            var mockery = new MockRepository();
            var stubFizzBuzz = mockery.DynamicMock<IFizzBuzz>();
            IPlayer player;
            using (mockery.Record())
            {
                // Now this is stub
                Expect.Call(stubFizzBuzz.GetValue(one)).Return(oneString);
                player = new Player(stubFizzBuzz);
            }
            string result;

            // act
            using (mockery.Playback())
            { 
                result = player.RunRound(1);
            }

            // assert

            Assert.Equal(result, oneString);
        }
    }
}

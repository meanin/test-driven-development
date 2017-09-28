using TDD.Classes;
using Xunit;

namespace TDD.XUnitTests
{
    public class FizzBuzzInputDataSetTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void GetValue_ShouldReturnExpectedResult(int number, string expected)
        {
            // arrange

            var fizzBuzz = new FizzBuzz();

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Assert.Equal(result, expected);
        }

    }
}

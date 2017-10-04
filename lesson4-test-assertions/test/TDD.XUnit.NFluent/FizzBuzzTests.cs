using NFluent;
using Xunit;

namespace TDD.XUnit.NFluent
{
    public class FizzBuzzTests
    {
        [Fact]
        public void GetValue_WhenGivenNumberIs3_ShouldReturnFizz()
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();
            const int number = 3;
            const string expected = "Fizz";

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Check.That(result).Equals(expected);
        }

        [Fact]
        public void GetValue_WhenGivenNumberIs5_ShouldReturnBuzz()
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();
            const int number = 5;
            const string expected = "Buzz";

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Check.That(result).Equals(expected);
        }

        [Fact]
        public void GetValue_WhenGivenNumberIs1_ShouldReturnNumber()
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();
            const int number = 1;
            const string expected = "1";

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Check.That(result).Equals(expected);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(15)]
        public void GetValue_ShouldNotThrow(int number)
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();

            // act

            void Act() => fizzBuzz.GetValue(number);

            // assert
            Check.ThatCode(Act).DoesNotThrow();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void GetValue_ShouldReturnExpectedResult(int number, string expected)
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Check.That(result).IsNotNull();
            Check.That(result).IsInstanceOf<string>();
            Check.That(result).Equals(expected);
        }
    }
}

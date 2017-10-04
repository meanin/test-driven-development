using System;
using FluentAssertions;
using Xunit;

namespace TDD.XUnit.FluentAssertions
{
    public class FizzBuzzBasicTests
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

            result.Should().BeEquivalentTo(expected);
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

            result.Should().BeEquivalentTo(expected);
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

            result.Should().BeEquivalentTo(expected);
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

            Action act = () => fizzBuzz.GetValue(number);

            // assert

            act.ShouldNotThrow();
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

            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(string));
            result.Should().BeEquivalentTo(expected);
        }
    }
}

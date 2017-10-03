using NUnit.Framework;
using TDD.Classes;

namespace TDD.NUnitTests
{
    public class FizzBuzzInputDataSetTests
    {
        [Theory]
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void GetValue_ShouldReturnExpectedResult(int number, string expected)
        {
            // arrange

            var fizzBuzz = new FizzBuzz();

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Assert.AreEqual(result, expected);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.MSTests
{
    [TestClass]
    public class FizzBuzzBasicTests
    {
        [TestMethod]
        public void GetValue_WhenGivenNumberIs3_ShouldReturnFizz()
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();
            const int number = 3;
            const string expected = "Fizz";

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void GetValue_WhenGivenNumberIs5_ShouldReturnBuzz()
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();
            const int number = 5;
            const string expected = "Buzz";

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void GetValue_WhenGivenNumberIs1_ShouldReturnNumber()
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();
            const int number = 1;
            const string expected = "1";

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Assert.AreEqual(result, expected);
        }
    }
}

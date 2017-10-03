using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.MSTests
{
    [TestClass]
    public class FizzBuzzInputDataSetTests
    {
        [DataTestMethod]
        [DataRow(1, "1")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        public void GetValue_ShouldReturnExpectedResult(int number, string expected)
        {
            // arrange

            var fizzBuzz = new FizzBuzz.FizzBuzz();

            // act

            var result = fizzBuzz.GetValue(number);

            // assert

            Assert.AreEqual(result, expected);
        }
    }
}

namespace TDD.Fibonacci.Exercises
{
    /// <summary>
    /// This file exposes basic exercise for creating your first tests
    /// 
    /// Few step to follow:
    /// 1. Choose your favorite test engine and download it as nuget package
    /// 2. Add reference to project TDD.Fibonacci
    /// 3. Select your favorite assertion nuget
    /// 4. Write your first test
    ///     Remember test first
    /// 5. Write only that code that makes tests green
    /// </summary>
    /// 
    /// MSTest
    /// [TestClass]
    public class FibonacciTests
    {
        // MSTest
        // [TestMethod]

        // NUnit
        //[Test]

        // XUnit
        //[Fact]
        public void GetValue_WhenGivenNumberIs5_ShouldReturn5()
        {
            // arrange

            // initialize here new instance of tested class ( new Fibonacci() )
            // initialize input data
            // initialize expected output

            // act

            // run tested method and get output

            // assert

            // Validate output 
        }

        // Follow chosen convention
        public void GetValue_WhenGivenNumberIs6_ShouldReturn8()
        {
            // arrange

            // act

            // assert

        }

        // Follow chosen convention
        public void GetValue_WhenGivenNumberIs10_ShouldReturn55()
        {
            // arrange

            // act

            // assert
        }

        // Follow chosen convention with input data
        public void GetValue_ShouldNotThrow(int number)
        {
            // arrange

            // act

            // assert

        }

        // Follow chosen convention with input data
        public void GetValue_ShouldReturnExpectedResult(int number, string expected)
        {
            // arrange

            // act

            // assert

        }
    }
}

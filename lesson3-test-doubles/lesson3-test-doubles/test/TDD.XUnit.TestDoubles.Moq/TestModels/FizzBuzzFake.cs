using TDD.Classes;

namespace TDD.XUnit.TestDoubles.Moq.TestModels
{
    public class FizzBuzzFake : IFizzBuzz
    {
        public string GetValue(int number)
        {
            return string.Empty;
        }
    }
}

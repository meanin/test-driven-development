namespace TDD.FizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        public string GetValue(int number)
        {
            var returnMessage = string.Empty;
            if (IsFizz(number))
                returnMessage += "Fizz";
            if (IsBuzz(number))
                returnMessage += "Buzz";

            return returnMessage == string.Empty
                ? number.ToString()
                : returnMessage;
        }

        private static bool  IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }
    }
}

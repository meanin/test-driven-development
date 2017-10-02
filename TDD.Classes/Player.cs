namespace TDD.Classes
{
    public class Player : IPlayer
    {
        private readonly IFizzBuzz _fizzBuzz;
        private int _points;

        public Player(IFizzBuzz fizzBuzz)
        {
            _fizzBuzz = fizzBuzz;
        }

        public string RunRound(int number)
        {
            return _fizzBuzz.GetValue(number);
        }

        public void AddPoint()
        {
            _points++;
        }

        public int GetScore()
        {
            return _points;
        }
    }
}

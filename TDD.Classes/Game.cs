using System.Collections.Generic;
using System.Linq;

namespace TDD.Classes
{
    public class Game
    {
        private readonly int _roundCount;
        private readonly IList<IPlayer> _players;
        private readonly FizzBuzz _realFizzBuzz;

        public Game(int roundCount, IList<IPlayer> players)
        {
            _roundCount = roundCount;
            _players = players;
            _realFizzBuzz = new FizzBuzz();
        }

        public IPlayer GetWinner()
        {
            var tryThisNumber = 0;
            for (var roundNumber = 0; roundNumber < _roundCount; roundNumber++)
            {
                foreach (var player in _players)
                {
                    ++tryThisNumber;
                    if(_realFizzBuzz.GetValue(tryThisNumber) == player.RunRound(tryThisNumber))
                        player.AddPoint();
                }
            }

            return _players.First(p => p.GetScore() == _players.Max(player => player.GetScore()));
        }
    }
}

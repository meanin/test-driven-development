namespace TDD.Classes
{
    public interface IPlayer
    {
        string RunRound(int number);
        void AddPoint();
        int GetScore();
    }
}
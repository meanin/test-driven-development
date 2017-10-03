namespace TDD.Classes
{
    public interface IPlayer
    {
        string Name { get; set; }

        string RunRound(int number);
        void AddPoint();
        int GetScore();
    }
}
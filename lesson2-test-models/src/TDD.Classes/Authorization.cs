namespace TDD.Classes
{
    public class Authorization : IAuthorization
    {
        public bool ValidateAccount(Account account)
        {
            return string.Equals(account.EnteredPassword, account.RealPassword);
        }
    }
}

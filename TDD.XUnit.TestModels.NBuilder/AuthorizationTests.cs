using FizzWare.NBuilder;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestModels.NBuilder
{
    public class AuthorizationTests
    {
        [Fact]
        public void ValidateAccount_ForAnyAccount_ShouldNotThrow()
        {
            // arrange

            var account = Builder<Account>.CreateNew()
                .With(m => m.Name = "account")
                .With(m => m.RealPassword = "password")
                .With(m => m.EnteredPassword = "enteredpassword")
                .Build();
            var authorization = new Authorization();

            // act

            void Act() => authorization.ValidateAccount(account);

            // assert

            Act();
        }

        [Fact]
        public void ValidateAccount_WhenPasswordsMatch_ShouldReturnTrue()
        {
            // arrange

            var account = Builder<Account>.CreateNew()
                .With(m => m.Name = "account")
                .With(m => m.RealPassword = "password")
                .With(m => m.EnteredPassword = "password")
                .Build();
            var authorization = new Authorization();

            // act

            var result = authorization.ValidateAccount(account);

            // assert

            Assert.True(result);
        }

        [Fact]
        public void ValidateAccount_WhenPasswordsDoesNotMatch_ShouldReturnFalse()
        {
            // arrange

            var account = Builder<Account>.CreateNew()
                .With(m => m.Name = "account")
                .With(m => m.RealPassword = "password")
                .With(m => m.EnteredPassword = "enteredpassword")
                .Build();
            var authorization = new Authorization();

            // act

            var result = authorization.ValidateAccount(account);

            // assert

            Assert.False(result);
        }
    }
}

using System;
using Ploeh.AutoFixture;
using TDD.Classes;
using Xunit;

namespace TDD.XUnit.TestModels.AutoFixture
{
    public class AuthorizationTests
    {
        [Fact]
        public void ValidateAccount_ForAnyAccount_ShouldNotThrow()
        {
            // arrange

            var fixture = new Fixture();
            var account = fixture.Create<Account>();
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

            var fixture = new Fixture();
            var account = fixture.Create<Account>();
            account.EnteredPassword = account.RealPassword;
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

            var fixture = new Fixture();
            var account = fixture.Create<Account>();
            var authorization = new Authorization();

            // act

            var result = authorization.ValidateAccount(account);

            // assert

            Assert.False(result);
        }
    }
}

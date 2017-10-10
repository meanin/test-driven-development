using TDD.Database;
using TDD.Database.DbModels;
using Xunit;

namespace TDD.RepositoryIntegrationTests
{
    public class CustomRepositoryTests : DatabaseIntegrationTestBase
    {
        private readonly CustomRepository _repository;

        public CustomRepositoryTests()
            : base(new CustomContext("TestCustomDb"))
        {
            _repository = new CustomRepository(Context as CustomContext);
        }

        [Fact]
        public void Create_ShouldNotThrow()
        {
            // arrange

            var type = new CustomType { Field = "test" };

            // act

            void Act() => _repository.Create(type);

            // assert

            Act();
        }

        [Fact]
        public void Read_ShouldNotThrow()
        {
            // arrange

            // act

            void Act() => _repository.Read(0);

            // assert

            Act();
        }

        [Fact]
        public void Read_WhenDbContextDoesNotContainObject_ShouldReturnNull()
        {
            // arrange

            // act

            var result = _repository.Read(0);

            // assert

            Assert.Null(result);
        }

        [Fact]
        public void Read_WhenDbContextContainsObject_ShouldReturnObject()
        {
            // arrange
            
            var type = new CustomType { Field = "test" };
            _repository.Create(type);

            // act

            var result = _repository.Read(type.Id);

            // assert

            Assert.NotNull(result);
        }

        [Fact]
        public void Update_ShouldNotThrow()
        {
            // arrange

            var type = new CustomType { Field = "test" };
            _repository.Create(type);

            // act
            type.Field = "new test";
            void Act() => _repository.Update(type);

            // assert

            Act();
        }

        [Fact]
        public void Update_ShouldUpdateChangedFields()
        {
            // arrange

            var type = new CustomType { Field = "test" };
            _repository.Create(type);
            type.Field = "new test";

            // act

            _repository.Update(type);
            var result = _repository.Read(type.Id);

            // assert

            Assert.Equal(result, type);
        }

        [Fact]
        public void Delete_ShouldNotThrow()
        {
            // arrange

            var type = new CustomType { Field = "test" };
            _repository.Create(type);

            // act
            void Act() => _repository.Delete(type.Id);

            // assert

            Act();
        }

        [Fact]
        public void Delete_ShouldDeleteObjectFromDb()
        {
            // arrange

            var type = new CustomType { Field = "test" };
            _repository.Create(type);
            _repository.Delete(type.Id);

            // act

            var result = _repository.Read(type.Id);

            // assert

            Assert.Null(result);
        }
    }
}

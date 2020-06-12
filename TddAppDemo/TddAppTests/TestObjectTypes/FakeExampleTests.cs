using TddApp.TestObjectTypes.Fake;
using Xunit;

namespace TddAppTests.TestObjectTypes
{
    public class FakeExampleTests
    {
        [Fact]
        public void TestingTheUserManagerClass()
        {
            var manager = new FakeExampleProgram(new FakeExample());
            manager.AddUser(new User(1,"user1"));
            manager.AddUser(new User(2,"user2"));

            var result = manager.GetUserList();

            Assert.True(result.Count==2);
        }
    }
}

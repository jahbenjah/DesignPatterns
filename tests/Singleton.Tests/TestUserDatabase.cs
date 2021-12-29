using Xunit;

namespace Singleton.Tests;

public class TestUserDatabase
{
    [Fact]
    public async void TestsWriteUser()
    {
        User user = new User() { Id = 1, Name = "Benjamin", IsActive = true };
        _ = await UserDatabase.GetInstance().WriteUser(user);
        Assert.True(System.IO.File.Exists("user.json"));
    }

    [Fact]
    public async void TestReadUser()
    {
        User user = new User() { Id = 1, Name = "Juan", IsActive = true };
        await UserDatabase.GetInstance().WriteUser(user);
        var readUser = await UserDatabase.GetInstance().ReadUser("");
        Assert.Equal("Juan", readUser.Name);
    }
}

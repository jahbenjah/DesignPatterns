using System;
using System.Reflection;
using Xunit;

namespace Singleton.Tests;

public class TestSingleton2
{
    [Fact]
    public void TestCreateSingleton2()
    {
        Singleton2 s = Singleton2.GetInstance();
        Singleton2 s2 = Singleton2.GetInstance();
        Assert.Equal(s, s2);
    }

    [Fact]
    public void TestNoPublicConstructors2()
    {
        Type singleton = typeof(Singleton2);
        ConstructorInfo[] ctrs = singleton.GetConstructors();
        bool hasPublicConstructor = false;
        foreach (ConstructorInfo c in ctrs)
        {
            if (c.IsPublic)
            {
                hasPublicConstructor = true;
                break;
            }
        }
        Assert.False(hasPublicConstructor);
    }
}


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

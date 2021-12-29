using System;
using System.Reflection;
using Xunit;

namespace Singleton.Tests;
public class TestSingleton
{
    [Fact]
    public void TestCreateSingleton()
    {
        Singleton s = Singleton.Instance;
        Singleton s2 = Singleton.Instance;
        Assert.Equal(s, s2);
    }

    [Fact]
    public void TestNoPublicConstructors()
    {
        Type singleton = typeof(Singleton);
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
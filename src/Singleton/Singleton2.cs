namespace Singleton;

public sealed class Singleton2
{
    private Singleton2() { }

    private static readonly Singleton2 _instance = new();

    public static Singleton2 GetInstance()
    {
        return _instance;
    }

    public static void SomeBusinessLogic()
    {
        // ...
    }
}


//public class MyClass : Singleton
//{
//}
//public class OtherClass : Singleton2
//{
//}
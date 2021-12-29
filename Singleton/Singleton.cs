namespace Singleton;


public class Singleton
{
    private static Singleton theInstance = null;
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (theInstance == null)
                theInstance = new Singleton();
            return theInstance;
        }
    }
}


public sealed class Singleton2
{
    private Singleton2() { }

    private static Singleton2 _instance;

    public static Singleton2 GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton2();
        }
        return _instance;
    }

    public static void someBusinessLogic()
    {
        // ...
    }
}

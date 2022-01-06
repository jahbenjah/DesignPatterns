namespace Singleton;

public sealed class ThreadSafeSingleton
{
  
    private static volatile ThreadSafeSingleton _instance;
    private static readonly object _syncLock = new object();
    private ThreadSafeSingleton()
    {
    }

    public static ThreadSafeSingleton Instance {
        get {
            if (_instance != null) return _instance;
            lock (_syncLock) {
                if (_instance == null) {
                    _instance = new ThreadSafeSingleton();
                }
            }
            return _instance;
        }
    }

    public int SomeValue { get; set; }
}
namespace Singleton;

public class UserDatabaseSource : IUserDatabase
{
    private static IUserDatabase theInstance = new UserDatabaseSource();
    public static IUserDatabase Instance
    {
        get
        {
            return theInstance;
        }
    }
    private UserDatabaseSource()
    {
    }

    public User ReadUser(string userName)
    {
        // Some Implementation
        return new User();
    }
    public void WriteUser(User user)
    {
        // Some Implementation
    }
}

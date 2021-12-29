namespace Singleton;

public interface IUserDatabase
{
    User ReadUser(string userName);
    void WriteUser(User user);
}

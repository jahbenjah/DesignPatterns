namespace Singleton;

public interface IUserDatabase
{
    Task<User> ReadUser(string userName);
    Task<bool> WriteUser(User user);
}

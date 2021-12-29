using System.Text.Json;

namespace Singleton;

public class UserDatabase : IUserDatabase
{
    private static IUserDatabase _instance = new UserDatabase();
    public static IUserDatabase GetInstance() => _instance;

    private UserDatabase()
    {
    }

    public async Task<User> ReadUser(string userName)
    {
        var text = await File.ReadAllTextAsync("user.json");
        User user = JsonSerializer.Deserialize<User>(text);
        return user;
    }
    public async Task<bool> WriteUser(User user)
    {
        await File.WriteAllTextAsync("user.json", JsonSerializer.Serialize(user));
        return true;
    }
}

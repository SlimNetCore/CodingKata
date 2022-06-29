using CodingKata.Exceptions;

namespace CodingKata.Users;

public class UserSession : IUserSession
{

    public User GetLoggedUser()
    {
        return new User();
    }
}
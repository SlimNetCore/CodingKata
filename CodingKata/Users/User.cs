namespace CodingKata.Users;

public class User
{
    private readonly List<User> _friends = new();

    public IEnumerable<User> GetFriends()
    {
        return _friends;
    }

    public void AddFriend(User friend)
    {
        _friends.Add(friend);
    }

    public bool isFriend(User currentUser)
    {
        foreach (User friend in _friends)
        {
            if (friend.Equals(currentUser))
            {
                return true;
            }
        }
        return false;
    }
}
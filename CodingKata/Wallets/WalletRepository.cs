using CodingKata.Exceptions;
using CodingKata.Users;

namespace CodingKata.Wallets;

public class WalletRepository
{
    public static IEnumerable<Wallet> FindWalletsByUser(User user)
    {
        return new List<Wallet>();
    }
}
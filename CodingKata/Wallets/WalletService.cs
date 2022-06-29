using CodingKata.Exceptions;
using CodingKata.Users;

namespace CodingKata.Wallets
{
    public class WalletService
    {
        private IUserSession _userSession;
        public WalletService(IUserSession userSession)
        {
            _userSession = userSession;
        }
        public IEnumerable<Wallet> GetWalletsByUser(User user)
        {
            User currentUser = _userSession.GetLoggedUser();
            if (currentUser == null)
            {
                throw new UserNotLoggedInException();
            }
            if (user.isFriend(currentUser))
            {
                return WalletRepository.FindWalletsByUser(user);
            }
            return Enumerable.Empty<Wallet>();

        }
    }
}
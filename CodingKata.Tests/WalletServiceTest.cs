using CodingKata.Users;
using CodingKata.Wallets;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
namespace CodingKata.Tests
{
    public class WalletServiceTest
    {
        WalletService? srv;
        User? usr;
        [SetUp]
        public void Setup()
        {
            usr = new User();
            IUserSession session = new UserSession();
            srv = new WalletService(session);

        }
        [Test]
        public void WhenCurrentUserIsNull_Then_ReturnEmpty()
        {
            IEnumerable<Wallet> wall = srv.GetWalletsByUser(usr);
            Assert.AreEqual(Enumerable.Empty<Wallet>(), wall);
        }
    }
}
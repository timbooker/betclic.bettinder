using System.Linq;
using BetClic.BetTinder.Core.Services;
using NUnit.Framework;

namespace BetClic.BetTinder.Core.Tests.Services
{
    [TestFixture]
    public class UserAccountServiceTest
    {
        [Test]
        public void TEstGetUser()
        {
            var userAccoutService = new UserAccountService();

            var result = userAccoutService.GetUserAccount();

            Assert.That(result.UserName, Is.Not.Empty);

        }


        [Test]
        public void TestIncreaseUserBalance()
        {
            var userAccoutService = new UserAccountService();

            var user = userAccoutService.GetUserAccount();
            decimal bal1 = user.Balance;
            var result = userAccoutService.IncreaseBalance(user, (decimal)50);

            

            Assert.That(result.UserName, Is.Not.Empty);

        }

        [Test]
        public void TestDecreaseUserBalace()
        {
            var userAccoutService = new UserAccountService();
            var user = userAccoutService.GetUserAccount();
            var result = userAccoutService.DeductBalance(user, (decimal)10, new Bet());

            Assert.That(result.UserName, Is.Not.Empty);

        }


    }
}

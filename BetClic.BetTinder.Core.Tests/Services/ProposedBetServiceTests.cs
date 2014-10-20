using System.Linq;
using BetClic.BetTinder.Core.Services;
using NUnit.Framework;

namespace BetClic.BetTinder.Core.Tests
{
    [TestFixture]
    public class ProposedBetServiceTests
    {
        [Test]
        public void given_request_for_data_returns_something()
        {
            // arrange 
            var proposedBetService = new ProposedBetsService();

            // act
            var result = proposedBetService.GetNextBet();

            // then 
            Assert.That(result.Name, Is.Not.Empty);
        }

    }
}
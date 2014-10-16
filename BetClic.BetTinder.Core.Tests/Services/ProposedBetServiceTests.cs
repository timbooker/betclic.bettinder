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
            var result = proposedBetService.GetBets();

            // then 
            Assert.That(result.Count(), Is.EqualTo(10));
            Assert.That(result.First().Name, Is.Not.Empty);
        }

    }
}
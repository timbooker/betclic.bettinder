using System.Linq;
using BetClic.BetTinder.Core.Services;
using NUnit.Framework;

namespace BetClic.BetTinder.Core.Tests
{
    [TestFixture]
    public class BetServiceTests
    {
        BetsService service = new BetsService();

        [Test]
        public void given_request_for_data_returns_something()
        {
            // act
            var result = service.GetNextBet();

            // then 
            Assert.That(result.HomeTeam, Is.Not.Empty);
        }

        [Test]
        public void image_path_correctly_set()
        {
            int i = 0;

            while (i < 50)
            {
                // act
                var result = service.GetNextBet();

                // then 
                Assert.IsNotNullOrEmpty(result.ImageName);
                i++;
            }

        }

    }
}
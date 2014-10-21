using System;
using System.Collections.Generic;

namespace BetClic.BetTinder.Core.Services
{
    public class ProposedBetsService : IProposedBetsService
    {
        private string[] imageNames;

        public ProposedBetsService()
        {
            imageNames = new string[]{ "pic1", "pic2", "pic3", "pic4", "pic5" };
        }

        public Bet GetNextBet()
        {           
            return new Bet()
            {
                Name = Guid.NewGuid().ToString().Substring(0, 6),
                Odds = new Random().NextDouble(),
                ImageName = imageNames[new Random().Next(0, 5)] + ".jpg",
                PreviousResults = GetHistoricalEvents()
            };
        }

        private IEnumerable<PreviousResults> GetHistoricalEvents()
        {
            List<PreviousResults> list = new List<PreviousResults>();
            Random rnd = new Random();
            int numberOfLoops = rnd.Next(1, 10);
            for (int i = 0; i < numberOfLoops; i++)
            {
                list.Add(new PreviousResults()
                {
                    HomeTeam = "Home Team " + Guid.NewGuid().ToString().Substring(0, 6),
                    AwayTeam = "Away Team " + Guid.NewGuid().ToString().Substring(0, 6),
                    AwayTeamScore = rnd.Next(0, 10),
                    HomeTeamScore = rnd.Next(0, 10),
                    MatchDate = new DateTime(rnd.Next(1960, 2014), rnd.Next(1,12), rnd.Next(1,28))
                });
            }

            return list;
        }

    }
}
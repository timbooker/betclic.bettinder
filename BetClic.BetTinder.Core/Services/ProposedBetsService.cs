using System;
using System.Collections.Generic;

namespace BetClic.BetTinder.Core.Services
{
    public class ProposedBetsService : IProposedBetsService
    {
        private string[] imageNames;
        int i = 0;

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
                ImageName = imageNames[i % 5]
            };

            i++;
        }
    }
}
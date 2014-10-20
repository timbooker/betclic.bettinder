using System;
using System.Collections.Generic;

namespace BetClic.BetTinder.Core.Services
{
    public class ProposedBetsService : IProposedBetsService
    {
        public Bet GetNextBet()
        {
            return new Bet()
            {
                Name = Guid.NewGuid().ToString().Substring(0, 6),
                Odds = new Random().NextDouble()
            };
        }
    }
}
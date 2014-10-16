using System;
using System.Collections.Generic;

namespace BetClic.BetTinder.Core.Services
{
    public class ProposedBetsService : IProposedBetsService
    {
        public IEnumerable<Bet> GetBets()
        {
            var bets = new List<Bet>();
            for (int i = 0; i < 10; i++)
            {
                bets.Add(new Bet()
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 6),
                    Odds = new Random().NextDouble()
                });
            }

            return bets;
        }
    }
}
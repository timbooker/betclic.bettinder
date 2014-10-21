using System;
using System.Collections.Generic;

namespace BetClic.BetTinder.Core.Services
{
    public class BetsService : IBetsService
    {
        private List<Bet> acceptedBets;
        private string[] imageNames; 

        public BetsService()
        {
            acceptedBets = new List<Bet>();
            imageNames = new string[]{ "pic1", "pic2", "pic3", "pic4", "pic5" };
        }

        public Bet GetNextBet()
        {           
            return new Bet()
            {
                Name = Guid.NewGuid().ToString().Substring(0, 6),
                Odds = new Random().NextDouble(),
                ImageName = imageNames[new Random().Next(0, 5)]
            };
        }

        public List<Bet> GetAcceptedBets()
        {
            return acceptedBets;
        }

        public void AddAcceptedBet(Bet acceptedBet)
        {
            acceptedBets.Add(acceptedBet);
        }
    }
}
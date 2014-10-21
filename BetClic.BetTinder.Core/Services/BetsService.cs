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
                // update to use home / away teams (two properties)
                Name = Guid.NewGuid().ToString().Substring(0, 6),
                Odds = new Random().NextDouble(), // make 2 d.p.
                ImageName = string.Format("http://lorempixel.com/200/200/sports?x={0}", new Random().Next()),// get from placeholder website directly (http://somephwebsite/football/etc)
                PreviousResults = GetHistoricalEvents() // pass in current bet so u can get better data.
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

        private IEnumerable<PreviousResults> GetHistoricalEvents()
        {
            List<PreviousResults> list = new List<PreviousResults>();
            Random rnd = new Random();
            int numberOfLoops = rnd.Next(1, 10);
            for (int i = 0; i < numberOfLoops; i++)
            {
                list.Add(new PreviousResults()
                {
                    // make these related to the bet team name (we'll just do football for now, so 
                    // get a dictionary of football teams.
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
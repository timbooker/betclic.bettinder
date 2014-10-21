using System;
using System.Collections.Generic;
using BetClic.BetTinder.Core.Entities;
using Cirrious.MvvmCross.Platform;

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


        private readonly Random random = new Random();

        private double RandomNumberBetween()
        {
            var next = random.NextDouble();

            return Math.Round(3 + (next * (3 - 0)), 2);
        }
        
        
        public Bet GetNextBet()
        {           
            Random rnd = new Random();
            int homeClub = rnd.Next(1, 968);
            int awayClub = rnd.Next(1, 968);
            var homeEnum = (Clubs.FootballClubs)homeClub;
            var awayEnum = (Clubs.FootballClubs)awayClub;
            
            return new Bet()
            {
                HomeTeam = homeEnum.ToString(),
                AwayTeam = awayEnum.ToString(),
                Odds = RandomNumberBetween(),
                ImageName = "http://lorempixel.com/200/200/sports", 
                PreviousResults = GetHistoricalEvents(homeEnum, awayEnum)
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

        private IEnumerable<PreviousResults> GetHistoricalEvents(Clubs.FootballClubs homeTeam, Clubs.FootballClubs awayTeam)
        {
            List<PreviousResults> list = new List<PreviousResults>();
            Random rnd = new Random();
            int numberOfLoops = rnd.Next(1, 10);
            for (int i = 0; i < numberOfLoops; i++)
            {
                list.Add(new PreviousResults()
                {
                    HomeTeam = homeTeam.ToString(),
                    AwayTeam = awayTeam.ToString(),
                    AwayTeamScore = rnd.Next(0, 10),
                    HomeTeamScore = rnd.Next(0, 10),
                    MatchDate = new DateTime(rnd.Next(1960, 2014), rnd.Next(1,12), rnd.Next(1,28))
                });
            }

            return list;
        }

    }
}
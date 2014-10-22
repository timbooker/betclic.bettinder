using System;
using System.Collections.Generic;
using BetClic.BetTinder.Core.Entities;
using BetClic.BetTinder.Core.Extensions;
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
            var bet = (BetMarkets.BetType)rnd.Next(1, 8);
            var betDesc = (BetMarkets.BetOn) rnd.Next(1, 2);
            return new Bet()
            {
                HomeTeam = homeEnum.ToString().PascalToSentence(),
                AwayTeam = awayEnum.ToString().PascalToSentence(),
                Odds = RandomNumberBetween(),
                BetType = bet.ToString().PascalToSentence(),
                BetTypeDescription = betDesc.ToString().PascalToSentence(),
                Description = GetDescription(homeEnum, awayEnum),
                ImageName = string.Format("http://lorempixel.com/200/200/sports?x={0}", new Random().Next()),// get from placeholder website directly (http://somephwebsite/football/etc)
                PreviousResults = GetHistoricalEvents(homeEnum, awayEnum)
            };
        }

        private string GetDescription(Clubs.FootballClubs homeTeam, Clubs.FootballClubs awayTeam)
        {
            //var rand = new Random();
            //var random = rand.Next(1, 2);
            //var res = homeTeam;
            //if (random == 1)
            //    res = awayTeam;

            return string.Format("{0} - {1}", homeTeam.ToString().PascalToSentence(), awayTeam.ToString().PascalToSentence());
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
                    HomeTeam = homeTeam.ToString().PascalToSentence(),
                    AwayTeam = awayTeam.ToString().PascalToSentence(),
                    AwayTeamScore = rnd.Next(0, 10),
                    HomeTeamScore = rnd.Next(0, 10),
                    MatchDate = new DateTime(rnd.Next(1960, 2014), rnd.Next(1,12), rnd.Next(1,28))
                });
            }

            return list;
        }

    }
}
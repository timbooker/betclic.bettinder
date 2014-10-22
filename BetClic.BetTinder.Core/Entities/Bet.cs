using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using BetClic.BetTinder.Core.Extensions;

namespace BetClic.BetTinder.Core.Services
{
    public class Bet
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public double Odds { get; set; }
        public string Description { get; set; }
        public string BetType { get; set; }
        public string BetTypeDescription { get; set; }
        public string ImageName { get; set; }
        public IEnumerable<PreviousResults> PreviousResults { get; set; }
    }

    public class PreviousResults
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }  
        public DateTime MatchDate { get; set; }

        public string Description
        {
            get { return MatchDate.ToString("ddd dd") + " " + HomeTeam.PascalToSentence() + " vs " + AwayTeam.PascalToSentence() + ", " + HomeTeamScore + " - " + AwayTeamScore; }
        }
    }
}
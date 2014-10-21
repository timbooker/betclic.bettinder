using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BetClic.BetTinder.Core.Services
{
    public class Bet
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public double Odds { get; set; }
        public string Description { get; set; }
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
            get { return "Date : " + MatchDate + HomeTeam + "vs " + AwayTeam + ", Score : " + HomeTeamScore + " - " + AwayTeamScore; }
        }
    }
}
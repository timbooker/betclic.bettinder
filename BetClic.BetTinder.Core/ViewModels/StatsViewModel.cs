using System.Collections;
using System.Collections.Generic;
using BetClic.BetTinder.Core.Services;
using Newtonsoft.Json;

namespace BetClic.BetTinder.Core.ViewModels
{
    public class StatsViewModel : BaseViewModel
    {
        public void Init(string previousResults)
        {
            PreviousResults = JsonConvert.DeserializeObject<List<PreviousResults>>(previousResults);
        }

        public IEnumerable<PreviousResults> PreviousResults { get; set; }
    }
    public class PreviousBetsViewModel : BaseViewModel
    {
        public void Init(string previousBets)
        {
            PreviousBets = JsonConvert.DeserializeObject<List<Bet>>(previousBets);
        }

        public IEnumerable<Bet> PreviousBets { get; set; }
    }
}
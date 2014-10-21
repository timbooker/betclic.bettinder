using System.Collections;
using System.Collections.Generic;
using BetClic.BetTinder.Core.Services;

namespace BetClic.BetTinder.Core.ViewModels
{
    public class StatsViewModel : BaseViewModel
    {
        
        public void Init(IEnumerable<PreviousResults> previousResults)
        {
            PreviousResults = previousResults;
        }

        public IEnumerable<PreviousResults> PreviousResults { get; set; }
    }
}
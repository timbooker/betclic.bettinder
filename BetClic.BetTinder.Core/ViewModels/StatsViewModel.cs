using BetClic.BetTinder.Core.Services;

namespace BetClic.BetTinder.Core.ViewModels
{
    public class StatsViewModel : BaseViewModel
    {
        
        public void Init(Bet bet)
        {
            Bet = bet;
        }

        public Bet Bet { get; set; }
    }
}
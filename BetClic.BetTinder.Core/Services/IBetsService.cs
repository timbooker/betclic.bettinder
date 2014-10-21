using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetClic.BetTinder.Core.Services
{
    public interface IBetsService
    {
        Bet GetNextBet();
        List<Bet> GetAcceptedBets();
        void AddAcceptedBet(Bet acceptedBet);

    }
}

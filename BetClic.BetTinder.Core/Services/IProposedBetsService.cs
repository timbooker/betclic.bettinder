using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetClic.BetTinder.Core.Services
{
    public interface IProposedBetsService
    {
        Bet GetNextBet();
    }
}

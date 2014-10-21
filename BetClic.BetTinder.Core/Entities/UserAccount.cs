using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetClic.BetTinder.Core.Services;

namespace BetClic.BetTinder.Core.Entities
{
    public class UserAccount
    {
        public UserAccount()
        {
            PreviousBets = new List<Bet>();
        }
        public string UserName { get; set; }

        public decimal Balance { get; set; }

        public IList<Bet> PreviousBets { get; set; }

    }
}

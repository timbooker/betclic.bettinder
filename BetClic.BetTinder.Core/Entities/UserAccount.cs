using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetClic.BetTinder.Core.Entities
{
    public class UserAccount
    {
        public string UserName { get; set; }

        public decimal Balance { get; set; }

        public string UserBalance
        {
            get { return string.Format("£ {0}", this.Balance); }
        }


    }
}

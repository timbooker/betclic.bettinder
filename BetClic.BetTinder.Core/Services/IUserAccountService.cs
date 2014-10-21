using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetClic.BetTinder.Core.Entities;

namespace BetClic.BetTinder.Core.Services
{
    public interface IUserAccountService
    {
        decimal GetBalance(UserAccount user);
        Entities.UserAccount GetUserAccount();
        UserAccount DeductBalance(UserAccount user, decimal balanceToDeduct);
        UserAccount IncreaseBalance(UserAccount user, decimal balanceToIncrease);
    }
}

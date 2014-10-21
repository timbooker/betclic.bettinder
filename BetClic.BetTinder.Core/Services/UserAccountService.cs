using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetClic.BetTinder.Core.Entities;

namespace BetClic.BetTinder.Core.Services
{
    public class UserAccountService : IUserAccountService


    {
        public decimal GetBalance(UserAccount user)
        {
            return user.Balance;
        }

        public UserAccount GetUserAccount()
        {
            var user = new UserAccount();
            user.Balance = (decimal)185.50;
            user.UserName = "SwipeBet1";

            return user;
        }

        public UserAccount DeductBalance(UserAccount user, decimal balanceToDeduct)
        {
            user.Balance -= balanceToDeduct;
            return user;
        }

        public UserAccount IncreaseBalance(UserAccount user, decimal balanceToIncrease)
        {
            user.Balance += balanceToIncrease;
            return user;
        }

    }
}

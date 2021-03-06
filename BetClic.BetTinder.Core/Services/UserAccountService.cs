﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetClic.BetTinder.Core.Entities;
using Cirrious.CrossCore.Core;

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

        public UserAccount DeductBalance(UserAccount user, decimal balanceToDeduct, Bet bet)
        {
            if (user.Balance < balanceToDeduct)
                throw new Exception("Nice try, you have put request for a bet greater than the balance.");
            user.Balance -= balanceToDeduct;
            user.PreviousBets.Add(bet);
            
            return new UserAccount()
            {
                UserName = user.UserName,
                Balance = user.Balance,
                PreviousBets = user.PreviousBets,
            };  
        }

        public UserAccount IncreaseBalance(UserAccount user, decimal balanceToIncrease)
        {
            user.Balance += balanceToIncrease;
            return user;
        }

    }
}

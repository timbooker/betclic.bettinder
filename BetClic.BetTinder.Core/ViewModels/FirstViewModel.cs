// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System.Collections.Generic;
using System;
using System.Linq;
using System.Runtime.Versioning;
using BetClic.BetTinder.Core.Entities;
using BetClic.BetTinder.Core.Services;
using Cirrious.MvvmCross.Plugins.Messenger;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;


namespace BetClic.BetTinder.Core.ViewModels
{
    /// <summary>
    /// Define the FirstViewModel type.
    /// </summary>
    public class FirstViewModel : BaseViewModel
    {
        private readonly IBetsService _betsService;
        private readonly IUserAccountService _userAccountService;
        public EventHandler OnBetAccepted;
        public EventHandler OnBetRejected;
        public EventHandler InsufficientFunds;

        private Bet _bet;
        private Bet _nextBet;
        private UserAccount _userAccount;
        private decimal _betAmount;
        private ICommand _acceptCommand;

        public FirstViewModel(IBetsService betsService, IUserAccountService userAccountService)
        {
            _betsService = betsService;
            _userAccountService = userAccountService;

            if (_bet == null)
                _bet = _betsService.GetNextBet();

            if (_userAccount == null)
                _userAccount = userAccountService.GetUserAccount();
            if (_nextBet == null)
                _nextBet = _betsService.GetNextBet();

            _betAmount = 2;

        }
        
        public decimal BetAmount
        {
            get { return _betAmount; }

            set { this.SetProperty(ref this._betAmount, value, () => this.BetAmount); }
        }

        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public Bet Bet
        {
            get { return _bet; }
            set { this.SetProperty(ref this._bet, value, () => this.Bet); }
        }

        public Bet NextBet
        {
            get { return _nextBet; }
            set { this.SetProperty(ref this._nextBet, value, () => this.NextBet); }
        }

        public List<Bet> AcceptedBets
        {
            get { return _betsService.GetAcceptedBets(); }
        } 

        public UserAccount UserAccount
        {
            get { return _userAccount; }
            set { this.SetProperty(ref this._userAccount, value, () => this.UserAccount); }
        }

        /// <summary>
        ///  Backing field for my command.
        /// </summary>
        public ICommand AcceptBet
        {
            get { return this._acceptCommand ?? (this._acceptCommand = new MvxCommand(AcceptBetCommand)); }
        }

        private ICommand _rejectCommand;
        private ICommand _incrementBetTotalCommand;
        private ICommand _decrementBetCommand;
        private ICommand _goToStatsCommand;

        /// <summary>
        /// Reject Bet Command
        /// </summary>
        public ICommand RejectBet
        {
            get
            {
                return this._rejectCommand ?? (this._rejectCommand = new MvxCommand(RejectBetCommand));
            }
        }

        public ICommand IncrementBet { get { return this._incrementBetTotalCommand ?? (this._incrementBetTotalCommand = new MvxCommand(IncrementBetTotal)); } }
        public ICommand DecrementBet { get { return this._decrementBetCommand ?? (this._decrementBetCommand = new MvxCommand(DecrementBetTotal)); } }
        public ICommand GoToStats { get { return this._goToStatsCommand ?? (this._goToStatsCommand = new MvxCommand(GoToStatsScreen)); } }

        private void GoToStatsScreen()
        {
            this.ShowViewModel<StatsViewModel>(Bet);
        }

        public void IncrementBetTotal()
        {
            BetAmount += 5;
        }

        public void DecrementBetTotal()
        {
            BetAmount -= 5;
        }

        /// <summary>
        /// Show the view model.
        /// </summary>
        public void AcceptBetCommand()
        {
            // validate bet
            if (_userAccount.Balance >= _betAmount)
            {
                var bet = NextBet;
                Bet = bet;
                var user = _userAccountService.DeductBalance(_userAccount, _betAmount);
                UserAccount = user;

                var nextBet = _betsService.GetNextBet();
                NextBet = nextBet;

                if (this.OnBetAccepted != null)
                {
                    this.OnBetAccepted(this, null);
                }

            }
            else
            {
                if (this.InsufficientFunds != null)
                {
                    this.InsufficientFunds(this, null);
                }
            }

            // mimicks sending to server sort of kinda maybe
            //if (PluginLoader.Instance.SendMessage("dsadjsalkd"))
            //{
            //    // message accepted 
            //    // bet object instantiation
            //    // await _propose...
            //    // AccountTotal -= Bet.BetValue
            //    Bet = _betsService.GetNextBet().First().Name;
            //}
            //else
            //{
            //    // message rejected 
            //    // bet stays the same, but message fucks off
            //}
        }

        /// <summary>
        /// Reject a Bet
        /// </summary>
        public void RejectBetCommand()
        {
            // validate bet
            var bet = NextBet;
            Bet = bet;

            var nextBet = _betsService.GetNextBet();
            NextBet = nextBet;

            if (this.OnBetRejected != null)
            {
                this.OnBetRejected(this, null);
            }

        }
        
    }
}

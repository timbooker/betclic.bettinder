// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using BetClic.BetTinder.Core.Entities;
using BetClic.BetTinder.Core.Services;
using Cirrious.MvvmCross.Plugins.Messenger;

namespace BetClic.BetTinder.Core.ViewModels
{
    using System.Windows.Input;
    using Cirrious.MvvmCross.ViewModels;

    /// <summary>
    /// Define the FirstViewModel type.
    /// </summary>
    public class FirstViewModel : BaseViewModel
    {
        private readonly IProposedBetsService _proposedBetsService;
        public EventHandler OnBetAccepted;
        public EventHandler OnBetRejected;


        public FirstViewModel(IProposedBetsService proposedBetsService, IUserAccountService userAccountService)
        {
            _proposedBetsService = proposedBetsService;
            _userAccountService = userAccountService;

            if (_bet == null)
                _bet = _proposedBetsService.GetNextBet();

            if (_userAccount == null)
                _userAccount = userAccountService.GetUserAccount();
            if (_nextBet == null)
                _nextBet = _proposedBetsService.GetNextBet();

            _betAmount = 2;

        }

        private decimal _betAmount;
        
        public decimal BetAmount
        {
            get { return _betAmount; }

            set { this.SetProperty(ref this._betAmount, value, () => this.BetAmount); }
        }


        private Bet _bet;
        private Bet _nextBet;

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
        private UserAccount _userAccount;

        public UserAccount UserAccount
        {
            get { return _userAccount; }
            set { this.SetProperty(ref this._userAccount, value, () => this.UserAccount); }
        }

        private readonly IUserAccountService _userAccountService;

        /// <summary>
        ///  Backing field for my command.
        /// </summary>
        private ICommand _acceptCommand;
        public ICommand AcceptBet
        {
            get { return this._acceptCommand ?? (this._acceptCommand = new MvxCommand(AcceptBetCommand)); }
        }

        private ICommand _rejectCommand;
        private ICommand _incrementBetTotalCommand;
        private ICommand _decrementBetCommand;

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
            var bet = NextBet;
            Bet = bet;

            var user = _userAccountService.DeductBalance(_userAccount, _betAmount);
            UserAccount = user;

            var nextBet = _proposedBetsService.GetNextBet();
            NextBet = nextBet;

            // if funds are sufficient
            if (this.OnBetAccepted != null)
            {
                this.OnBetAccepted(this, null);
            }


            // mimicks sending to server sort of kinda maybe
            //if (PluginLoader.Instance.SendMessage("dsadjsalkd"))
            //{
            //    // message accepted 
            //    // bet object instantiation
            //    // await _propose...
            //    // AccountTotal -= Bet.BetValue
            //    Bet = _proposedBetsService.GetNextBet().First().Name;
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

            var nextBet = _proposedBetsService.GetNextBet();
            NextBet = nextBet;

            if (this.OnBetRejected != null)
            {
                this.OnBetRejected(this, null);
            }

        }
        
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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

        /// <summary>
        ///  Backing field for my command.
        /// </summary>
        private MvxCommand myCommand;

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
        /// Gets My Command. 
        /// <para>
        /// An example of a command and how to navigate to another view model
        /// Note the ViewModel inside of ShowViewModel needs to change!
        /// </para>
        /// </summary>
        public ICommand AcceptBet
        {
            get { return this.myCommand ?? (this.myCommand = new MvxCommand(AcceptBetCommand)); }
        }

        /// <summary>
        /// Reject Bet Command
        /// </summary>
        public ICommand RejectBet
        {
            get
            {
                this.myCommand = new MvxCommand(RejectBetCommand);
                return this.myCommand;
            }
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

        }
        
    }
}

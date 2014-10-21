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

        }

        private decimal _betAmount;
        
        public decimal BetAmount
        {
            get { return _betAmount; }
        
            set { _betAmount = value; }
        }


        private Bet _bet;
        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public Bet Bet
        {
            get { return _bet; }
            set { this.SetProperty(ref this._bet, value, () => this.Bet); }
        }

        private UserAccount _userAccount;

        public UserAccount User
        {
            get { return _userAccount; }
            set { _userAccount = value; }
        }

        private IUserAccountService _userAccountService;


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
            var bet = _proposedBetsService.GetNextBet();
            bet.Name += "Accepted Bet";

            Bet = bet;
            _userAccount = _userAccountService.DeductBalance(_userAccount, _betAmount);

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
            var bet = _proposedBetsService.GetNextBet();
            bet.Name += "Rejected Bet";

            Bet = bet;
        }

        public void ShowAlertPopupCommand()
        {
            /// At the moment not used and done directly in the IOS View   
        }
    }
}

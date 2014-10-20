// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using BetClic.BetTinder.Core.Services;

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

        public FirstViewModel(IProposedBetsService proposedBetsService)
        {
            _proposedBetsService = proposedBetsService;
            _betName = _proposedBetsService.GetBets().First().Name;

        }

        private string _betName;
        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        public string BetName
        {
            get { return _betName; }
            set { this.SetProperty(ref this._betName, value, () => this.BetName); }
        }

        /// <summary>
        /// Gets My Command. 
        /// <para>
        /// An example of a command and how to navigate to another view model
        /// Note the ViewModel inside of ShowViewModel needs to change!
        /// </para>
        /// </summary>
        public ICommand AcceptBet
        {
            get { return this.myCommand ?? (this.myCommand = new MvxCommand(this.Show)); }
        }

        /// <summary>
        /// Show the view model.
        /// </summary>
        public void Show()
        {
            // validate bet
            BetName += " Some Value";
            // send to db

            // show 'bet accepted viewmodel'
           // this.ShowViewModel<FirstViewModel>();
        }

        
    }
}

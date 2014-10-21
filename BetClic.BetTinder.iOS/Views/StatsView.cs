using System.Drawing;
using BetClic.BetTinder.Core.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BetClic.BetTinder.iOS.Views
{
    [Register("StatsView")]
    public class StatsView : MvxTableViewController
    {
        public StatsView()
        {
            
        }

        private RectangleF _bounds;
        private UITableView _tv;

        public override void ViewDidLoad()
        {
            _bounds = UIScreen.MainScreen.Bounds;
            var sideHeights = _bounds.Height/7;
            NavigationController.SetNavigationBarHidden(false, true);

            this.View = new UIView { BackgroundColor = UIColor.Red };
            base.ViewDidLoad();
            _tv = new UITableView(UIScreen.MainScreen.Bounds);
            TableView = _tv;
            var source = new MvxStandardTableViewSource(TableView, "TitleText Description");
            TableView.Source = source;

            var set = this.CreateBindingSet<StatsView, StatsViewModel>();
            set.Bind(source).To(vm => vm.Bet.PreviousResults);
            set.Apply();
        }
    }
}
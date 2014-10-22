using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using BetClic.BetTinder.Core.Services;
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
            NavigationController.SetNavigationBarHidden(false, false);

            this.View = new UIView { BackgroundColor = UIColor.Red };
            base.ViewDidLoad();
            _tv = new UITableView(UIScreen.MainScreen.Bounds);
            TableView = _tv;
            var source = new MvxStandardTableViewSource(TableView, "TitleText Description");
            TableView.Source = source;

            var set = this.CreateBindingSet<StatsView, StatsViewModel>();
            set.Bind(source).To(vm => vm.PreviousResults);
            set.Apply();

            TableView.ReloadData();
        }
    }

    [Register("PreviousBetsView")]
    public class PreviousBetsView : MvxTableViewController
    {
        public PreviousBetsView()
        {

        }

        private RectangleF _bounds;
        private UITableView _tv;

        public override void ViewDidLoad()
        {
            _bounds = UIScreen.MainScreen.Bounds;
            var sideHeights = _bounds.Height / 7;
            NavigationController.SetNavigationBarHidden(false, false);

            this.View = new UIView { BackgroundColor = UIColor.Red };
            base.ViewDidLoad();
            _tv = new UITableView(UIScreen.MainScreen.Bounds);
            TableView = _tv;
            var source = new MvxStandardTableViewSource(TableView, "TitleText Description");
            TableView.Source = source;

            var set = this.CreateBindingSet<PreviousBetsView, PreviousBetsViewModel>();
            set.Bind(source).To(vm => vm.PreviousBets);
            set.Apply();

            TableView.ReloadData();
        }
    }
}
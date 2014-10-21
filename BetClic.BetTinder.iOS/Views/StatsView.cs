using System.Drawing;
using MonoTouch.UIKit;

namespace BetClic.BetTinder.iOS.Views
{
    public class StatsView : BaseView
    {
        public StatsView()
        {
            
        }

        private RectangleF _bounds;

        public override void ViewDidLoad()
        {
            _bounds = UIScreen.MainScreen.Bounds;
            var sideHeights = _bounds.Height/7;

            NavigationController.SetNavigationBarHidden(false, true);

            this.View = new UIView { BackgroundColor = UIColor.Red };
            base.ViewDidLoad();
        }
    }
}
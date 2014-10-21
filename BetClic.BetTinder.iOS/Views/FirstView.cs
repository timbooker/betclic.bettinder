// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Cirrious.CrossCore;
using Cirrious.MvvmCross.Binding.ExtensionMethods;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MonoTouch.CoreGraphics;

namespace BetClic.BetTinder.iOS.Views
{
    using System.Drawing;

    using Cirrious.MvvmCross.Binding.BindingContext;

    using Core.ViewModels;
    using MonoTouch.Foundation;
    using MonoTouch.UIKit;

    /// <summary>
    /// Defines the FirstView type.
    /// </summary>
    [Register("FirstView")]
    public class FirstView : BaseView
    {
        private readonly string ACCEPT_MESSAGE = "Your bet has been Submitted. Good Luck!";
        private readonly string REJECT_MESSAGE = "Bet Rejected";
        private UIImageView _mainImage;
        private UIRotationGestureRecognizer _rotationGestureRecognizer;
        private UIPanGestureRecognizer _panGesture;


        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            this.View = new UIView { BackgroundColor = UIColor.White };

            base.ViewDidLoad();

            UILabel uiLabel = new UILabel(new RectangleF(10, 10, 300, 40));
            View.AddSubview(uiLabel);
            UITextField uiTextField = new UITextField(new RectangleF(10, 50, 300, 40));
            View.AddSubview(uiTextField);

            using (var image = UIImage.FromFile("150x150.gif"))
            {
                _mainImage = new UIImageView(image) { Frame = new RectangleF(100, 100, 150, 150) };
                _mainImage.UserInteractionEnabled = true;
                View.AddSubview(_mainImage);
            }

            float r = 0;
            _rotationGestureRecognizer = new UIRotationGestureRecognizer(x =>
            {
                if ((x.State == UIGestureRecognizerState.Began || x.State == UIGestureRecognizerState.Changed))
                {
                    _mainImage.Transform = CGAffineTransform.MakeRotation(x.Rotation + r);
                }
                else if (x.State == UIGestureRecognizerState.Ended)
                {
                    r += x.Rotation;
                }
            });

            float dx = 0, dy = 0;
            PointF originalImageViewX = _mainImage.Center;
            _panGesture = new UIPanGestureRecognizer(pg =>
            {
                var p0 = pg.LocationInView(View);
                if (pg.State == UIGestureRecognizerState.Began || pg.State == UIGestureRecognizerState.Changed)
                {
                    if (dx == 0)
                        dx = p0.X - _mainImage.Center.X;

                    if (dy == 0)
                        dy = p0.Y - _mainImage.Center.Y;

                    var p1 = new PointF(p0.X - dx, p0.Y - dy);

                    _mainImage.Center = p1;
                    _mainImage.Layer.BorderWidth = 2.0f;
                    _mainImage.Transform = CGAffineTransform.MakeRotation((_mainImage.Center.X - originalImageViewX.X) / 250);

                    _mainImage.Layer.BorderColor = new CGColor(0, 0, 0);

                    if (_mainImage.Center.X > originalImageViewX.X + 50)
                    {
                        _mainImage.Layer.BorderColor = new CGColor(0, 255, 0);
                    }

                    if (_mainImage.Center.X < originalImageViewX.X - 50)
                    {
                        _mainImage.Layer.BorderColor = new CGColor(255, 0, 0);
                    }
                }

                if (pg.State == UIGestureRecognizerState.Ended)
                {
                    dx = 0;
                    var x = 12312;
                    var y = x;
                    dy = 0;

                    if (_mainImage.Center.X > originalImageViewX.X + 50)
                    {
                        // awkward, but required to break it a little to get the goodness out
                        var vm = ViewModel as FirstViewModel;
                        if (vm != null) vm.AcceptBetCommand();
                        ShowUIAlert("Bet Accepted", ACCEPT_MESSAGE);
                        
                    }
                    if (_mainImage.Center.X < originalImageViewX.X - 50)
                    {
                        // add to rejected bet pile and pop a new one
                        var vm = ViewModel as FirstViewModel;
                        if (vm != null) vm.RejectBetCommand();
                        ShowUIAlert("Bet Rejected", REJECT_MESSAGE);

                    }

                    _mainImage.Layer.BorderColor = new CGColor(0, 0, 0);
                    _mainImage.Center = originalImageViewX;
                }
            });

            _mainImage.AddGestureRecognizer(_panGesture);
            _mainImage.AddGestureRecognizer(_rotationGestureRecognizer);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(uiLabel).To(vm => vm.Bet.Name);
            set.Bind(uiTextField).To(vm => vm.Bet.Odds);
            set.Apply();

            var tap = new UITapGestureRecognizer(() => uiTextField.ResignFirstResponder());
            View.AddGestureRecognizer(tap);
        }

        /// <summary>
        /// Show UI Alert to User
        /// </summary>
        /// <param name="title">Alert Title</param>
        /// <param name="message">Alert Message</param>
        private void ShowUIAlert(string title, string message)
        {
            UIAlertView alertView = new UIAlertView(title, message, null, "Ok", null);
            alertView.Show();
        }
    }
}

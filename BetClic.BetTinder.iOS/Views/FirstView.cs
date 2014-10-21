// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
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
    using Cirrious.MvvmCross.Plugins.Messenger;

    /// <summary>
    /// Defines the FirstView type.
    /// </summary>
    [Register("FirstView")]
    public class FirstView : BaseView
    {
        private readonly string ACCEPT_MESSAGE = "Your bet has been Submitted. Good Luck!";
        private readonly string REJECT_MESSAGE = "Bet Rejected";
        private UIImageView _currentBet;
        private UIImageView _nextBet;
        private UIPanGestureRecognizer _panGesture;


        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            WireViewModelEvents();
            this.View = new UIView { BackgroundColor = UIColor.White };
            base.ViewDidLoad();            

            using (var image = UIImage.FromFile("150x150.gif"))
            {
                _nextBet = new UIImageView(image) { Frame = new RectangleF(100, 100, 150, 150) };
                View.AddSubview(_nextBet);
            }

            using (var image = UIImage.FromFile("150x150.gif"))
            {
                _currentBet = new UIImageView(image) { Frame = new RectangleF(100, 100, 150, 150) };
                _currentBet.UserInteractionEnabled = true;
                View.AddSubview(_currentBet);
            }

            var screenBounds = UIScreen.MainScreen.Bounds;

            // Load Buttons Part
            var acceptButton = UIButton.FromType(UIButtonType.Custom);
            acceptButton.SetImage(UIImage.FromFile("accept.png"), UIControlState.Normal);

            var buttonWidth = 50;
            var buttonHeight = 50;
            acceptButton.Frame = new RectangleF(
                10,
                300,
                buttonWidth,
                buttonHeight);

            View.AddSubview(acceptButton);

            var rejectButton = UIButton.FromType(UIButtonType.Custom);
            rejectButton.SetImage(UIImage.FromFile("reject.png"), UIControlState.Normal);
            rejectButton.Frame = new RectangleF(
                150,
                300,
                buttonWidth,
                buttonHeight);

            View.AddSubview(rejectButton);

            var plusButton = UIButton.FromType(UIButtonType.Custom);
            acceptButton.SetImage(UIImage.FromFile("accept.png"), UIControlState.Normal);
            acceptButton.Center = new PointF(90, 450);
            acceptButton.SizeThatFits(new SizeF(50, 50));

            var minusButton = UIButton.FromType(UIButtonType.Custom);
            acceptButton.SetImage(UIImage.FromFile("accept.png"), UIControlState.Normal);
            acceptButton.Center = new PointF(90, 490);
            acceptButton.SizeThatFits(new SizeF(50, 50));

            HandleMovement();

            _currentBet.AddGestureRecognizer(_panGesture);

            var uiLabel = new UILabel(new RectangleF(10, 10, 300, 40));
            View.AddSubview(uiLabel);


            var uiLabelBetAmount = new UILabel(new RectangleF(10, 90, 300, 40));
            View.AddSubview(uiLabelBetAmount);

            var uiTextField = new UITextField(new RectangleF(10, 50, 300, 40));
            View.AddSubview(uiTextField);
            var userName = new UILabel(new RectangleF(10, 200, 300, 40));
            View.AddSubview(userName);
            var balance = new UILabel(new RectangleF(10, 250, 300, 40));
            View.AddSubview(balance);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(uiLabel).To(vm => vm.Bet.Name);
            set.Bind(uiTextField).To(vm => vm.Bet.Odds);
            set.Bind(userName).To(vm => vm.UserAccount.UserName);
            set.Bind(uiLabelBetAmount).To(vm => vm.BetAmount);
            set.Bind(balance).To(vm => vm.UserAccount.Balance);
            set.Bind(rejectButton).To(vm => vm.RejectBet);
            set.Bind(acceptButton).To(vm => vm.AcceptBet);
            set.Apply();

            var tap = new UITapGestureRecognizer(() => uiTextField.ResignFirstResponder());
            View.AddGestureRecognizer(tap);
        }

        /// <summary>
        /// Wire View Model Events
        /// </summary>
        private void WireViewModelEvents()
        {
            var vm = (FirstViewModel) this.DataContext;
            vm.OnBetAccepted += (sender, args) => { AcceptBetHandler(sender, args); };
            vm.OnBetRejected += (sender, args) => { RejectedBetHandler(sender, args); };
        }

        private void HandleMovement()
        {
            float dx = 0, dy = 0;
            PointF originalImageViewX = _currentBet.Center;
            _panGesture = new UIPanGestureRecognizer(pg =>
            {
                var p0 = pg.LocationInView(View);
                if (pg.State == UIGestureRecognizerState.Began || pg.State == UIGestureRecognizerState.Changed)
                {
                    if (dx == 0)
                        dx = p0.X - _currentBet.Center.X;

                    if (dy == 0)
                        dy = p0.Y - _currentBet.Center.Y;

                    var p1 = new PointF(p0.X - dx, p0.Y - dy);

                    _currentBet.Center = p1;
                    _currentBet.Layer.BorderWidth = 2.0f;
                    //_currentBet.Transform = CGAffineTransform.MakeRotation((_currentBet.Center.X - originalImageViewX.X)/250);

                    _currentBet.Layer.BorderColor = new CGColor(0, 0, 0);

                    if (_currentBet.Center.X > originalImageViewX.X + 50)
                    {
                        _currentBet.Layer.BorderColor = new CGColor(0, 255, 0);
                    }

                    if (_currentBet.Center.X < originalImageViewX.X - 50)
                    {
                        _currentBet.Layer.BorderColor = new CGColor(255, 0, 0);
                    }
                }

                if (pg.State == UIGestureRecognizerState.Ended)
                {
                    dx = 0;
                    var x = 12312;
                    var y = x;
                    dy = 0;

                    if (_currentBet.Center.X > originalImageViewX.X + 50)
                    {
                        AcceptBet();
                    }
                    if (_currentBet.Center.X < originalImageViewX.X - 50)
                    {
                        RejectBet();
                    }

                    _currentBet.Layer.BorderColor = new CGColor(0, 0, 0);
                    _currentBet.Center = originalImageViewX;
                }
            });
        }

        private void AcceptBet()
        {
            // awkward, but required to break it a little to get the goodness out
            var vm = ViewModel as FirstViewModel;
            if (vm != null) vm.AcceptBetCommand();
        }

        private void RejectBet()
        {
            // add to rejected bet pile and pop a new one
            var vm = ViewModel as FirstViewModel;
            if (vm != null) vm.RejectBetCommand();
        }

        private void RejectedBetHandler(object o, EventArgs e)
        {
            ShowUIAlert("Bet Rejected", REJECT_MESSAGE);            
        }

        private void AcceptBetHandler(object o, EventArgs e)
        {
            ShowUIAlert("Bet Accepted", ACCEPT_MESSAGE);
        }

        /// <summary>
        /// Show UI Alert to UserAccount
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

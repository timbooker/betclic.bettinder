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
        private readonly string INSUFFICIENT_FUNDS_MESSAGE = "Woopsie.. You do not have sufficient funnds.";
        private readonly string REJECT_MESSAGE = "Bet Rejected.";
        private UIImageView _currentBet;
        private UIImageView _nextBet;
        private UIPanGestureRecognizer _panGesture;
        private UITextField _uiTextFieldBetAmount;
        private UIImageView _playerIcon;
        private RectangleF _bounds;
        private MvxImageViewLoader _mvxImageViewLoader;
        private MvxImageViewLoader _mvxNextImageViewLoader;

        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            _bounds = UIScreen.MainScreen.Bounds;

            NavigationController.SetNavigationBarHidden(true, true);

            this.View = new UIView { BackgroundColor = UIColor.White };
            base.ViewDidLoad();

            CreateTopBar();

            _nextBet = new UIImageView() { Frame = new RectangleF(100, 100, 175, 175) };
            View.AddSubview(_nextBet);

            _currentBet = new UIImageView() { Frame = new RectangleF(100, 100, 150, 150) };
            _currentBet.UserInteractionEnabled = true;
            View.AddSubview(_currentBet);

            _mvxImageViewLoader = new MvxImageViewLoader(() => _currentBet);
            _mvxNextImageViewLoader = new MvxImageViewLoader(() => _nextBet);

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

            _uiTextFieldBetAmount = new UITextField(new RectangleF(10, 320, 300, 40));
            _uiTextFieldBetAmount.KeyboardType = UIKeyboardType.NumberPad;
            View.AddSubview(_uiTextFieldBetAmount);

            var plusButton = UIButton.FromType(UIButtonType.Custom);
            plusButton.SetImage(UIImage.FromFile("accept.png"), UIControlState.Normal);
            plusButton.Frame = new RectangleF(
                50,
                320,
                buttonWidth,
                buttonHeight);
            View.AddSubview(plusButton);

            var minusButton = UIButton.FromType(UIButtonType.Custom);
            minusButton.SetImage(UIImage.FromFile("reject.png"), UIControlState.Normal);
            minusButton.Frame = new RectangleF(
                90,
                320,
                buttonWidth,
                buttonHeight);
            View.AddSubview(minusButton);

            HandleMovement();

            _currentBet.AddGestureRecognizer(_panGesture);

            var uiLabel = new UILabel(new RectangleF(10, 10, 300, 40));
            View.AddSubview(uiLabel);
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
            set.Bind(balance).To(vm => vm.UserAccount.Balance);
            set.Bind(rejectButton).To(vm => vm.RejectBet);
            set.Bind(acceptButton).To(vm => vm.AcceptBet);
            set.Bind(plusButton).To(vm => vm.IncrementBet);
            set.Bind(minusButton).To(vm => vm.DecrementBet);
            set.Bind(_uiTextFieldBetAmount).To(vm => vm.BetAmount);
            set.Bind(_mvxImageViewLoader).To(vm => vm.Bet.ImageName);
            set.Bind(_mvxNextImageViewLoader).To(vm => vm.NextBet.ImageName);
            set.Apply();


            var tap = new UITapGestureRecognizer(() => uiTextField.ResignFirstResponder());
            View.AddGestureRecognizer(tap);


            WireViewModelEvents();
        }

        private void CreateTopBar()
        {
            var sideWidths = _bounds.Width / 7;
            var sideHeights = _bounds.Height / 7;

            // View.BackgroundColor = new UIColor(new CGColor("Gray"));
            using (var image = UIImage.FromFile("PlayerIcon.png"))
            {
                _playerIcon = new UIImageView(image)
                {
                    Frame = new RectangleF(0, 25, 58, 56),
                };
                View.AddSubview(_playerIcon);
            }
        }

        /// <summary>
        /// Wire View Model Events
        /// </summary>
        private void WireViewModelEvents()
        {
            var vm = (FirstViewModel)this.ViewModel;
            vm.OnBetAccepted += (sender, args) => { AcceptBetHandler(sender, args); };
            vm.OnBetRejected += (sender, args) => { RejectedBetHandler(sender, args); };
            vm.InsufficientFunds += (sender, args) => { InsufficientFundsHandler(sender, args); };
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

        private void InsufficientFundsHandler(object o, EventArgs e)
        {
            ShowUIAlert("Bet Rejected", INSUFFICIENT_FUNDS_MESSAGE);
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

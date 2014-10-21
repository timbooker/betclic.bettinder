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
        private UIImageView _logo;
        private UIImageView _betsList;
        private UIButton _btnAccept;
        private UIButton _btnReject;
        private UIButton _btnStats;
        private UIButton _btnIncreaseBet;
        private UIButton _btnDecreaseBet;
        private RectangleF _bounds;
        private MvxImageViewLoader _mvxImageViewLoader;
        private MvxImageViewLoader _mvxNextImageViewLoader;

        private UILabel _lblUserBalance;
        private float sideHeights;

        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            _bounds = UIScreen.MainScreen.Bounds;
            sideHeights = _bounds.Height/7;

            NavigationController.SetNavigationBarHidden(true, true);

            this.View = new UIView { BackgroundColor = new UIColor(246, 245, 241, 0.5f)};
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
            CreateBottomPart();

            HandleMovement();

            _currentBet.AddGestureRecognizer(_panGesture);

            var uiLabel = new UILabel(new RectangleF(10, 10, 300, 40));
            View.AddSubview(uiLabel);
            var uiTextField = new UITextField(new RectangleF(10, 50, 300, 40));
            View.AddSubview(uiTextField);
            var userName = new UILabel(new RectangleF(10, 200, 300, 40));
            View.AddSubview(userName);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(uiLabel).To(vm => vm.Bet.HomeTeam);
            set.Bind(uiTextField).To(vm => vm.Bet.Odds);
            set.Bind(userName).To(vm => vm.UserAccount.UserName);
            set.Bind(_lblUserBalance).To(vm => vm.UserAccount.Balance);
            set.Bind(_btnReject).To(vm => vm.RejectBet);
            set.Bind(_btnAccept).To(vm => vm.AcceptBet);
            set.Bind(_btnIncreaseBet).To(vm => vm.IncrementBet);
            set.Bind(_btnDecreaseBet).To(vm => vm.DecrementBet);
            set.Bind(_btnStats).To(vm => vm.GoToStats);
            set.Bind(_uiTextFieldBetAmount).To(vm => vm.BetAmount);
            set.Bind(_mvxImageViewLoader).To(vm => vm.Bet.ImageName);
            set.Bind(_mvxNextImageViewLoader).To(vm => vm.NextBet.ImageName);
            set.Apply();


            var tap = new UITapGestureRecognizer(() => uiTextField.ResignFirstResponder());
            View.AddGestureRecognizer(tap);


            WireViewModelEvents();
        }

        /// <summary>
        /// Create Top Bar
        /// </summary>
        private void CreateTopBar()
        {
            var yTop = 20;
            var yBottom = 20 + sideHeights;

            var sideWidths = _bounds.Width / 7;


            // Player Icon
            using (var image = UIImage.FromFile("PlayerIcon.png"))
            {
                _playerIcon = new UIImageView(image)
                {
                    Frame = new RectangleF(0, yTop, sideWidths, sideHeights),
                };
                View.AddSubview(_playerIcon);
            }

            // Add User Balance
            _lblUserBalance= new UILabel(new RectangleF(0, yTop+ (sideHeights / 2), sideWidths, (sideHeights/ 2)));
            View.AddSubview(_lblUserBalance);

            // Logo
            using (var image = UIImage.FromFile("Logo.png"))
            {
                _logo = new UIImageView(image)
                {
                    Frame = new RectangleF(sideWidths, yTop, sideWidths*5, sideHeights),
                };
                View.AddSubview(_logo);
            }

            // Bets Part
            using (var image = UIImage.FromFile("Bets.png"))
            {
                _betsList = new UIImageView(image)
                {
                    Frame = new RectangleF(sideWidths*6, yTop, sideWidths, sideHeights)
                };
                View.AddSubview(_betsList);
            }
        }

        /// <summary>
        /// Create Bottom Area
        /// </summary>
        private void CreateBottomPart()
        {
            
            var sideWidths = _bounds.Width / 8;

            float yTop = sideHeights*6;

            // Add Reject Button
            using (var image = UIImage.FromFile("BtnReject.png"))
            {
                _btnReject = UIButton.FromType(UIButtonType.Custom);
                _btnReject.SetImage(image, UIControlState.Normal);
                _btnReject.Frame = new RectangleF(sideWidths, yTop, 2*sideWidths, sideHeights);                
                View.AddSubview(_btnReject);
            }

            // Add Statistics Button
            using (var image = UIImage.FromFile("CentreButton.png"))
            {
                _btnStats = UIButton.FromType(UIButtonType.Custom);
                _btnStats.SetImage(image, UIControlState.Normal);
                _btnStats.Frame = new RectangleF(sideWidths*3, yTop, sideWidths, sideHeights);
                View.AddSubview(_btnStats);
            }

            // Add Accept Button
            using (var image = UIImage.FromFile("BtnAccept.png"))
            {
                _btnAccept = UIButton.FromType(UIButtonType.Custom);
                _btnAccept.SetImage(image, UIControlState.Normal);
                _btnAccept.Frame = new RectangleF(sideWidths*4, yTop, sideWidths*2, sideHeights);
                View.AddSubview(_btnAccept);
            }

            // Bet Amount Part

            // Split Bet Part Height in 5 pieces. Arrows = 1 piece each, BetAmount = 2 pieces, 0.5 space
            var betPartHeight = (float)sideHeights/5;

            // Leave some space from 
            var betPartWidth = sideWidths/9;
            var betPartStartX = (sideWidths*6) + (betPartWidth);
            betPartWidth *= 7;
            yTop += (float)(betPartHeight*0.5);
            
            // Increase Bet Arrow Button
            using (var image = UIImage.FromFile("ArrowUp.png"))
            {
                _btnIncreaseBet = UIButton.FromType(UIButtonType.Custom);
                _btnIncreaseBet.SetImage(image, UIControlState.Normal);
                _btnIncreaseBet.Frame = new RectangleF(betPartStartX, yTop, betPartWidth,betPartHeight);
                View.AddSubview(_btnIncreaseBet);
            }

            yTop += betPartHeight;

            // Bet Amount textbox
            _uiTextFieldBetAmount =
                new UITextField(new RectangleF(betPartStartX, yTop, betPartWidth, betPartHeight*2));
            _uiTextFieldBetAmount.KeyboardType = UIKeyboardType.NumberPad;
            View.AddSubview(_uiTextFieldBetAmount);

            yTop += (betPartHeight*2);

            // Decrease Bet Arrow Button
            using (var image = UIImage.FromFile("ArrowDown"))
            {
                _btnDecreaseBet = UIButton.FromType(UIButtonType.Custom);
                _btnDecreaseBet.SetImage(image, UIControlState.Normal);
                _btnDecreaseBet.Frame = new RectangleF(betPartStartX, yTop, betPartWidth, betPartHeight);
                View.AddSubview(_btnDecreaseBet);
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

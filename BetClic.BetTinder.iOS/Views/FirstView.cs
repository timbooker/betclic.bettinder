// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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
        private UIImageView _mainImage;
        private UIRotationGestureRecognizer _rotationGestureRecognizer;
        private UIPanGestureRecognizer panGesture;

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
                _mainImage = new UIImageView(image) {Frame = new RectangleF(10, 100, 150, 150)};
                _mainImage.UserInteractionEnabled = true;
                View.AddSubview(_mainImage);
            };

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
            panGesture = new UIPanGestureRecognizer(pg =>
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
                }

                if (pg.State == UIGestureRecognizerState.Ended)
                {
                    dx = 0;
                    dy = 0;

                    if (p0.X > 600)
                    {
                        // add to accepted bets and change vm
                    }
                    if (p0.X < 100)
                    {
                        // add to rejected bet pile and pop a new one
                    }

                    _mainImage.Center = new PointF(10, 100);
                }
            });

            _mainImage.AddGestureRecognizer(panGesture);
            _mainImage.AddGestureRecognizer(_rotationGestureRecognizer);

            var button = new UIButton(new RectangleF(10, 100, 300, 40));
            button.TitleLabel.Text = "click me";
            View.AddSubview(button);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(uiLabel).To(vm => vm.BetName);
            set.Bind(button).To(vm => vm.AcceptBet);
            set.Bind(uiTextField).To(vm => vm.BetName);
            set.Apply();

            var tap = new UITapGestureRecognizer(() => uiTextField.ResignFirstResponder());
            View.AddGestureRecognizer(tap);
        }
    }
}

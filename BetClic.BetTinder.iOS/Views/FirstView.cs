// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
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

#if IOS
using Microsoft.Maui.Platform;
using iOSMauiScrollUpOnKeyboardShow.Platforms.iOS.Utils;
using UIKit;
using CoreGraphics;
#endif

namespace iOSMauiScrollUpOnKeyboardShow.Controls
{
    public class FixedScrollView : ScrollView
    {
        public FixedScrollView()
        {
#if IOS
            UIKeyboard.Notifications.ObserveWillShow(OnKeyboardShowing);
            UIKeyboard.Notifications.ObserveWillHide(OnKeyboardHiding);
#endif
        }

#if IOS
        private void OnKeyboardShowing(object sender, UIKeyboardEventArgs args)
        {
            if (Shell.Current.CurrentPage is ContentPage page)
            {
                UIView control = this.ToPlatform(Handler.MauiContext).FindFirstResponder();
                UIView rootUiView = page.Content.ToPlatform(Handler.MauiContext);
                CGRect kbFrame = UIKeyboard.FrameEndFromNotification(args.Notification);
                double distance = control.GetOverlapDistance(rootUiView, kbFrame);
                if (distance > 0)
                {
                    Margin = new Thickness(Margin.Left, -distance, Margin.Right, distance);
                }
            }
        }
        private void OnKeyboardHiding(object sender, UIKeyboardEventArgs args)
        {
            Margin = new Thickness(Margin.Left, 0, Margin.Right, 0);
        }
#endif
    }
}

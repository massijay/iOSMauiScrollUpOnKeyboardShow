# iOSMauiScrollUpOnKeyboardShow

#### Note: [This issue shouldn't occur on .NET MAUI 8 and above](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor?view=net-maui-8.0#create-an-editor).

.NET Maui App that demonstrate how to scroll the page up when the keyboard is shown on iOS.

This affects only the iOS platform, Android (and hopefully the others) are unaffected and the behavior on these is the default one.

It works extending the ScrollView class and changing it's margin (top and bottom) if it's needed to.

The idea is taken from the [KeyboardOverlap](https://github.com/lelebs/Xamarin.Forms.Plugins/tree/master/KeyboardOverlap) plugin for Xamarin.Forms.

## Before (using default ScrollView)
https://user-images.githubusercontent.com/16278647/221863306-0b003754-8385-4981-b552-04a599bc83ea.mp4

## After (using FixedScrollView)
https://user-images.githubusercontent.com/16278647/221863500-f9c66894-847e-4b13-8105-de284f47c0af.mp4

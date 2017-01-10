// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinApplozicDemo
{
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ChatListBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LaunchContextB { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Logout { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton OneToOneChatBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView UreadCount { get; set; }

        [Action ("ChatListBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ChatListBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("LaunchContextB_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LaunchContextB_TouchUpInside (UIKit.UIButton sender);

        [Action ("Logout_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Logout_TouchUpInside (UIKit.UIButton sender);

        [Action ("OneToOneChatBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OneToOneChatBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ChatListBtn != null) {
                ChatListBtn.Dispose ();
                ChatListBtn = null;
            }

            if (LaunchContextB != null) {
                LaunchContextB.Dispose ();
                LaunchContextB = null;
            }

            if (Logout != null) {
                Logout.Dispose ();
                Logout = null;
            }

            if (OneToOneChatBtn != null) {
                OneToOneChatBtn.Dispose ();
                OneToOneChatBtn = null;
            }

            if (UreadCount != null) {
                UreadCount.Dispose ();
                UreadCount = null;
            }
        }
    }
}
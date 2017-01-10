using System;
using Newtonsoft.Json; 
using Foundation;
using UIKit;
using ApplozicXamarinWrapper;

namespace XamarinApplozicDemo
{
	public partial class MainViewController : UIViewController
	{
		
		partial void OneToOneChatBtn_TouchUpInside(UIButton sender)
		{
			UIAlertController alert = UIAlertController.Create("Applozic Demo!!!", "Enter userId of receiver", UIAlertControllerStyle.Alert);
			alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, action =>
			{
				// This code is invoked when the user taps on login, and this shows how to access the field values
				Console.WriteLine("UserID: {0}", alert.TextFields[0].Text);
				String userId = alert.TextFields[0].Text;

				if (String.IsNullOrEmpty(userId))
				{

					new UIAlertView("", "Please enter userId" , null, "OK", null).Show();
					return;

				}
				ALChatManager.launchChatForUser(userId, this);

			}));

			//Cancel 
			alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Default, action =>
			{
				Console.WriteLine("UserID: {0}", alert.TextFields[0].Text);
			}));

			alert.AddTextField((field) =>
			{
				field.Placeholder = "userId";
			});

			PresentViewController(alert, animated: true, completionHandler: null);

		}

		partial void ChatListBtn_TouchUpInside(UIButton sender)
		{
			ALChatManager.launchChatList(this);
		}

		partial void LaunchContextB_TouchUpInside(UIButton sender)
		{
			ALChatManager.launchContextBasedChat(createConversation(), this);
		}

		partial void Logout_TouchUpInside(UIButton sender)
		{
			ALChatManager.logout();
			this.DismissViewControllerAsync(false);
		}


		//ADD THIS METHOD :

		public void NewMessageHandler( NSNotification obj )
		{
			int count = ALChatManager.GetUreadCount();
			Console.WriteLine("Unread count is {0}",count);
			this.UreadCount.Text = "Unread count : " + count;

		}




		protected MainViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			NSNotificationCenter notification = NSNotificationCenter.DefaultCenter;
			//notification.AddObserver(this, new Selector("newMessageHandler"),
			//                         (NSString) "newMessageNotification",null);
			this.UreadCount.Text = "Unread count : " + ALChatManager.GetUreadCount();
			notification.AddObserver((NSString) "newMessageNotification",NewMessageHandler);
		}

		public ALConversationProxy createConversation()
		{

			ALConversationProxy alConversationProxy = new ALConversationProxy();
			alConversationProxy.TopicId = @"laptop01";
			alConversationProxy.UserId = @"adarshk";

			// Note : Uncomment following two lines to set SMS fallback's format.
			/*
				[alConversationProxy setSenderSMSFormat:@"SENDER SMS FORMAT"];
				[alConversationProxy setReceiverSMSFormat:@"RECEIVER SMS FORMAT"];
			*/

			ALTopicDetail ALTopicDetail = new ALTopicDetail();
			ALTopicDetail.Title = @"Mac Book Pro";
			ALTopicDetail.Subtitle = @"13' Retina";
			ALTopicDetail.Link = @"https://raw.githubusercontent.com/AppLozic/Applozic-iOS-SDK/master/macbookpro.jpg";
			ALTopicDetail.Key1 = @"Product ID";
			ALTopicDetail.Value1 = @"mac-pro-r-13";
			ALTopicDetail.Key2 = @"Price";
			ALTopicDetail.Value2 = @"Rs.1,04,999.00";
			NSDictionary dict = ALTopicDetail.Dictionary;
			NSError error = null;
			NSData TopicData = NSJsonSerialization.Serialize(dict, 0 ,out error);

			string resultTopicDetails =  new NSString( TopicData, NSStringEncoding.UTF8);

			Console.WriteLine("ALTopicDetail ### {0} ", resultTopicDetails);

			alConversationProxy.TopicDetailJson = resultTopicDetails;

			return alConversationProxy;


		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);

		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


	}
}

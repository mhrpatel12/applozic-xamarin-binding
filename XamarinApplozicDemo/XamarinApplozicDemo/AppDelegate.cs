using Foundation;
using UIKit;
using System;
using ApplozicXamarinWrapper;

namespace XamarinApplozicDemo
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window
		{
			get;
			set;
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method


			if (ALUserDefaultsHandler.IsLoggedIn)
			{

				ALPushNotificationService.UserSync();
        		// Get login screen from storyboard and present it
      			UIStoryboard Storyboard = UIStoryboard.FromName("Main", null);
				MainViewController MainViewController = Storyboard.InstantiateViewController("MainViewController") as MainViewController;
				this.Window.MakeKeyAndVisible();
				this.Window.RootViewController.PresentViewController(MainViewController, true, () => { });

			}

			ALAppLocalNotifications localNotification = ALAppLocalNotifications.AppLocalNotificationHandler;
			localNotification.DataConnectionNotificationHandler();

			if (launchOptions != null)
			{
				NSDictionary dictionary = (Foundation.NSDictionary)launchOptions.ObjectForKey(UIApplication.LaunchOptionsRemoteNotificationKey);

				if (dictionary != null)
				{
					Console.WriteLine(@"Launched from push notification: {0} ", dictionary);
					ALPushNotificationService pushNotificationService = new ALPushNotificationService();
					Boolean applozicProcessed = pushNotificationService.ProcessPushNotification(dictionary, 0);

					if (!applozicProcessed)
					{
						//Note: notification for app
					}
				}
			}

			ALChatManager.registerNotification();

			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message)
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground(UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground(UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void OnActivated(UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive.
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate(UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}


		public override void FailedToRegisterForRemoteNotifications(UIApplication application, NSError error)
		{
			new UIAlertView("Error registering push notifications", error.LocalizedDescription, null, "OK", null).Show();
		}


		public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
		{
			// Get current device token
			var DeviceToken = deviceToken.Description;
			if (!string.IsNullOrWhiteSpace(DeviceToken))
			{
				DeviceToken = DeviceToken.Trim('<').Trim('>').Replace(" ", "");
			}

			Console.WriteLine(" PushDeviceToken ###" + DeviceToken.Replace(' ', ' '));

			// Get previous device token
			var oldDeviceToken = NSUserDefaults.StandardUserDefaults.StringForKey("PushDeviceToken");

			// Has the token changed?
			if (string.IsNullOrEmpty(oldDeviceToken) || !oldDeviceToken.Equals(DeviceToken))
			{
				ALRegisterUserClientService registerUserClientService = new ALRegisterUserClientService();

				registerUserClientService.UpdateApnDeviceTokenWithCompletion(DeviceToken, (rResponse, error) =>
				{

					if (error != null)
					{

						Console.WriteLine("REGISTRATION ERROR :: {0}", error.Description);
						return;
					}
					Console.WriteLine("Registration response from server : {0}", rResponse);
				});
			}

			// Save new device token
			NSUserDefaults.StandardUserDefaults.SetString(DeviceToken, "PushDeviceToken");
		}

		//With completion handler...this is background mode
		public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
		{
			Console.WriteLine("RECEIVED_NOTIFICATION_WITH_COMPLETION ::{0} ", userInfo);

			ALPushNotificationService pushNotificationService = new ALPushNotificationService();
			pushNotificationService.NotificationArrivedToApplication(application, userInfo);
			completionHandler(UIBackgroundFetchResult.NewData);
			//base.DidReceiveRemoteNotification(application, userInfo, completionHandler);
		}

		//normal notification mode
		public override void ReceivedRemoteNotification(UIApplication application, NSDictionary userInfo)
		{
			Console.WriteLine("RECEIVED_NOTIFICATION_WITH_COMPLETION ::{0} ", userInfo);
			base.ReceivedRemoteNotification(application, userInfo);
		}


	}

}


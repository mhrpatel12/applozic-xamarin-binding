using System;

using UIKit;
using ApplozicXamarinWrapper;
using Foundation;

namespace XamarinApplozicDemo
{
	public partial class LoginViewController : UIViewController
	{
		partial void LoginButton_TouchUpInside(UIButton sender)
		{
			//Registration code here. Build your user details.
			ALUser user = new ALUser();
			user.ApplicationId = ALChatManager.application_id;
			user.UserId = userIdTextField.Text;
			user.Password = passwordTextField.Text;
			ALUserDefaultsHandler.SetPassword(user.Password);
			ALUserDefaultsHandler.SetUserAuthenticationTypeId( (short)AuthenticationType.Applozic );

			//Applozic registartion code.
			ALRegisterUserClientService userClientService = new ALRegisterUserClientService();
			userClientService.InitWithCompletion(user, (ALRegistrationResponse response, NSError error) =>
			{
				if (error == null && response.DeviceKey != null)
				{
					//Check for APNS deviceToken. If not done already, ask for registartion token.
					if (String.IsNullOrEmpty(ALUserDefaultsHandler.ApnDeviceToken))
					{
						ALChatManager.registerNotification();
					}
				
					UIStoryboard Storyboard = UIStoryboard.FromName("Main", null);
					MainViewController MainViewController = Storyboard.InstantiateViewController("MainViewController") as MainViewController;
					this.PresentViewController(MainViewController, true, () => { });
				}
				else
				{
					String description = error != null ? error.LocalizedDescription : response.Message;
					new UIAlertView("Opps!!!", description, null, "OK", null).Show();
				}
			});
		}

		protected LoginViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


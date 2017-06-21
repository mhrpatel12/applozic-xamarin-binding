
# Applozic SDK Integration Steps:

#### STEP 1: Add Applozic binding project to your main project:

1. Add ApplozicXamarinWrapper binding project to your solution.

 Your Solution --> Add --> Add Exisitng Project
 
2. Go to your Project References and Edit references and add reference to ApplozicXamarinWrapper.

#### STEP 2: Helper class and Applozic Application Id:

Add Helper class [ALChatManager.cs](https://raw.githubusercontent.com/AppLozic/applozic-xamarin-ios-chat/master/XamarinApplozicDemo/XamarinApplozicDemo/ALChatManager.cs) in your main project. 

After adding helper class, replace *applozic-samplep-app* with your applicationId. If you haven't registered yet with Applozic, [register here](https://www.applozic.com/signup.html) for applicationId. 

```
static public String application_id = "<YOUR APPLOZIC APPLICATION ID>";
```

#### STEP 3: Login/Register User:

i) Build Applozic User:

```    
ALUser user = new ALUser();
user.ApplicationId = ALChatManager.application_id;
user.UserId = "UNIQUE_USER_ID"; //This should be unique and should not contacts
user.Password = passwordTextField.Text;
ALUserDefaultsHandler.SetPassword(user.Password);
ALUserDefaultsHandler.SetUserAuthenticationTypeId( (short)AuthenticationType.Applozic );

```

ii ) Code to register user with Applozic: 
		
```
 //Applozic user registartion code.
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
			    // registration Sucess
			}
			else
			{
				String description = error != null ? error.LocalizedDescription : response.Message;
				//new UIAlertView("Opps!!!", description, null, "OK", null).Show(); //ERROR 
        
			}
	});
```

#### STEP 4: Launch chat:

Use ALChatManager methods to launch different type of chats:

i) Chat/Conversation List:

```
	ALChatManager.launchChatList(<YOUR CONTROLLER REFERENCE>);
  
```

ii) One to One chat:

```
 ALChatManager.launchChatForUser(<USERID OF RECEIVER>, <UI CONTROLLER REFERENCE>);
 
```

iii) Launch Context based chat for user:

```
ALChatManager.launchContextBasedChat(<ALConversation-Proxy Object>, <UI CONTROLLER REFERENCE>));

```
NOTE: You can find more detail on context based chat [here](https://www.applozic.com/docs/ios-chat-sdk.html#contextual-conversation).

#### STEP 5: Push Notification Setup:

i) Add below to *FinishedLaunching(UIApplication application, NSDictionary launchOptions)* method.

```
//ASK for remote notification registartion.
ALChatManager.registerNotification();
ALAppLocalNotifications localNotification = ALAppLocalNotifications.AppLocalNotificationHandler;
localNotification.DataConnectionNotificationHandler();

if (launchOptions != null)
{

  	NSDictionary dictionary =  (Foundation.NSDictionary)launchOptions.ObjectForKey(UIApplication.LaunchOptionsRemoteNotificationKey);
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
```

ii) To send push notification-token to applozic server, add below code in *RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)*

```
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

```

iii) To handle incoming notification, add below code in *public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)*

```
public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
	{
		Console.WriteLine("RECEIVED_NOTIFICATION_WITH_COMPLETION ::{0} ", userInfo);
		ALPushNotificationService pushNotificationService = new ALPushNotificationService();
		pushNotificationService.NotificationArrivedToApplication(application, userInfo);
		completionHandler(UIBackgroundFetchResult.NewData);
	}
```

iv) Add foreground and background notificaton posting.

```
public override void DidEnterBackground(UIApplication application)
{
    NSNotificationCenter.DefaultCenter.PostNotificationName(@"APP_ENTER_IN_BACKGROUND", null);
}

public override void WillEnterForeground(UIApplication application)
{
    NSNotificationCenter.DefaultCenter.PostNotificationName(@"APP_ENTER_IN_FOREGROUND", null);
}
```

iv) Set Device APNS type used in ALChatManager.cs

```
 
 //0 - for developemnt build . 1- for distribution build
 ALUserDefaultsHandler.SetDeviceApnsType(0);
 
```
#### NOTE : Make sure you have uploaded apns certficate for application on our [dashboard](https://dashboard.applozic.com/views/applozic/page/admin/dashboard.jsp). System will pick APNS certificate according to flag set in this step.

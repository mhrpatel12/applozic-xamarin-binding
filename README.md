# applozic-xamarin-ios-chat
Applozic chat native framework xamarin binding and sample app

 **ApplozicXamarinWrapper**

This is C# binding library which should be user as reference to main project.

 **XamarinApplozicDemo**

This is Applozic samaple project using ApplozicXamarinWrapper as reference project.

# Applozic SDK Integration Steps:

####STEP 1: Add Applozic binding project to your main project:

1. Add ApplozicXamarinWrapper binding ptoject to your solution.

 Your Solution --> Add --> Add Exisitng Project
 
2. Go to your Project References and Edit references and add reference to ApplozicXamarinWrapper.

####STEP 2: Helper class and Applozic Application Id:

Add Helper class [ALChatManager.cs](https://raw.githubusercontent.com/AppLozic/applozic-xamarin-ios-chat/master/XamarinApplozicDemo/XamarinApplozicDemo/ALChatManager.cs) in your main project. 

After adding helper class, replace *applozic-samplep-app* with your applicationId. If you haven't registretd yet with Applozic, [register here](https://www.applozic.com/signup.html). 

```
 static public String application_id = "<YOUR APPLOZIC APPLICATION ID>";
```

####STEP 3: Login/Register User:

i) Build Applozic User:

```    
ALUser user = new ALUser();
user.ApplicationId = ALChatManager.application_id;
user.UserId = "UNIQUE_USER_ID"; //This should be unique and should not contacts
user.Password = passwordTextField.Text;
ALUserDefaultsHandler.SetPassword(user.Password);
ALUserDefaultsHandler.SetUserAuthenticationTypeId( (short)AuthenticationType.Applozic );

```

ii ) Use below code to register user with applozic: 
		
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

####STEP 4: Launch chat:

Use ALChatManager methods to launch ddifferent type of chats:

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
	ALChatManager.launchContextBasedChat(ALConversation, this);
```
NOTE: You can find more detail on context based chat [here](https://www.applozic.com/docs/ios-chat-sdk.html#contextual-conversation).

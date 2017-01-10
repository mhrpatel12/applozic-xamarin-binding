using System;
using ApplozicXamarinWrapper;
using UIKit;
using Foundation;

namespace XamarinApplozicDemo
{
	/**
	 * 
	 * Helper class for launching chat.
	 * 
	 * */
	public class ALChatManager
	{
		static public String application_id = "applozic-sample-app";
		public static ALChatLauncher ChatLauncher = new ALChatLauncher(application_id);

		//Right now dummy...
		public static void launchChatList(UIViewController fromViewController)
		{
			//UI Settings
			ALDefaultChatSettings();

			if (ALUserDefaultsHandler.IsLoggedIn)
			{
				ChatLauncher.LaunchChatList("<Back", fromViewController);
			}
			else
			{
				new UIAlertView("Opps!!!", "You are not logged In.", null, "OK", null).Show();

			}

		}

		//Launching chat for individual users.
		public static void launchChatForUser(String userId, UIViewController controller)
		{
			ALDefaultChatSettings();
			ChatLauncher.LaunchIndividualChat(userId, null, controller, null);
		}

		//Launching Chat for individul chennel.
		public static void launchChatForChannel(NSNumber channelId, UIViewController controller)
		{
			ALDefaultChatSettings();
			ChatLauncher.LaunchIndividualChat(null, channelId, controller, null);
		}

		public static void logout() 
		{
			new ALRegisterUserClientService().LogoutWithCompletionHandler(() => { 
               
			});
		}

		public static int GetUreadCount()
		{
			ALUserService userService = new ALUserService();
			return userService.TotalUnreadCount.Int32Value;
		}

		//launching chat with context base chat.

		public static void launchContextBasedChat(ALConversationProxy ConversationProxy, UIViewController controller)
		{
			ALDefaultChatSettings();
			ALConversationService alconversationService = new ALConversationService();

			alconversationService.CreateConversation(ConversationProxy, (Error, ConversationProxyFromServer) =>
			{
				if (Error != null)
				{
					Console.WriteLine(" Error launching Conversation ::{0}" ,Error.Description);
				}
				else
				{
					//SET Values From server...
					ConversationProxy.Id = ConversationProxyFromServer.Id;
					if (ConversationProxyFromServer.GroupId != null)
					{
						ConversationProxy.GroupId = ConversationProxyFromServer.GroupId;
					}

					ChatLauncher.LaunchIndividualContextChat(ConversationProxy, controller,null, "");

				}


			});
		}


		public void getChannelDetails()
		{
			ALChannelService channelService = new ALChannelService();
			channelService.GetChannelInformation(1564195, "1564195", (ALChannel channelObject) =>
			{
				Console.WriteLine("Launching chat directly without registration ");

			});

		}


		/**
		 *    Default custom colors and other applozic settings
		 * 
		 *    Documentaion link ...
		 **/

		public static void ALDefaultChatSettings()
		{

			/********************** Group Settings *********************************************************/

			ALApplozicSettings.SetGroupExitOption(true);
			ALApplozicSettings.SetGroupMemberRemoveOption(true);

			/*********************************************  NAVIGATION SETTINGS  ********************************************/

			ALApplozicSettings.SetStatusBarBGColor(UIColor.FromRGBA(66 / 255f, 173 / 255f, 247 / 255f, 1f));
			ALApplozicSettings.SetStatusBarStyle(UIStatusBarStyle.LightContent);
			/* BY DEFAULT Black:UIStatusBarStyleDefault IF REQ. White: UIStatusBarStyleLightContent  */
			/* ADD property in info.plist "View controller-based status bar appearance" type: BOOLEAN value: NO */

			ALApplozicSettings.SetColorForNavigation(UIColor.FromRGBA(66 / 255f, 173 / 255f, 247 / 255f, 1f));
			ALApplozicSettings.SetColorForNavigationItem(UIColor.White);
			ALApplozicSettings.HideRefreshButton(false);

			//ALApplozicSettings.Set(false);
			ALUserDefaultsHandler.SetBottomTabBarHidden(false);
			ALApplozicSettings.SetTitleForConversationScreen("Chats");
			ALApplozicSettings.SetCustomNavRightButtonMsgVC(false);                   /*  SET VISIBILITY FOR REFRESH BUTTON (COMES FROM TOP IN MSG VC)   */
			ALApplozicSettings.SetTitleForBackButtonMsgVC("Back");                /*  SET BACK BUTTON FOR MSG VC  */
																				  /****************************************************************************************************************/


			/***************************************  SEND RECEIVE MESSAGES SETTINGS  ***************************************/

			ALApplozicSettings.SetSendMsgTextColor(UIColor.White);
			ALApplozicSettings.SetReceiveMsgTextColor(UIColor.DarkGray);

			ALApplozicSettings.SetColorForReceiveMessages(UIColor.FromRGBA(255 / 255f, 255 / 255f, 255 / 255f, 1f));
			ALApplozicSettings.SetColorForSendMessages(UIColor.FromRGBA(66 / 255f, 173 / 255f, 247 / 255f, 1f));

			ALApplozicSettings.SetCustomMessageBackgroundColor(UIColor.LightGray);              /*  SET CUSTOM MESSAGE COLOR */
			ALApplozicSettings.SetCustomMessageFontSize(14);                                    /*  SET CUSTOM MESSAGE FONT SIZE */
			ALApplozicSettings.SetCustomMessageFont("Helvetica");

			//****************** DATE COLOUR : AT THE BOTTOM OF MESSAGE BUBBLE ******************/
			ALApplozicSettings.SetDateColor(UIColor.FromRGBA(51 / 255f, 51 / 255f, 51 / 255f, 1 / 2f));

			//****************** MESSAGE SEPERATE DATE COLOUR : DATE MESSAGE ******************/
			ALApplozicSettings.SetMsgDateColor(UIColor.Black);

			/***************  SEND MESSAGE ABUSE CHECK  ******************/

			ALApplozicSettings.SetAbuseWarningText("AVOID USE OF ABUSE WORDS");
			ALApplozicSettings.SetMessageAbuseMode(true);

			//****************** SHOW/HIDE RECEIVER USER PROFILE ******************/
			ALApplozicSettings.SetReceiverUserProfileOption(true);

			/**********************************************  IMAGE SETTINGS  ************************************************/

			ALApplozicSettings.SetMaxCompressionFactor(0.1f);
			ALApplozicSettings.SetMaxImageSizeForUploadInMB(3);
			ALApplozicSettings.SetMultipleAttachmentMaxLimit(5);

			/**********************************************  GROUP SETTINGS  ************************************************/

			ALApplozicSettings.SetGroupOption(true);
			ALApplozicSettings.SetGroupInfoDisabled(false);
			ALApplozicSettings.SetGroupInfoEditDisabled(false);


			ALApplozicSettings.SetGroupInfoEditDisabled(true);
			ALApplozicSettings.SetGroupMemberAddOption(true);
			ALApplozicSettings.SetGroupMemberRemoveOption(true);


			/******************************************** NOTIIFCATION SETTINGS  ********************************************/

			ALUserDefaultsHandler.SetDeviceApnsType(0);
			//For Distribution CERT::
			//[ALUserDefaultsHandler setDeviceApnsType:(short)DISTRIBUTION];

			//***//NSString* appName = [[[NSBundle mainBundle] infoDictionary] objectForKey:@"CFBundleName"];
			//****// [ALApplozicSettings setNotificationTitle:appName];

			ALApplozicSettings.EnableNotification();                   /*  IF NOTIFICATION SOUND NEEDED    */


			/********************************************* CHAT VIEW SETTINGS  **********************************************/

			ALApplozicSettings.SetVisibilityForNoMoreConversationMsgVC(false);        /*  SET VISIBILITY NO MORE CONVERSATION (COMES FROM TOP IN MSG VC)  */
			ALApplozicSettings.SetEmptyConversationText("You have no conversations yet"); /*  SET TEXT FOR EMPTY CONVERSATION    */
			ALApplozicSettings.SetVisibilityForOnlineIndicator(true);               /*  SET VISIBILITY FOR ONLINE INDICATOR */
			UIColor sendButtonColor = UIColor.FromRGBA(66 / 255f, 173 / 255f, 247 / 255f, 1f); /*  SET COLOR FOR SEND BUTTON   */
			ALApplozicSettings.SetColorForSendButton(sendButtonColor);
			ALApplozicSettings.SetColorForTypeMsgBackground(UIColor.Clear);     /*  SET COLOR FOR TYPE MESSAGE OUTER VIEW */
			ALApplozicSettings.SetMsgTextViewBGColor(UIColor.LightGray);         /*  SET BG COLOR FOR MESSAGE TEXT VIEW */
			ALApplozicSettings.SetPlaceHolderColor(UIColor.DarkGray);              /*  SET COLOR FOR PLACEHOLDER TEXT */
			ALApplozicSettings.SetVisibilityNoConversationLabelChatVC(true);            /*  SET NO CONVERSATION LABEL IN CHAT VC    */
			ALApplozicSettings.SetBGColorForTypingLabel(UIColor.FromRGBA(242 / 255f, 242 / 255f, 242 / 255f, 1f)); /*  SET COLOR FOR TYPING LABEL  */
			ALApplozicSettings.SetTextColorForTypingLabel(UIColor.FromRGBA(51 / 255f, 51 / 255f, 51 / 255f, 1 / 2f)); /*  SET COLOR FOR TEXT TYPING LABEL  */


			/********************************************** CHAT TYPE SETTINGS  *********************************************/

			ALApplozicSettings.SetContextualChat(true);
			/*  IF CONTEXTUAL NEEDED    */
			/*  Note: Please uncomment below setter to use app_module_name */
			//   [ALUserDefaultsHandler setAppModuleName:@"<APP_MODULE_NAME>"];
			//   [ALUserDefaultsHandler setAppModuleName:@"SELLER"];

			/*********************************************** CONTACT SETTINGS  **********************************************/

			ALApplozicSettings.SetFilterContactsStatus(true);                           /*  IF NEEDED ALL REGISTERED CONTACTS   */
			ALApplozicSettings.SetOnlineContactLimit(0);                               /*  IF NEEDED ONLINE USERS WITH LIMIT   */

			ALApplozicSettings.SetSubGroupLaunchFlag(false);                             /*  IF NEEDED ONLINE USERS WITH LIMIT   */
																						 /****************************************************************************************************************/


			/***************************************** TOAST + CALL OPTION SETTINGS  ****************************************/

			ALApplozicSettings.SetColorForToastText(UIColor.Black);         /*  SET COLOR FOR TOAST TEXT    */
			ALApplozicSettings.SetColorForToastBackground(UIColor.Gray);    /*  SET COLOR FOR TOAST BG      */
			ALApplozicSettings.SetCallOption(false);                                 /*  IF CALL OPTION NEEDED   */
																					 /****************************************************************************************************************/

			/********************************************* DEMAND/MISC SETTINGS  ********************************************/

			ALApplozicSettings.SetUnreadCountLabelBGColor(UIColor.DarkGray);
			ALUserDefaultsHandler.SetFetchConversationPageSize(20);                    /*  SET MESSAGE LIST PAGE SIZE  */ // DEFAULT VALUE 20
			ALUserDefaultsHandler.SetUnreadCountType(1);                               /*  SET UNRAED COUNT TYPE   */ // DEFAULT VALUE 0
			ALApplozicSettings.SetMaxTextViewLines(4);
			ALUserDefaultsHandler.SetDebugLogsRequire(true);                            /*   ENABLE / DISABLE LOGS   */
			ALUserDefaultsHandler.SetLoginUserConatactVisibility(false);
			ALApplozicSettings.SetUserProfileHidden(false);
			ALApplozicSettings.SetFontFace("Helvetica");
			//ALApplozicSettings.SetChatWallpaperImageName:@"<WALLPAPER NAME>"];

			/***************************************** APPLICATION URL CONFIGURATION + ENCRYPTION  ***************************************/

			//    [self getApplicationBaseURL];                                         /* Note: PLEASE DO NOT COMMENT THIS IF ARCHIVING/RELEASING  */

			ALUserDefaultsHandler.SetEnableEncryption(false);                            /* Note: PLEASE DO YES (IF NEEDED)  */

			/*********************************************GOOLE API SETTINGS*******************************************************************/
			ALUserDefaultsHandler.SetGoogleMapAPIKey("AIzaSyBnWMTGs1uTFuf8fqQtsmLk-vsWM7OrIXk"); //REPLACE WITH YOUR GOOGLE MAPKEY

		}

		//APNS registartion...
		public static void registerNotification()
		{

			if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
			{
				var pushSettings = UIUserNotificationSettings.GetSettingsForTypes(
								   UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound,
								   new NSSet());

				UIApplication.SharedApplication.RegisterUserNotificationSettings(pushSettings);
				UIApplication.SharedApplication.RegisterForRemoteNotifications();
			}
			else {
				UIRemoteNotificationType notificationTypes = UIRemoteNotificationType.Alert | UIRemoteNotificationType.Badge | UIRemoteNotificationType.Sound;
				UIApplication.SharedApplication.RegisterForRemoteNotificationTypes(notificationTypes);
			}
		}

	}
}

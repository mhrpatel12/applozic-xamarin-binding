using System;
using ApplozicXamarinWrapper;
using CoreData;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace ApplozicXamarinWrapper
{
	
	// @interface ALJson : NSObject
[BaseType (typeof(NSObject))]
	interface ALJson
	{
		// -(instancetype)initWithJSONString:(NSString *)JSONString;
		[Export("initWithJSONString:")]
		IntPtr Constructor(string JSONString);

		// -(NSDictionary *)dictionary;
		[Export("dictionary")]
		//[Verify(MethodToProperty)]
		NSDictionary Dictionary { get; }

		// -(NSString *)getStringFromJsonValue:(id)jsonValue;
		[Export("getStringFromJsonValue:")]
		string GetStringFromJsonValue(NSObject jsonValue);

		// -(BOOL)getBoolFromJsonValue:(id)jsonValue;
		[Export("getBoolFromJsonValue:")]
		bool GetBoolFromJsonValue(NSObject jsonValue);

		// -(BOOL)validateJsonClass:(NSDictionary *)jsonClass;
		[Export("validateJsonClass:")]
		bool ValidateJsonClass(NSDictionary jsonClass);

		// -(BOOL)validateJsonArrayClass:(NSArray *)jsonClass;
		[Export("validateJsonArrayClass:")]
		//[Verify(StronglyTypedNSArray)]
		bool ValidateJsonArrayClass(NSObject[] jsonClass);

		// -(short)getShortFromJsonValue:(id)jsonValue;
		[Export("getShortFromJsonValue:")]
		short GetShortFromJsonValue(NSObject jsonValue);

		// -(NSNumber *)getNSNumberFromJsonValue:(id)jsonValue;
		[Export("getNSNumberFromJsonValue:")]
		NSNumber GetNSNumberFromJsonValue(NSObject jsonValue);

		// -(int)getIntFromJsonValue:(id)jsonValue;
		[Export("getIntFromJsonValue:")]
		int GetIntFromJsonValue(NSObject jsonValue);

		// -(long)getLongFromJsonValue:(id)jsonValue;
		[Export("getLongFromJsonValue:")]
		nint GetLongFromJsonValue(NSObject jsonValue);
	}

	// @interface ALAPIResponse : ALJson
	[BaseType(typeof(ALJson))]
	interface ALAPIResponse
	{
		// @property (nonatomic, strong) NSString * status;
		[Export("status", ArgumentSemantic.Strong)]
		string Status { get; set; }

		// @property (nonatomic, strong) NSNumber * generatedAt;
		[Export("generatedAt", ArgumentSemantic.Strong)]
		NSNumber GeneratedAt { get; set; }

		// @property (nonatomic, strong) id response;
		[Export("response", ArgumentSemantic.Strong)]
		NSObject Response { get; set; }
	}

	// @interface ALTopicDetail : ALJson
	[BaseType(typeof(ALJson))]
	interface ALTopicDetail
	{
		// @property (nonatomic, strong) NSString * title;
		[Export("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * subtitle;
		[Export("subtitle", ArgumentSemantic.Strong)]
		string Subtitle { get; set; }

		// @property (nonatomic, strong) NSString * pId;
		[Export("pId", ArgumentSemantic.Strong)]
		string PId { get; set; }

		// @property (nonatomic, strong) NSString * link;
		[Export("link", ArgumentSemantic.Strong)]
		string Link { get; set; }

		// @property (nonatomic, strong) NSString * key1;
		[Export("key1", ArgumentSemantic.Strong)]
		string Key1 { get; set; }

		// @property (nonatomic, strong) NSString * value1;
		[Export("value1", ArgumentSemantic.Strong)]
		string Value1 { get; set; }

		// @property (nonatomic, strong) NSString * key2;
		[Export("key2", ArgumentSemantic.Strong)]
		string Key2 { get; set; }

		// @property (nonatomic, strong) NSString * value2;
		[Export("value2", ArgumentSemantic.Strong)]
		string Value2 { get; set; }

		// @property (nonatomic, strong) NSString * topicId;
		[Export("topicId", ArgumentSemantic.Strong)]
		string TopicId { get; set; }

		// @property (nonatomic, strong) NSMutableArray * fallBackTemplateList;
		[Export("fallBackTemplateList", ArgumentSemantic.Strong)]
		NSMutableArray FallBackTemplateList { get; set; }

		// -(id)initWithDictonary:(NSDictionary *)detailJson;
		[Export("initWithDictonary:")]
		IntPtr Constructor(NSDictionary detailJson);

		// -(void)parseMessage:(id)detailJson;
		[Export("parseMessage:")]
		void ParseMessage(NSObject detailJson);
	}

	// @interface ALConversationProxy : ALJson
	[BaseType(typeof(ALJson))]
	interface ALConversationProxy
	{
		// @property (nonatomic, strong) NSNumber * Id;
		[Export("Id", ArgumentSemantic.Strong)]
		NSNumber Id { get; set; }

		// @property (nonatomic, strong) NSString * topicId;
		[Export("topicId", ArgumentSemantic.Strong)]
		string TopicId { get; set; }

		// @property (nonatomic, strong) NSString * topicDetailJson;
		[Export("topicDetailJson", ArgumentSemantic.Strong)]
		string TopicDetailJson { get; set; }

		// @property (nonatomic, strong) NSNumber * groupId;
		[Export("groupId", ArgumentSemantic.Strong)]
		NSNumber GroupId { get; set; }

		// @property (nonatomic, strong) NSString * userId;
		[Export("userId", ArgumentSemantic.Strong)]
		string UserId { get; set; }

		// @property (nonatomic, strong) NSArray * supportIds;
		[Export("supportIds", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] SupportIds { get; set; }

		// @property (nonatomic, strong) NSMutableArray * fallBackTemplatesListArray;
		[Export("fallBackTemplatesListArray", ArgumentSemantic.Strong)]
		NSMutableArray FallBackTemplatesListArray { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * fallBackTemplateForSENDER;
		[Export("fallBackTemplateForSENDER", ArgumentSemantic.Strong)]
		NSMutableDictionary FallBackTemplateForSENDER { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * fallBackTemplateForRECEIVER;
		[Export("fallBackTemplateForRECEIVER", ArgumentSemantic.Strong)]
		NSMutableDictionary FallBackTemplateForRECEIVER { get; set; }

		// @property (nonatomic) BOOL created;
		[Export("created")]
		bool Created { get; set; }

		// @property (nonatomic) BOOL closed;
		[Export("closed")]
		bool Closed { get; set; }

		// -(void)parseMessage:(id)messageJson;
		[Export("parseMessage:")]
		void ParseMessage(NSObject messageJson);

		// -(id)initWithDictonary:(NSDictionary *)messageDictonary;
		[Export("initWithDictonary:")]
		IntPtr Constructor(NSDictionary messageDictonary);

		// -(ALTopicDetail *)getTopicDetail;
		[Export("getTopicDetail")]
		//[Verify(MethodToProperty)]
		ALTopicDetail TopicDetail { get; }

		// +(NSMutableDictionary *)getDictionaryForCreate:(ALConversationProxy *)alConversationProxy;
		[Static]
		[Export("getDictionaryForCreate:")]
		NSMutableDictionary GetDictionaryForCreate(ALConversationProxy alConversationProxy);

		// -(void)setSenderSMSFormat:(NSString *)senderFormatString;
		[Export("setSenderSMSFormat:")]
		void SetSenderSMSFormat(string senderFormatString);

		// -(void)setReceiverSMSFormat:(NSString *)recieverFormatString;
		[Export("setReceiverSMSFormat:")]
		void SetReceiverSMSFormat(string recieverFormatString);
	}

	// @interface ALFileMetaInfo : ALJson
	[BaseType(typeof(ALJson))]
	interface ALFileMetaInfo
	{
		// @property (copy, nonatomic) NSString * key;
		[Export("key")]
		string Key { get; set; }

		// @property (copy, nonatomic) NSString * userKey;
		[Export("userKey")]
		string UserKey { get; set; }

		// @property (copy, nonatomic) NSString * blobKey;
		[Export("blobKey")]
		string BlobKey { get; set; }

		// @property (copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * url;
		[Export("url")]
		string Url { get; set; }

		// @property (copy, nonatomic) NSString * size;
		[Export("size")]
		string Size { get; set; }

		// @property (copy, nonatomic) NSString * contentType;
		[Export("contentType")]
		string ContentType { get; set; }

		// @property (copy, nonatomic) NSString * thumbnailUrl;
		[Export("thumbnailUrl")]
		string ThumbnailUrl { get; set; }

		// @property (copy, nonatomic) NSNumber * createdAtTime;
		[Export("createdAtTime", ArgumentSemantic.Copy)]
		NSNumber CreatedAtTime { get; set; }

		// @property (assign, nonatomic) CGFloat progressValue;
		[Export("progressValue")]
		nfloat ProgressValue { get; set; }

		// -(NSString *)getTheSize;
		[Export("getTheSize")]
		//[Verify(MethodToProperty)]
		string TheSize { get; }

		// -(ALFileMetaInfo *)populate:(NSDictionary *)dict;
		[Export("populate:")]
		ALFileMetaInfo Populate(NSDictionary dict);
	}

	// @interface ALMessage : ALJson
	[BaseType(typeof(ALJson))]
	interface ALMessage
	{
		// @property (copy, nonatomic) NSString * key;
		[Export("key")]
		string Key { get; set; }

		// @property (copy, nonatomic) NSString * deviceKey;
		[Export("deviceKey")]
		string DeviceKey { get; set; }

		// @property (copy, nonatomic) NSString * userKey;
		[Export("userKey")]
		string UserKey { get; set; }

		// @property (copy, nonatomic) NSString * to;
		[Export("to")]
		string To { get; set; }

		// @property (copy, nonatomic) NSString * message;
		[Export("message")]
		string Message { get; set; }

		// @property (assign, nonatomic) BOOL sendToDevice;
		[Export("sendToDevice")]
		bool SendToDevice { get; set; }

		// @property (assign, nonatomic) BOOL shared;
		[Export("shared")]
		bool Shared { get; set; }

		// @property (copy, nonatomic) NSNumber * createdAtTime;
		[Export("createdAtTime", ArgumentSemantic.Copy)]
		NSNumber CreatedAtTime { get; set; }

		// @property (copy, nonatomic) NSString * type;
		[Export("type")]
		string Type { get; set; }

		// @property (nonatomic) short source;
		[Export("source")]
		short Source { get; set; }

		// @property (copy, nonatomic) NSString * contactIds;
		[Export("contactIds")]
		string ContactIds { get; set; }

		// @property (assign, nonatomic) BOOL storeOnDevice;
		[Export("storeOnDevice")]
		bool StoreOnDevice { get; set; }

		// @property (retain, nonatomic) ALFileMetaInfo * fileMeta;
		[Export("fileMeta", ArgumentSemantic.Retain)]
		ALFileMetaInfo FileMeta { get; set; }

		// @property (retain, nonatomic) NSString * imageFilePath;
		[Export("imageFilePath", ArgumentSemantic.Retain)]
		string ImageFilePath { get; set; }

		// @property (assign, nonatomic) BOOL inProgress;
		[Export("inProgress")]
		bool InProgress { get; set; }

		// @property (nonatomic, strong) NSString * fileMetaKey;
		[Export("fileMetaKey", ArgumentSemantic.Strong)]
		string FileMetaKey { get; set; }

		// @property (assign, nonatomic) BOOL isUploadFailed;
		[Export("isUploadFailed")]
		bool IsUploadFailed { get; set; }

		// @property (assign, nonatomic) BOOL delivered;
		[Export("delivered")]
		bool Delivered { get; set; }

		// @property (assign, nonatomic) BOOL sentToServer;
		[Export("sentToServer")]
		bool SentToServer { get; set; }

		// @property (copy, nonatomic) NSManagedObjectID * msgDBObjectId;
		[Export("msgDBObjectId", ArgumentSemantic.Copy)]
		NSManagedObjectID MsgDBObjectId { get; set; }

		// @property (copy, nonatomic) NSString * pairedMessageKey;
		[Export("pairedMessageKey")]
		string PairedMessageKey { get; set; }

		// @property (assign, nonatomic) long messageId;
		[Export("messageId")]
		nint MessageId { get; set; }

		// @property (retain, nonatomic) NSString * applicationId;
		[Export("applicationId", ArgumentSemantic.Retain)]
		string ApplicationId { get; set; }

		// @property (nonatomic) short contentType;
		[Export("contentType")]
		short ContentType { get; set; }

		// @property (copy, nonatomic) NSNumber * groupId;
		[Export("groupId", ArgumentSemantic.Copy)]
		NSNumber GroupId { get; set; }

		// @property (copy, nonatomic) NSNumber * conversationId;
		[Export("conversationId", ArgumentSemantic.Copy)]
		NSNumber ConversationId { get; set; }

		// @property (copy, nonatomic) NSNumber * status;
		[Export("status", ArgumentSemantic.Copy)]
		NSNumber Status { get; set; }

		// @property (retain, nonatomic) NSMutableDictionary * metadata;
		[Export("metadata", ArgumentSemantic.Retain)]
		NSMutableDictionary Metadata { get; set; }

		// -(NSString *)getCreatedAtTime:(BOOL)today;
		[Export("getCreatedAtTime:")]
		string GetCreatedAtTime(bool today);

		// -(id)initWithDictonary:(NSDictionary *)messageDictonary;
		[Export("initWithDictonary:")]
		IntPtr Constructor(NSDictionary messageDictonary);

		// -(BOOL)isDownloadRequire;
		[Export("isDownloadRequire")]
		//[Verify(MethodToProperty)]
		bool IsDownloadRequire { get; }

		// -(BOOL)isUploadRequire;
		[Export("isUploadRequire")]
		//[Verify(MethodToProperty)]
		bool IsUploadRequire { get; }

		// -(BOOL)isHiddenMessage;
		[Export("isHiddenMessage")]
		//[Verify(MethodToProperty)]
		bool IsHiddenMessage { get; }

		// -(NSString *)getCreatedAtTimeChat:(BOOL)today;
		[Export("getCreatedAtTimeChat:")]
		string GetCreatedAtTimeChat(bool today);

		// -(NSNumber *)getGroupId;
		//[Export("getGroupId")]
		//[Verify(MethodToProperty)]
		//NSNumber GroupId { get; }

		// -(NSString *)getNotificationText;
		[Export("getNotificationText")]
		//[Verify(MethodToProperty)]
		string NotificationText { get; }

		// -(NSMutableDictionary *)getMetaDataDictionary:(NSString *)string;
		[Export("getMetaDataDictionary:")]
		NSMutableDictionary GetMetaDataDictionary(string @string);

		// @property (assign, nonatomic) BOOL deleted;
		[Export("deleted")]
		bool Deleted { get; set; }
	}

	// @protocol ALChatLauncherDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface ALChatLauncherDelegate
	{
		// @required +(void)handleCustomAction:(UIViewController *)chatView andWithMessage:(ALMessage *)alMessage;
		[Static]
		[Export("handleCustomAction:andWithMessage:")]
		void AndWithMessage(UIViewController chatView, ALMessage alMessage);
	}

	// @interface ALChatLauncher : NSObject
	[BaseType(typeof(NSObject))]
	interface ALChatLauncher
	{
		[Wrap("WeakChatLauncherDelegate")]
		ALChatLauncherDelegate ChatLauncherDelegate { get; set; }

		// @property (nonatomic, strong) id<ALChatLauncherDelegate> chatLauncherDelegate;
		[NullAllowed, Export("chatLauncherDelegate", ArgumentSemantic.Strong)]
		NSObject WeakChatLauncherDelegate { get; set; }

		// @property (assign, nonatomic) NSString * applicationId;
		[Export("applicationId")]
		string ApplicationId { get; set; }

		// @property (nonatomic, strong) NSNumber * chatLauncherFLAG;
		[Export("chatLauncherFLAG", ArgumentSemantic.Strong)]
		NSNumber ChatLauncherFLAG { get; set; }

		// -(instancetype)initWithApplicationId:(NSString *)applicationId;
		[Export("initWithApplicationId:")]
		IntPtr Constructor(string applicationId);

		// -(void)launchIndividualChat:(NSString *)userId withGroupId:(NSNumber *)groupID andViewControllerObject:(UIViewController *)viewController andWithText:(NSString *)text;
		[Export("launchIndividualChat:withGroupId:andViewControllerObject:andWithText:")]
		void LaunchIndividualChat([NullAllowed] string userId, [NullAllowed] NSNumber groupID, UIViewController viewController, [NullAllowed] string text);

		// -(void)launchChatList:(NSString *)title andViewControllerObject:(UIViewController *)viewController;
		[Export("launchChatList:andViewControllerObject:")]
		void LaunchChatList(string title, UIViewController viewController);

		// -(void)launchContactList:(UIViewController *)uiViewController;
		[Export("launchContactList:")]
		void LaunchContactList(UIViewController uiViewController);

		// -(void)registerForNotification;
		[Export("registerForNotification")]
		void RegisterForNotification();

		// -(void)launchIndividualChat:(NSString *)userId withGroupId:(NSNumber *)groupID withDisplayName:(NSString *)displayName andViewControllerObject:(UIViewController *)viewController andWithText:(NSString *)text;
		[Export("launchIndividualChat:withGroupId:withDisplayName:andViewControllerObject:andWithText:")]
		void LaunchIndividualChat([NullAllowed] string userId, [NullAllowed] NSNumber groupID, [NullAllowed] string displayName, UIViewController viewController, string text);

		// -(void)launchIndividualContextChat:(ALConversationProxy *)alConversationProxy andViewControllerObject:(UIViewController *)viewController userDisplayName:(NSString *)displayName andWithText:(NSString *)text;
		[Export("launchIndividualContextChat:andViewControllerObject:userDisplayName:andWithText:")]
		void LaunchIndividualContextChat(ALConversationProxy alConversationProxy, UIViewController viewController, [NullAllowed] string displayName, [NullAllowed] string text);

		// -(void)launchChatListWithUserOrGroup:(NSString *)userId withChannel:(NSNumber *)channelKey andViewControllerObject:(UIViewController *)viewController;
		[Export("launchChatListWithUserOrGroup:withChannel:andViewControllerObject:")]
		void LaunchChatListWithUserOrGroup([NullAllowed] string userId, [NullAllowed] NSNumber channelKey, UIViewController viewController);

		// -(void)launchChatListWithCustomNavigationBar:(UIViewController *)viewController;
		[Export("launchChatListWithCustomNavigationBar:")]
		void LaunchChatListWithCustomNavigationBar(UIViewController viewController);

		// -(void)launchChatListWithParentKey:(NSNumber *)parentKey andViewControllerObject:(UIViewController *)viewController;
		[Export("launchChatListWithParentKey:andViewControllerObject:")]
		void LaunchChatListWithParentKey(NSNumber parentKey, UIViewController viewController);

		// -(void)launchContactScreenWithMessage:(ALMessage *)alMessage andFromViewController:(UIViewController *)viewController;
		[Export("launchContactScreenWithMessage:andFromViewController:")]
		void LaunchContactScreenWithMessage(ALMessage alMessage, UIViewController viewController);
	}

	// @interface ALAppLocalNotifications : NSObject
	[BaseType(typeof(NSObject))]
	interface ALAppLocalNotifications
	{
		// +(ALAppLocalNotifications *)appLocalNotificationHandler;
		[Static]
		[Export("appLocalNotificationHandler")]
		//[Verify(MethodToProperty)]
		ALAppLocalNotifications AppLocalNotificationHandler { get; }

		// -(void)dataConnectionNotificationHandler;
		[Export("dataConnectionNotificationHandler")]
		void DataConnectionNotificationHandler();

		// -(void)reachabilityChanged:(NSNotification *)note;
		[Export("reachabilityChanged:")]
		void ReachabilityChanged(NSNotification note);

		// @property (nonatomic, strong) ALChatLauncher * chatLauncher;
		[Export("chatLauncher", ArgumentSemantic.Strong)]
		ALChatLauncher ChatLauncher { get; set; }

		// @property (nonatomic) BOOL flag;
		[Export("flag")]
		bool Flag { get; set; }

		// @property (nonatomic, strong) NSDictionary * dict;
		[Export("dict", ArgumentSemantic.Strong)]
		NSDictionary Dict { get; set; }

		// @property (nonatomic, strong) NSString * contactId;
		[Export("contactId", ArgumentSemantic.Strong)]
		string ContactId { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * dict2;
		[Export("dict2", ArgumentSemantic.Strong)]
		NSMutableDictionary Dict2 { get; set; }

		// -(void)thirdPartyNotificationTap1:(NSString *)contactId withGroupId:(NSNumber *)groupID;
		[Export("thirdPartyNotificationTap1:withGroupId:")]
		void ThirdPartyNotificationTap1(string contactId, NSNumber groupID);

		// -(void)proactivelyConnectMQTT;
		[Export("proactivelyConnectMQTT")]
		void ProactivelyConnectMQTT();

		// -(void)proactivelyDisconnectMQTT;
		[Export("proactivelyDisconnectMQTT")]
		void ProactivelyDisconnectMQTT();
	}

	// @interface ALApplozicSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface ALApplozicSettings
	{
		// +(void)setFontFace:(NSString *)fontFace;
		[Static]
		[Export("setFontFace:")]
		void SetFontFace(string fontFace);

		// +(NSString *)getFontFace;
		[Static]
		[Export("getFontFace")]
		//[Verify(MethodToProperty)]
		string FontFace { get; }

		// +(void)setUserProfileHidden:(BOOL)flag;
		[Static]
		[Export("setUserProfileHidden:")]
		void SetUserProfileHidden(bool flag);

		// +(BOOL)isUserProfileHidden;
		[Static]
		[Export("isUserProfileHidden")]
		//[Verify(MethodToProperty)]
		bool IsUserProfileHidden { get; }

		// +(void)setColorForSendMessages:(UIColor *)sendMsgColor;
		[Static]
		[Export("setColorForSendMessages:")]
		void SetColorForSendMessages(UIColor sendMsgColor);

		// +(void)setColorForReceiveMessages:(UIColor *)receiveMsgColor;
		[Static]
		[Export("setColorForReceiveMessages:")]
		void SetColorForReceiveMessages(UIColor receiveMsgColor);

		// +(UIColor *)getSendMsgColor;
		[Static]
		[Export("getSendMsgColor")]
		//[Verify(MethodToProperty)]
		UIColor SendMsgColor { get; }

		// +(UIColor *)getReceiveMsgColor;
		[Static]
		[Export("getReceiveMsgColor")]
		//[Verify(MethodToProperty)]
		UIColor ReceiveMsgColor { get; }

		// +(void)setColorForNavigation:(UIColor *)barColor;
		[Static]
		[Export("setColorForNavigation:")]
		void SetColorForNavigation(UIColor barColor);

		// +(UIColor *)getColorForNavigation;
		[Static]
		[Export("getColorForNavigation")]
		//[Verify(MethodToProperty)]
		UIColor ColorForNavigation { get; }

		// +(void)setColorForNavigationItem:(UIColor *)barItemColor;
		[Static]
		[Export("setColorForNavigationItem:")]
		void SetColorForNavigationItem(UIColor barItemColor);

		// +(UIColor *)getColorForNavigationItem;
		[Static]
		[Export("getColorForNavigationItem")]
		//[Verify(MethodToProperty)]
		UIColor ColorForNavigationItem { get; }

		// +(void)hideRefreshButton:(BOOL)state;
		[Static]
		[Export("hideRefreshButton:")]
		void HideRefreshButton(bool state);

		// +(BOOL)isRefreshButtonHidden;
		[Static]
		[Export("isRefreshButtonHidden")]
		//[Verify(MethodToProperty)]
		bool IsRefreshButtonHidden { get; }

		// +(void)setTitleForConversationScreen:(NSString *)titleText;
		[Static]
		[Export("setTitleForConversationScreen:")]
		void SetTitleForConversationScreen(string titleText);

		// +(NSString *)getTitleForConversationScreen;
		[Static]
		[Export("getTitleForConversationScreen")]
		//[Verify(MethodToProperty)]
		string TitleForConversationScreen { get; }

		// +(void)setTitleForBackButtonMsgVC:(NSString *)backButtonTitle;
		[Static]
		[Export("setTitleForBackButtonMsgVC:")]
		void SetTitleForBackButtonMsgVC(string backButtonTitle);

		// +(NSString *)getTitleForBackButtonMsgVC;
		[Static]
		[Export("getTitleForBackButtonMsgVC")]
		//[Verify(MethodToProperty)]
		string TitleForBackButtonMsgVC { get; }

		// +(NSString *)getTitleForBackButtonChatVC;
		[Static]
		[Export("getTitleForBackButtonChatVC")]
		//[Verify(MethodToProperty)]
		string TitleForBackButtonChatVC { get; }

		// +(void)setTitleForBackButtonChatVC:(NSString *)backButtonTitle;
		[Static]
		[Export("setTitleForBackButtonChatVC:")]
		void SetTitleForBackButtonChatVC(string backButtonTitle);

		// +(void)setNotificationTitle:(NSString *)notificationTitle;
		[Static]
		[Export("setNotificationTitle:")]
		void SetNotificationTitle(string notificationTitle);

		// +(NSString *)getNotificationTitle;
		[Static]
		[Export("getNotificationTitle")]
		//[Verify(MethodToProperty)]
		string NotificationTitle { get; }

		// +(void)setMaxImageSizeForUploadInMB:(NSInteger)maxFileSize;
		[Static]
		[Export("setMaxImageSizeForUploadInMB:")]
		void SetMaxImageSizeForUploadInMB(nint maxFileSize);

		// +(NSInteger)getMaxImageSizeForUploadInMB;
		[Static]
		[Export("getMaxImageSizeForUploadInMB")]
		//[Verify(MethodToProperty)]
		nint MaxImageSizeForUploadInMB { get; }

		// +(void)setMaxCompressionFactor:(double)maxCompressionRatio;
		[Static]
		[Export("setMaxCompressionFactor:")]
		void SetMaxCompressionFactor(double maxCompressionRatio);

		// +(double)getMaxCompressionFactor;
		[Static]
		[Export("getMaxCompressionFactor")]
		//[Verify(MethodToProperty)]
		double MaxCompressionFactor { get; }

		// +(void)setGroupOption:(BOOL)option;
		[Static]
		[Export("setGroupOption:")]
		void SetGroupOption(bool option);

		// +(BOOL)getGroupOption;
		[Static]
		[Export("getGroupOption")]
		//[Verify(MethodToProperty)]
		bool GroupOption { get; }

		// +(void)setMultipleAttachmentMaxLimit:(NSInteger)limit;
		[Static]
		[Export("setMultipleAttachmentMaxLimit:")]
		void SetMultipleAttachmentMaxLimit(nint limit);

		// +(NSInteger)getMultipleAttachmentMaxLimit;
		[Static]
		[Export("getMultipleAttachmentMaxLimit")]
		//[Verify(MethodToProperty)]
		nint MultipleAttachmentMaxLimit { get; }

		// +(void)setFilterContactsStatus:(BOOL)flag;
		[Static]
		[Export("setFilterContactsStatus:")]
		void SetFilterContactsStatus(bool flag);

		// +(BOOL)getFilterContactsStatus;
		[Static]
		[Export("getFilterContactsStatus")]
		//[Verify(MethodToProperty)]
		bool FilterContactsStatus { get; }

		// +(void)setStartTime:(NSNumber *)startTime;
		[Static]
		[Export("setStartTime:")]
		void SetStartTime(NSNumber startTime);

		// +(NSNumber *)getStartTime;
		[Static]
		[Export("getStartTime")]
		//[Verify(MethodToProperty)]
		NSNumber StartTime { get; }

		// +(void)setChatWallpaperImageName:(NSString *)imageName;
		[Static]
		[Export("setChatWallpaperImageName:")]
		void SetChatWallpaperImageName(string imageName);

		// +(NSString *)getChatWallpaperImageName;
		[Static]
		[Export("getChatWallpaperImageName")]
		//[Verify(MethodToProperty)]
		string ChatWallpaperImageName { get; }

		// +(void)setCustomMessageBackgroundColor:(UIColor *)color;
		[Static]
		[Export("setCustomMessageBackgroundColor:")]
		void SetCustomMessageBackgroundColor(UIColor color);

		// +(UIColor *)getCustomMessageBackgroundColor;
		[Static]
		[Export("getCustomMessageBackgroundColor")]
		//[Verify(MethodToProperty)]
		UIColor CustomMessageBackgroundColor { get; }

		// +(void)setGroupExitOption:(BOOL)option;
		[Static]
		[Export("setGroupExitOption:")]
		void SetGroupExitOption(bool option);

		// +(BOOL)getGroupExitOption;
		[Static]
		[Export("getGroupExitOption")]
		//[Verify(MethodToProperty)]
		bool GroupExitOption { get; }

		// +(void)setGroupMemberAddOption:(BOOL)option;
		[Static]
		[Export("setGroupMemberAddOption:")]
		void SetGroupMemberAddOption(bool option);

		// +(BOOL)getGroupMemberAddOption;
		[Static]
		[Export("getGroupMemberAddOption")]
		//[Verify(MethodToProperty)]
		bool GroupMemberAddOption { get; }

		// +(void)setGroupMemberRemoveOption:(BOOL)option;
		[Static]
		[Export("setGroupMemberRemoveOption:")]
		void SetGroupMemberRemoveOption(bool option);

		// +(BOOL)getGroupMemberRemoveOption;
		[Static]
		[Export("getGroupMemberRemoveOption")]
		//[Verify(MethodToProperty)]
		bool GroupMemberRemoveOption { get; }

		// +(void)setOnlineContactLimit:(NSInteger)limit;
		[Static]
		[Export("setOnlineContactLimit:")]
		void SetOnlineContactLimit(nint limit);

		// +(NSInteger)getOnlineContactLimit;
		[Static]
		[Export("getOnlineContactLimit")]
		//[Verify(MethodToProperty)]
		nint OnlineContactLimit { get; }

		// +(NSString *)getCustomClassName;
		[Static]
		[Export("getCustomClassName")]
		//[Verify(MethodToProperty)]
		string CustomClassName { get; }

		// +(void)setCustomClassName:(NSString *)className;
		[Static]
		[Export("setCustomClassName:")]
		void SetCustomClassName(string className);

		// +(void)setContextualChat:(BOOL)option;
		[Static]
		[Export("setContextualChat:")]
		void SetContextualChat(bool option);

		// +(BOOL)getContextualChatOption;
		[Static]
		[Export("getContextualChatOption")]
		//[Verify(MethodToProperty)]
		bool ContextualChatOption { get; }

		// +(void)setCallOption:(BOOL)flag;
		[Static]
		[Export("setCallOption:")]
		void SetCallOption(bool flag);

		// +(BOOL)getCallOption;
		[Static]
		[Export("getCallOption")]
		//[Verify(MethodToProperty)]
		bool CallOption { get; }

		// +(void)enableNotificationSound;
		[Static]
		[Export("enableNotificationSound")]
		void EnableNotificationSound();

		// +(void)disableNotificationSound;
		[Static]
		[Export("disableNotificationSound")]
		void DisableNotificationSound();

		// +(void)enableNotification;
		[Static]
		[Export("enableNotification")]
		void EnableNotification();

		// +(void)disableNotification;
		[Static]
		[Export("disableNotification")]
		void DisableNotification();

		// +(UIColor *)getColorForSendButton;
		[Static]
		[Export("getColorForSendButton")]
		//[Verify(MethodToProperty)]
		UIColor ColorForSendButton { get; }

		// +(void)setColorForSendButton:(UIColor *)color;
		[Static]
		[Export("setColorForSendButton:")]
		void SetColorForSendButton(UIColor color);

		// +(UIColor *)getColorForTypeMsgBackground;
		[Static]
		[Export("getColorForTypeMsgBackground")]
		//[Verify(MethodToProperty)]
		UIColor ColorForTypeMsgBackground { get; }

		// +(void)setColorForTypeMsgBackground:(UIColor *)viewColor;
		[Static]
		[Export("setColorForTypeMsgBackground:")]
		void SetColorForTypeMsgBackground(UIColor viewColor);

		// +(UIColor *)getBGColorForTypingLabel;
		[Static]
		[Export("getBGColorForTypingLabel")]
		//[Verify(MethodToProperty)]
		UIColor BGColorForTypingLabel { get; }

		// +(void)setBGColorForTypingLabel:(UIColor *)bgColor;
		[Static]
		[Export("setBGColorForTypingLabel:")]
		void SetBGColorForTypingLabel(UIColor bgColor);

		// +(UIColor *)getTextColorForTypingLabel;
		[Static]
		[Export("getTextColorForTypingLabel")]
		//[Verify(MethodToProperty)]
		UIColor TextColorForTypingLabel { get; }

		// +(void)setTextColorForTypingLabel:(UIColor *)txtColor;
		[Static]
		[Export("setTextColorForTypingLabel:")]
		void SetTextColorForTypingLabel(UIColor txtColor);

		// +(NSString *)getEmptyConversationText;
		[Static]
		[Export("getEmptyConversationText")]
		//[Verify(MethodToProperty)]
		string EmptyConversationText { get; }

		// +(void)setEmptyConversationText:(NSString *)text;
		[Static]
		[Export("setEmptyConversationText:")]
		void SetEmptyConversationText(string text);

		// +(BOOL)getVisibilityNoConversationLabelChatVC;
		[Static]
		[Export("getVisibilityNoConversationLabelChatVC")]
		//[Verify(MethodToProperty)]
		bool VisibilityNoConversationLabelChatVC { get; }

		// +(void)setVisibilityNoConversationLabelChatVC:(BOOL)flag;
		[Static]
		[Export("setVisibilityNoConversationLabelChatVC:")]
		void SetVisibilityNoConversationLabelChatVC(bool flag);

		// +(BOOL)getVisibilityForOnlineIndicator;
		[Static]
		[Export("getVisibilityForOnlineIndicator")]
		//[Verify(MethodToProperty)]
		bool VisibilityForOnlineIndicator { get; }

		// +(void)setVisibilityForOnlineIndicator:(BOOL)flag;
		[Static]
		[Export("setVisibilityForOnlineIndicator:")]
		void SetVisibilityForOnlineIndicator(bool flag);

		// +(BOOL)getVisibilityForNoMoreConversationMsgVC;
		[Static]
		[Export("getVisibilityForNoMoreConversationMsgVC")]
		//[Verify(MethodToProperty)]
		bool VisibilityForNoMoreConversationMsgVC { get; }

		// +(void)setVisibilityForNoMoreConversationMsgVC:(BOOL)flag;
		[Static]
		[Export("setVisibilityForNoMoreConversationMsgVC:")]
		void SetVisibilityForNoMoreConversationMsgVC(bool flag);

		// +(BOOL)getCustomNavRightButtonMsgVC;
		[Static]
		[Export("getCustomNavRightButtonMsgVC")]
		//[Verify(MethodToProperty)]
		bool CustomNavRightButtonMsgVC { get; }

		// +(void)setCustomNavRightButtonMsgVC:(BOOL)flag;
		[Static]
		[Export("setCustomNavRightButtonMsgVC:")]
		void SetCustomNavRightButtonMsgVC(bool flag);

		// +(UIColor *)getColorForToastText;
		[Static]
		[Export("getColorForToastText")]
		//[Verify(MethodToProperty)]
		UIColor ColorForToastText { get; }

		// +(void)setColorForToastText:(UIColor *)toastTextColor;
		[Static]
		[Export("setColorForToastText:")]
		void SetColorForToastText(UIColor toastTextColor);

		// +(UIColor *)getColorForToastBackground;
		[Static]
		[Export("getColorForToastBackground")]
		//[Verify(MethodToProperty)]
		UIColor ColorForToastBackground { get; }

		// +(void)setColorForToastBackground:(UIColor *)toastBGColor;
		[Static]
		[Export("setColorForToastBackground:")]
		void SetColorForToastBackground(UIColor toastBGColor);

		// +(UIColor *)getSendMsgTextColor;
		[Static]
		[Export("getSendMsgTextColor")]
		//[Verify(MethodToProperty)]
		UIColor SendMsgTextColor { get; }

		// +(void)setSendMsgTextColor:(UIColor *)sendMsgColor;
		[Static]
		[Export("setSendMsgTextColor:")]
		void SetSendMsgTextColor(UIColor sendMsgColor);

		// +(UIColor *)getReceiveMsgTextColor;
		[Static]
		[Export("getReceiveMsgTextColor")]
		//[Verify(MethodToProperty)]
		UIColor ReceiveMsgTextColor { get; }

		// +(void)setReceiveMsgTextColor:(UIColor *)receiveMsgColor;
		[Static]
		[Export("setReceiveMsgTextColor:")]
		void SetReceiveMsgTextColor(UIColor receiveMsgColor);

		// +(UIColor *)getMsgTextViewBGColor;
		[Static]
		[Export("getMsgTextViewBGColor")]
		//[Verify(MethodToProperty)]
		UIColor MsgTextViewBGColor { get; }

		// +(void)setMsgTextViewBGColor:(UIColor *)color;
		[Static]
		[Export("setMsgTextViewBGColor:")]
		void SetMsgTextViewBGColor(UIColor color);

		// +(UIColor *)getPlaceHolderColor;
		[Static]
		[Export("getPlaceHolderColor")]
		//[Verify(MethodToProperty)]
		UIColor PlaceHolderColor { get; }

		// +(void)setPlaceHolderColor:(UIColor *)color;
		[Static]
		[Export("setPlaceHolderColor:")]
		void SetPlaceHolderColor(UIColor color);

		// +(UIColor *)getUnreadCountLabelBGColor;
		[Static]
		[Export("getUnreadCountLabelBGColor")]
		//[Verify(MethodToProperty)]
		UIColor UnreadCountLabelBGColor { get; }

		// +(void)setUnreadCountLabelBGColor:(UIColor *)color;
		[Static]
		[Export("setUnreadCountLabelBGColor:")]
		void SetUnreadCountLabelBGColor(UIColor color);

		// +(UIColor *)getStatusBarBGColor;
		[Static]
		[Export("getStatusBarBGColor")]
		//[Verify(MethodToProperty)]
		UIColor StatusBarBGColor { get; }

		// +(void)setStatusBarBGColor:(UIColor *)color;
		[Static]
		[Export("setStatusBarBGColor:")]
		void SetStatusBarBGColor(UIColor color);

		// +(UIStatusBarStyle)getStatusBarStyle;
		[Static]
		[Export("getStatusBarStyle")]
		//[Verify(MethodToProperty)]
		UIStatusBarStyle StatusBarStyle { get; }

		// +(void)setStatusBarStyle:(UIStatusBarStyle)style;
		[Static]
		[Export("setStatusBarStyle:")]
		void SetStatusBarStyle(UIStatusBarStyle style);

		// +(void)setMaxTextViewLines:(int)numberOfLines;
		[Static]
		[Export("setMaxTextViewLines:")]
		void SetMaxTextViewLines(int numberOfLines);

		// +(int)getMaxTextViewLines;
		[Static]
		[Export("getMaxTextViewLines")]
		//[Verify(MethodToProperty)]
		int MaxTextViewLines { get; }

		// +(void)setAbuseWarningText:(NSString *)warningText;
		[Static]
		[Export("setAbuseWarningText:")]
		void SetAbuseWarningText(string warningText);

		// +(NSString *)getAbuseWarningText;
		[Static]
		[Export("getAbuseWarningText")]
		//[Verify(MethodToProperty)]
		string AbuseWarningText { get; }

		// +(BOOL)getMessageAbuseMode;
		[Static]
		[Export("getMessageAbuseMode")]
		//[Verify(MethodToProperty)]
		bool MessageAbuseMode { get; }

		// +(void)setMessageAbuseMode:(BOOL)flag;
		[Static]
		[Export("setMessageAbuseMode:")]
		void SetMessageAbuseMode(bool flag);

		// +(UIColor *)getDateColor;
		[Static]
		[Export("getDateColor")]
		//[Verify(MethodToProperty)]
		UIColor DateColor { get; }

		// +(void)setDateColor:(UIColor *)dateColor;
		[Static]
		[Export("setDateColor:")]
		void SetDateColor(UIColor dateColor);

		// +(UIColor *)getMsgDateColor;
		[Static]
		[Export("getMsgDateColor")]
		//[Verify(MethodToProperty)]
		UIColor MsgDateColor { get; }

		// +(void)setMsgDateColor:(UIColor *)dateColor;
		[Static]
		[Export("setMsgDateColor:")]
		void SetMsgDateColor(UIColor dateColor);

		// +(BOOL)getReceiverUserProfileOption;
		[Static]
		[Export("getReceiverUserProfileOption")]
		//[Verify(MethodToProperty)]
		bool ReceiverUserProfileOption { get; }

		// +(void)setReceiverUserProfileOption:(BOOL)flag;
		[Static]
		[Export("setReceiverUserProfileOption:")]
		void SetReceiverUserProfileOption(bool flag);

		// +(float)getCustomMessageFontSize;
		[Static]
		[Export("getCustomMessageFontSize")]
		//[Verify(MethodToProperty)]
		float CustomMessageFontSize { get; }

		// +(void)setCustomMessageFontSize:(float)fontSize;
		[Static]
		[Export("setCustomMessageFontSize:")]
		void SetCustomMessageFontSize(float fontSize);

		// +(NSString *)getCustomMessageFont;
		[Static]
		[Export("getCustomMessageFont")]
		//[Verify(MethodToProperty)]
		string CustomMessageFont { get; }

		// +(void)setCustomMessageFont:(NSString *)font;
		[Static]
		[Export("setCustomMessageFont:")]
		void SetCustomMessageFont(string font);

		// +(void)setGroupInfoDisabled:(BOOL)flag;
		[Static]
		[Export("setGroupInfoDisabled:")]
		void SetGroupInfoDisabled(bool flag);

		// +(BOOL)isGroupInfoDisabled;
		[Static]
		[Export("isGroupInfoDisabled")]
		//[Verify(MethodToProperty)]
		bool IsGroupInfoDisabled { get; }

		// +(void)setGroupInfoEditDisabled:(BOOL)flag;
		[Static]
		[Export("setGroupInfoEditDisabled:")]
		void SetGroupInfoEditDisabled(bool flag);

		// +(BOOL)isGroupInfoEditDisabled;
		[Static]
		[Export("isGroupInfoEditDisabled")]
		//[Verify(MethodToProperty)]
		bool IsGroupInfoEditDisabled { get; }

		// +(void)setContactTypeToFilter:(NSMutableArray *)arrayWithIds;
		[Static]
		[Export("setContactTypeToFilter:")]
		void SetContactTypeToFilter(NSMutableArray arrayWithIds);

		// +(NSMutableArray *)getContactTypeToFilter;
		[Static]
		[Export("getContactTypeToFilter")]
		//[Verify(MethodToProperty)]
		NSMutableArray ContactTypeToFilter { get; }

		// +(NSString *)getCustomNavigationControllerClassName;
		[Static]
		[Export("getCustomNavigationControllerClassName")]
		//[Verify(MethodToProperty)]
		string CustomNavigationControllerClassName { get; }

		// +(void)setNavigationControllerClassName:(NSString *)className;
		[Static]
		[Export("setNavigationControllerClassName:")]
		void SetNavigationControllerClassName(string className);

		// +(BOOL)getSubGroupLaunchFlag;
		[Static]
		[Export("getSubGroupLaunchFlag")]
		//[Verify(MethodToProperty)]
		bool SubGroupLaunchFlag { get; }

		// +(void)setSubGroupLaunchFlag:(BOOL)flag;
		[Static]
		[Export("setSubGroupLaunchFlag:")]
		void SetSubGroupLaunchFlag(bool flag);

		// +(NSArray *)getListOfViewControllers;
		[Static]
		[Export("getListOfViewControllers")]
		//[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
		NSObject[] ListOfViewControllers { get; }

		// +(void)setListOfViewControllers:(NSArray *)viewList;
		[Static]
		[Export("setListOfViewControllers:")]
		//[Verify(StronglyTypedNSArray)]
		void SetListOfViewControllers(NSObject[] viewList);

		// +(void)setMsgContainerVC:(NSString *)className;
		[Static]
		[Export("setMsgContainerVC:")]
		void SetMsgContainerVC(string className);

		// +(NSString *)getMsgContainerVC;
		[Static]
		[Export("getMsgContainerVC")]
		//[Verify(MethodToProperty)]
		string MsgContainerVC { get; }
	}

	// @interface ALChannel : ALJson
	[BaseType(typeof(ALJson))]
	interface ALChannel
	{
		// @property (nonatomic, strong) NSNumber * key;
		[Export("key", ArgumentSemantic.Strong)]
		NSNumber Key { get; set; }

		// @property (nonatomic, strong) NSString * clientChannelKey;
		[Export("clientChannelKey", ArgumentSemantic.Strong)]
		string ClientChannelKey { get; set; }

		// @property (nonatomic, strong) NSString * name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * channelImageURL;
		[Export("channelImageURL", ArgumentSemantic.Strong)]
		string ChannelImageURL { get; set; }

		// @property (nonatomic, strong) NSString * adminKey;
		[Export("adminKey", ArgumentSemantic.Strong)]
		string AdminKey { get; set; }

		// @property (nonatomic) short type;
		[Export("type")]
		short Type { get; set; }

		// @property (nonatomic, strong) NSNumber * userCount;
		[Export("userCount", ArgumentSemantic.Strong)]
		NSNumber UserCount { get; set; }

		// @property (nonatomic, strong) NSNumber * unreadCount;
		[Export("unreadCount", ArgumentSemantic.Strong)]
		NSNumber UnreadCount { get; set; }

		// @property (copy, nonatomic) NSManagedObjectID * channelDBObjectId;
		[Export("channelDBObjectId", ArgumentSemantic.Copy)]
		NSManagedObjectID ChannelDBObjectId { get; set; }

		// @property (nonatomic, strong) NSMutableArray * membersName;
		[Export("membersName", ArgumentSemantic.Strong)]
		NSMutableArray MembersName { get; set; }

		// @property (nonatomic, strong) NSMutableArray * removeMembers;
		[Export("removeMembers", ArgumentSemantic.Strong)]
		NSMutableArray RemoveMembers { get; set; }

		// @property (nonatomic, strong) ALConversationProxy * conversationProxy;
		[Export("conversationProxy", ArgumentSemantic.Strong)]
		ALConversationProxy ConversationProxy { get; set; }

		// @property (nonatomic, strong) NSNumber * parentKey;
		[Export("parentKey", ArgumentSemantic.Strong)]
		NSNumber ParentKey { get; set; }

		// @property (nonatomic, strong) NSString * parentClientKey;
		[Export("parentClientKey", ArgumentSemantic.Strong)]
		string ParentClientKey { get; set; }

		// @property (nonatomic, strong) NSMutableArray * groupUsers;
		[Export("groupUsers", ArgumentSemantic.Strong)]
		NSMutableArray GroupUsers { get; set; }

		// @property (nonatomic, strong) NSMutableArray * childKeys;
		[Export("childKeys", ArgumentSemantic.Strong)]
		NSMutableArray ChildKeys { get; set; }

		// -(id)initWithDictonary:(NSDictionary *)messageDictonary;
		[Export("initWithDictonary:")]
		IntPtr Constructor(NSDictionary messageDictonary);

		// -(void)parseMessage:(id)messageJson;
		[Export("parseMessage:")]
		void ParseMessage(NSObject messageJson);

		// -(NSNumber *)getChannelMemberParentKey:(NSString *)userId;
		[Export("getChannelMemberParentKey:")]
		NSNumber GetChannelMemberParentKey(string userId);
	}

	// @interface ALUserDefaultsHandler : NSObject
	[BaseType(typeof(NSObject))]
	interface ALUserDefaultsHandler
	{
		// +(void)setConversationContactImageVisibility:(BOOL)visibility;
		[Static]
		[Export("setConversationContactImageVisibility:")]
		void SetConversationContactImageVisibility(bool visibility);

		// +(BOOL)isConversationContactImageVisible;
		[Static]
		[Export("isConversationContactImageVisible")]
		//[Verify(MethodToProperty)]
		bool IsConversationContactImageVisible { get; }

		// +(void)setBottomTabBarHidden:(BOOL)visibleStatus;
		[Static]
		[Export("setBottomTabBarHidden:")]
		void SetBottomTabBarHidden(bool visibleStatus);

		// +(BOOL)isBottomTabBarHidden;
		[Static]
		[Export("isBottomTabBarHidden")]
		//[Verify(MethodToProperty)]
		bool IsBottomTabBarHidden { get; }

		// +(void)setNavigationRightButtonHidden:(BOOL)flagValue;
		[Static]
		[Export("setNavigationRightButtonHidden:")]
		void SetNavigationRightButtonHidden(bool flagValue);

		// +(BOOL)isNavigationRightButtonHidden;
		[Static]
		[Export("isNavigationRightButtonHidden")]
		//[Verify(MethodToProperty)]
		bool IsNavigationRightButtonHidden { get; }

		// +(void)setBackButtonHidden:(BOOL)flagValue;
		[Static]
		[Export("setBackButtonHidden:")]
		void SetBackButtonHidden(bool flagValue);

		// +(BOOL)isBackButtonHidden;
		[Static]
		[Export("isBackButtonHidden")]
		//[Verify(MethodToProperty)]
		bool IsBackButtonHidden { get; }

		// +(BOOL)isLoggedIn;
		[Static]
		[Export("isLoggedIn")]
		//[Verify(MethodToProperty)]
		bool IsLoggedIn { get; }

		// +(void)clearAll;
		[Static]
		[Export("clearAll")]
		void ClearAll();

		// +(NSString *)getApplicationKey;
		[Static]
		[Export("getApplicationKey")]
		//[Verify(MethodToProperty)]
		string ApplicationKey { get; }

		// +(void)setApplicationKey:(NSString *)applicationKey;
		[Static]
		[Export("setApplicationKey:")]
		void SetApplicationKey(string applicationKey);

		// +(void)setEmailVerified:(BOOL)value;
		[Static]
		[Export("setEmailVerified:")]
		void SetEmailVerified(bool value);

		// +(void)setApnDeviceToken:(NSString *)apnDeviceToken;
		[Static]
		[Export("setApnDeviceToken:")]
		void SetApnDeviceToken(string apnDeviceToken);

		// +(NSString *)getApnDeviceToken;
		[Static]
		[Export("getApnDeviceToken")]
		//[Verify(MethodToProperty)]
		string ApnDeviceToken { get; }

		// +(void)setBoolForKey_isConversationDbSynced:(BOOL)value;
		[Static]
		[Export("setBoolForKey_isConversationDbSynced:")]
		void SetBoolForKey_isConversationDbSynced(bool value);

		// +(BOOL)getBoolForKey_isConversationDbSynced;
		[Static]
		[Export("getBoolForKey_isConversationDbSynced")]
		//[Verify(MethodToProperty)]
		bool BoolForKey_isConversationDbSynced { get; }

		// +(void)setDeviceKeyString:(NSString *)deviceKeyString;
		[Static]
		[Export("setDeviceKeyString:")]
		void SetDeviceKeyString(string deviceKeyString);

		// +(void)setUserKeyString:(NSString *)userKeyString;
		[Static]
		[Export("setUserKeyString:")]
		void SetUserKeyString(string userKeyString);

		// +(void)setDisplayName:(NSString *)displayName;
		[Static]
		[Export("setDisplayName:")]
		void SetDisplayName(string displayName);

		// +(void)setEmailId:(NSString *)emailId;
		[Static]
		[Export("setEmailId:")]
		void SetEmailId(string emailId);

		// +(NSString *)getEmailId;
		[Static]
		[Export("getEmailId")]
		//[Verify(MethodToProperty)]
		string EmailId { get; }

		// +(NSString *)getDeviceKeyString;
		[Static]
		[Export("getDeviceKeyString")]
		//[Verify(MethodToProperty)]
		string DeviceKeyString { get; }

		// +(void)setUserId:(NSString *)userId;
		[Static]
		[Export("setUserId:")]
		void SetUserId(string userId);

		// +(NSString *)getUserId;
		[Static]
		[Export("getUserId")]
		//[Verify(MethodToProperty)]
		string UserId { get; }

		// +(void)setLastSyncTime:(NSNumber *)lastSyncTime;
		[Static]
		[Export("setLastSyncTime:")]
		void SetLastSyncTime(NSNumber lastSyncTime);

		// +(void)setServerCallDoneForMSGList:(BOOL)value forContactId:(NSString *)constactId;
		[Static]
		[Export("setServerCallDoneForMSGList:forContactId:")]
		void SetServerCallDoneForMSGList(bool value, string constactId);

		// +(BOOL)isServerCallDoneForMSGList:(NSString *)contactId;
		[Static]
		[Export("isServerCallDoneForMSGList:")]
		bool IsServerCallDoneForMSGList(string contactId);

		// +(void)setProcessedNotificationIds:(NSMutableArray *)arrayWithIds;
		[Static]
		[Export("setProcessedNotificationIds:")]
		void SetProcessedNotificationIds(NSMutableArray arrayWithIds);

		// +(NSMutableArray *)getProcessedNotificationIds;
		[Static]
		[Export("getProcessedNotificationIds")]
		//[Verify(MethodToProperty)]
		NSMutableArray ProcessedNotificationIds { get; }

		// +(BOOL)isNotificationProcessd:(NSString *)withNotificationId;
		[Static]
		[Export("isNotificationProcessd:")]
		bool IsNotificationProcessd(string withNotificationId);

		// +(NSNumber *)getLastSeenSyncTime;
		[Static]
		[Export("getLastSeenSyncTime")]
		//[Verify(MethodToProperty)]
		NSNumber LastSeenSyncTime { get; }

		// +(void)setLastSeenSyncTime:(NSNumber *)lastSeenTime;
		[Static]
		[Export("setLastSeenSyncTime:")]
		void SetLastSeenSyncTime(NSNumber lastSeenTime);

		// +(void)setShowLoadEarlierOption:(BOOL)value forContactId:(NSString *)constactId;
		[Static]
		[Export("setShowLoadEarlierOption:forContactId:")]
		void SetShowLoadEarlierOption(bool value, string constactId);

		// +(BOOL)isShowLoadEarlierOption:(NSString *)constactId;
		[Static]
		[Export("isShowLoadEarlierOption:")]
		bool IsShowLoadEarlierOption(string constactId);

		// +(void)setLastSyncChannelTime:(NSNumber *)lastSyncChannelTime;
		[Static]
		[Export("setLastSyncChannelTime:")]
		void SetLastSyncChannelTime(NSNumber lastSyncChannelTime);

		// +(NSNumber *)getLastSyncChannelTime;
		[Static]
		[Export("getLastSyncChannelTime")]
		//[Verify(MethodToProperty)]
		NSNumber LastSyncChannelTime { get; }

		// +(NSNumber *)getLastSyncTime;
		[Static]
		[Export("getLastSyncTime")]
		//[Verify(MethodToProperty)]
		NSNumber LastSyncTime { get; }

		// +(NSString *)getUserKeyString;
		[Static]
		[Export("getUserKeyString")]
		//[Verify(MethodToProperty)]
		string UserKeyString { get; }

		// +(NSString *)getDisplayName;
		[Static]
		[Export("getDisplayName")]
		//[Verify(MethodToProperty)]
		string DisplayName { get; }

		// +(void)setUserBlockLastTimeStamp:(NSNumber *)lastTimeStamp;
		[Static]
		[Export("setUserBlockLastTimeStamp:")]
		void SetUserBlockLastTimeStamp(NSNumber lastTimeStamp);

		// +(NSNumber *)getUserBlockLastTimeStamp;
		[Static]
		[Export("getUserBlockLastTimeStamp")]
		//[Verify(MethodToProperty)]
		NSNumber UserBlockLastTimeStamp { get; }

		// +(NSString *)getPassword;
		[Static]
		[Export("getPassword")]
		//[Verify(MethodToProperty)]
		string Password { get; }

		// +(void)setPassword:(NSString *)password;
		[Static]
		[Export("setPassword:")]
		void SetPassword(string password);

		// +(void)setAppModuleName:(NSString *)appModuleName;
		[Static]
		[Export("setAppModuleName:")]
		void SetAppModuleName(string appModuleName);

		// +(NSString *)getAppModuleName;
		[Static]
		[Export("getAppModuleName")]
		//[Verify(MethodToProperty)]
		string AppModuleName { get; }

		// +(BOOL)getContactViewLoaded;
		[Static]
		[Export("getContactViewLoaded")]
		//[Verify(MethodToProperty)]
		bool ContactViewLoaded { get; }

		// +(void)setContactViewLoadStatus:(BOOL)status;
		[Static]
		[Export("setContactViewLoadStatus:")]
		void SetContactViewLoadStatus(bool status);

		// +(void)setServerCallDoneForUserInfo:(BOOL)value ForContact:(NSString *)contactId;
		[Static]
		[Export("setServerCallDoneForUserInfo:ForContact:")]
		void SetServerCallDoneForUserInfo(bool value, string contactId);

		// +(BOOL)isServerCallDoneForUserInfoForContact:(NSString *)contactId;
		[Static]
		[Export("isServerCallDoneForUserInfoForContact:")]
		bool IsServerCallDoneForUserInfoForContact(string contactId);

		// +(void)setBASEURL:(NSString *)baseURL;
		[Static]
		[Export("setBASEURL:")]
		void SetBASEURL(string baseURL);

		// +(NSString *)getBASEURL;
		[Static]
		[Export("getBASEURL")]
		//[Verify(MethodToProperty)]
		string BASEURL { get; }

		// +(void)setMQTTURL:(NSString *)mqttURL;
		[Static]
		[Export("setMQTTURL:")]
		void SetMQTTURL(string mqttURL);

		// +(NSString *)getMQTTURL;
		[Static]
		[Export("getMQTTURL")]
		//[Verify(MethodToProperty)]
		string MQTTURL { get; }

		// +(void)setFILEURL:(NSString *)fileURL;
		[Static]
		[Export("setFILEURL:")]
		void SetFILEURL(string fileURL);

		// +(NSString *)getFILEURL;
		[Static]
		[Export("getFILEURL")]
		//[Verify(MethodToProperty)]
		string FILEURL { get; }

		// +(void)setMQTTPort:(NSString *)portNumber;
		[Static]
		[Export("setMQTTPort:")]
		void SetMQTTPort(string portNumber);

		// +(NSString *)getMQTTPort;
		[Static]
		[Export("getMQTTPort")]
		//[Verify(MethodToProperty)]
		string MQTTPort { get; }

		// +(void)setUserTypeId:(short)type;
		[Static]
		[Export("setUserTypeId:")]
		void SetUserTypeId(short type);

		// +(short)getUserTypeId;
		[Static]
		[Export("getUserTypeId")]
		//[Verify(MethodToProperty)]
		short UserTypeId { get; }

		// +(NSNumber *)getLastMessageListTime;
		[Static]
		[Export("getLastMessageListTime")]
		//[Verify(MethodToProperty)]
		NSNumber LastMessageListTime { get; }

		// +(void)setLastMessageListTime:(NSNumber *)lastTime;
		[Static]
		[Export("setLastMessageListTime:")]
		void SetLastMessageListTime(NSNumber lastTime);

		// +(BOOL)getFlagForAllConversationFetched;
		[Static]
		[Export("getFlagForAllConversationFetched")]
		//[Verify(MethodToProperty)]
		bool FlagForAllConversationFetched { get; }

		// +(void)setFlagForAllConversationFetched:(BOOL)flag;
		[Static]
		[Export("setFlagForAllConversationFetched:")]
		void SetFlagForAllConversationFetched(bool flag);

		// +(NSInteger)getFetchConversationPageSize;
		[Static]
		[Export("getFetchConversationPageSize")]
		//[Verify(MethodToProperty)]
		nint FetchConversationPageSize { get; }

		// +(void)setFetchConversationPageSize:(NSInteger)limit;
		[Static]
		[Export("setFetchConversationPageSize:")]
		void SetFetchConversationPageSize(nint limit);

		// +(short)getNotificationMode;
		[Static]
		[Export("getNotificationMode")]
		//[Verify(MethodToProperty)]
		short NotificationMode { get; }

		// +(void)setNotificationMode:(short)mode;
		[Static]
		[Export("setNotificationMode:")]
		void SetNotificationMode(short mode);

		// +(short)getUserAuthenticationTypeId;
		[Static]
		[Export("getUserAuthenticationTypeId")]
		//[Verify(MethodToProperty)]
		short UserAuthenticationTypeId { get; }

		// +(void)setUserAuthenticationTypeId:(short)type;
		[Static]
		[Export("setUserAuthenticationTypeId:")]
		void SetUserAuthenticationTypeId(short type);

		// +(short)getUnreadCountType;
		[Static]
		[Export("getUnreadCountType")]
		//[Verify(MethodToProperty)]
		short UnreadCountType { get; }

		// +(void)setUnreadCountType:(short)mode;
		[Static]
		[Export("setUnreadCountType:")]
		void SetUnreadCountType(short mode);

		// +(BOOL)isMsgSyncRequired;
		[Static]
		[Export("isMsgSyncRequired")]
		//[Verify(MethodToProperty)]
		bool IsMsgSyncRequired { get; }

		// +(void)setMsgSyncRequired:(BOOL)flag;
		[Static]
		[Export("setMsgSyncRequired:")]
		void SetMsgSyncRequired(bool flag);

		// +(BOOL)isDebugLogsRequire;
		[Static]
		[Export("isDebugLogsRequire")]
		//[Verify(MethodToProperty)]
		bool IsDebugLogsRequire { get; }

		// +(void)setDebugLogsRequire:(BOOL)flag;
		[Static]
		[Export("setDebugLogsRequire:")]
		void SetDebugLogsRequire(bool flag);

		// +(BOOL)getLoginUserConatactVisibility;
		[Static]
		[Export("getLoginUserConatactVisibility")]
		//[Verify(MethodToProperty)]
		bool LoginUserConatactVisibility { get; }

		// +(void)setLoginUserConatactVisibility:(BOOL)flag;
		[Static]
		[Export("setLoginUserConatactVisibility:")]
		void SetLoginUserConatactVisibility(bool flag);

		// +(NSString *)getProfileImageLink;
		[Static]
		[Export("getProfileImageLink")]
		//[Verify(MethodToProperty)]
		string ProfileImageLink { get; }

		// +(void)setProfileImageLink:(NSString *)imageLink;
		[Static]
		[Export("setProfileImageLink:")]
		void SetProfileImageLink(string imageLink);

		// +(NSString *)getProfileImageLinkFromServer;
		[Static]
		[Export("getProfileImageLinkFromServer")]
		//[Verify(MethodToProperty)]
		string ProfileImageLinkFromServer { get; }

		// +(void)setProfileImageLinkFromServer:(NSString *)imageLink;
		[Static]
		[Export("setProfileImageLinkFromServer:")]
		void SetProfileImageLinkFromServer(string imageLink);

		// +(NSString *)getLoggedInUserStatus;
		[Static]
		[Export("getLoggedInUserStatus")]
		//[Verify(MethodToProperty)]
		string LoggedInUserStatus { get; }

		// +(void)setLoggedInUserStatus:(NSString *)status;
		[Static]
		[Export("setLoggedInUserStatus:")]
		void SetLoggedInUserStatus(string status);

		// +(void)setDeviceApnsType:(short)type;
		[Static]
		[Export("setDeviceApnsType:")]
		void SetDeviceApnsType(short type);

		// +(short)getDeviceApnsType;
		[Static]
		[Export("getDeviceApnsType")]
		//[Verify(MethodToProperty)]
		short DeviceApnsType { get; }

		// +(BOOL)isUserLoggedInUserSubscribedMQTT;
		[Static]
		[Export("isUserLoggedInUserSubscribedMQTT")]
		//[Verify(MethodToProperty)]
		bool IsUserLoggedInUserSubscribedMQTT { get; }

		// +(void)setLoggedInUserSubscribedMQTT:(BOOL)flag;
		[Static]
		[Export("setLoggedInUserSubscribedMQTT:")]
		void SetLoggedInUserSubscribedMQTT(bool flag);

		// +(NSString *)getEncryptionKey;
		[Static]
		[Export("getEncryptionKey")]
		//[Verify(MethodToProperty)]
		string EncryptionKey { get; }

		// +(void)setEncryptionKey:(NSString *)encrptionKey;
		[Static]
		[Export("setEncryptionKey:")]
		void SetEncryptionKey(string encrptionKey);

		// +(short)getUserPricingPackage;
		[Static]
		[Export("getUserPricingPackage")]
		//[Verify(MethodToProperty)]
		short UserPricingPackage { get; }

		// +(void)setUserPricingPackage:(short)pricingPackage;
		[Static]
		[Export("setUserPricingPackage:")]
		void SetUserPricingPackage(short pricingPackage);

		// +(BOOL)getEnableEncryption;
		[Static]
		[Export("getEnableEncryption")]
		//[Verify(MethodToProperty)]
		bool EnableEncryption { get; }

		// +(void)setEnableEncryption:(BOOL)flag;
		[Static]
		[Export("setEnableEncryption:")]
		void SetEnableEncryption(bool flag);

		// +(void)setGoogleMapAPIKey:(NSString *)googleMapAPIKey;
		[Static]
		[Export("setGoogleMapAPIKey:")]
		void SetGoogleMapAPIKey(string googleMapAPIKey);

		// +(NSString *)getGoogleMapAPIKey;
		[Static]
		[Export("getGoogleMapAPIKey")]
		//[Verify(MethodToProperty)]
		string GoogleMapAPIKey { get; }
	}

	// @interface ALChannelService : NSObject
	[BaseType(typeof(NSObject))]
	interface ALChannelService
	{
		// -(void)callForChannelServiceForDBInsertion:(id)theJson;
		[Export("callForChannelServiceForDBInsertion:")]
		void CallForChannelServiceForDBInsertion(NSObject theJson);

		// -(void)getChannelInformation:(NSNumber *)channelKey orClientChannelKey:(NSString *)clientChannelKey withCompletion:(void (^)(ALChannel *))completion;
		[Export("getChannelInformation:orClientChannelKey:withCompletion:")]
		void GetChannelInformation(NSNumber channelKey, string clientChannelKey, Action<ALChannel> completion);

		// -(ALChannel *)getChannelByKey:(NSNumber *)channelKey;
		[Export("getChannelByKey:")]
		ALChannel GetChannelByKey(NSNumber channelKey);

		// -(NSMutableArray *)getListOfAllUsersInChannel:(NSNumber *)channelKey;
		[Export("getListOfAllUsersInChannel:")]
		NSMutableArray GetListOfAllUsersInChannel(NSNumber channelKey);

		// -(NSString *)stringFromChannelUserList:(NSNumber *)key;
		[Export("stringFromChannelUserList:")]
		string StringFromChannelUserList(NSNumber key);

		// -(void)createChannel:(NSString *)channelName orClientChannelKey:(NSString *)clientChannelKey andMembersList:(NSMutableArray *)memberArray andImageLink:(NSString *)imageLink withCompletion:(void (^)(ALChannel *))completion;
		[Export("createChannel:orClientChannelKey:andMembersList:andImageLink:withCompletion:")]
		void CreateChannel(string channelName, string clientChannelKey, NSMutableArray memberArray, string imageLink, Action<ALChannel> completion);

		// -(void)createChannel:(NSString *)channelName orClientChannelKey:(NSString *)clientChannelKey andMembersList:(NSMutableArray *)memberArray andImageLink:(NSString *)imageLink channelType:(short)type andMetaData:(NSMutableDictionary *)metaData withCompletion:(void (^)(ALChannel *))completion;
		[Export("createChannel:orClientChannelKey:andMembersList:andImageLink:channelType:andMetaData:withCompletion:")]
		void CreateChannel(string channelName, string clientChannelKey, NSMutableArray memberArray, string imageLink, short type, NSMutableDictionary metaData, Action<ALChannel> completion);

		// -(void)createChannel:(NSString *)channelName andParentChannelKey:(NSNumber *)parentChannelKey orClientChannelKey:(NSString *)clientChannelKey andMembersList:(NSMutableArray *)memberArray andImageLink:(NSString *)imageLink channelType:(short)type andMetaData:(NSMutableDictionary *)metaData withCompletion:(void (^)(ALChannel *))completion;
		[Export("createChannel:andParentChannelKey:orClientChannelKey:andMembersList:andImageLink:channelType:andMetaData:withCompletion:")]
		void CreateChannel(string channelName, NSNumber parentChannelKey, string clientChannelKey, NSMutableArray memberArray, string imageLink, short type, NSMutableDictionary metaData, Action<ALChannel> completion);

		// -(void)addMemberToChannel:(NSString *)userId andChannelKey:(NSNumber *)channelKey orClientChannelKey:(NSString *)clientChannelKey withCompletion:(void (^)(NSError *, ALAPIResponse *))completion;
		[Export("addMemberToChannel:andChannelKey:orClientChannelKey:withCompletion:")]
		void AddMemberToChannel(string userId, NSNumber channelKey, string clientChannelKey, Action<NSError, ALAPIResponse> completion);

		// -(void)removeMemberFromChannel:(NSString *)userId andChannelKey:(NSNumber *)channelKey orClientChannelKey:(NSString *)clientChannelKey withCompletion:(void (^)(NSError *, ALAPIResponse *))completion;
		[Export("removeMemberFromChannel:andChannelKey:orClientChannelKey:withCompletion:")]
		void RemoveMemberFromChannel(string userId, NSNumber channelKey, string clientChannelKey, Action<NSError, ALAPIResponse> completion);

		// -(void)deleteChannel:(NSNumber *)channelKey orClientChannelKey:(NSString *)clientChannelKey withCompletion:(void (^)(NSError *, ALAPIResponse *))completion;
		[Export("deleteChannel:orClientChannelKey:withCompletion:")]
		void DeleteChannel(NSNumber channelKey, string clientChannelKey, Action<NSError, ALAPIResponse> completion);

		// -(BOOL)checkAdmin:(NSNumber *)channelKey;
		[Export("checkAdmin:")]
		bool CheckAdmin(NSNumber channelKey);

		// -(void)leaveChannel:(NSNumber *)channelKey andUserId:(NSString *)userId orClientChannelKey:(NSString *)clientChannelKey withCompletion:(void (^)(NSError *))completion;
		[Export("leaveChannel:andUserId:orClientChannelKey:withCompletion:")]
		void LeaveChannel(NSNumber channelKey, string userId, string clientChannelKey, Action<NSError> completion);

		// -(void)syncCallForChannel;
		[Export("syncCallForChannel")]
		void SyncCallForChannel();

		// -(void)updateChannel:(NSNumber *)channelKey andNewName:(NSString *)newName andImageURL:(NSString *)imageURL orClientChannelKey:(NSString *)clientChannelKey orChildKeys:(NSMutableArray *)childKeysList withCompletion:(void (^)(NSError *))completion;
		[Export("updateChannel:andNewName:andImageURL:orClientChannelKey:orChildKeys:withCompletion:")]
		void UpdateChannel(NSNumber channelKey, string newName, string imageURL, string clientChannelKey, NSMutableArray childKeysList, Action<NSError> completion);

		// +(void)markConversationAsRead:(NSNumber *)channelKey withCompletion:(void (^)(NSString *, NSError *))completion;
		[Static]
		[Export("markConversationAsRead:withCompletion:")]
		void MarkConversationAsRead(NSNumber channelKey, Action<NSString, NSError> completion);

		// -(BOOL)isChannelLeft:(NSNumber *)groupID;
		[Export("isChannelLeft:")]
		bool IsChannelLeft(NSNumber groupID);

		// +(void)setUnreadCountZeroForGroupID:(NSNumber *)channelKey;
		[Static]
		[Export("setUnreadCountZeroForGroupID:")]
		void SetUnreadCountZeroForGroupID(NSNumber channelKey);

		// -(NSNumber *)getOverallUnreadCountForChannel;
		[Export("getOverallUnreadCountForChannel")]
		//[Verify(MethodToProperty)]
		NSNumber OverallUnreadCountForChannel { get; }

		// -(ALChannel *)fetchChannelWithClientChannelKey:(NSString *)clientChannelKey;
		[Export("fetchChannelWithClientChannelKey:")]
		ALChannel FetchChannelWithClientChannelKey(string clientChannelKey);

		// -(BOOL)isLoginUserInChannel:(NSNumber *)channelKey;
		[Export("isLoginUserInChannel:")]
		bool IsLoginUserInChannel(NSNumber channelKey);

		// -(NSMutableArray *)getAllChannelList;
		[Export("getAllChannelList")]
		//[Verify(MethodToProperty)]
		NSMutableArray AllChannelList { get; }

		// -(NSMutableArray *)fetchChildChannelsWithParentKey:(NSNumber *)parentGroupKey;
		[Export("fetchChildChannelsWithParentKey:")]
		NSMutableArray FetchChildChannelsWithParentKey(NSNumber parentGroupKey);

		// -(void)processChildGroups:(ALChannel *)alChannel;
		[Export("processChildGroups:")]
		void ProcessChildGroups(ALChannel alChannel);

		// -(void)addChildKeyList:(NSMutableArray *)childKeyList andParentKey:(NSNumber *)parentKey withCompletion:(void (^)(id, NSError *))completion;
		[Export("addChildKeyList:andParentKey:withCompletion:")]
		void AddChildKeyList(NSMutableArray childKeyList, NSNumber parentKey, Action<NSObject, NSError> completion);

		// -(void)removeChildKeyList:(NSMutableArray *)childKeyList andParentKey:(NSNumber *)parentKey withCompletion:(void (^)(id, NSError *))completion;
		[Export("removeChildKeyList:andParentKey:withCompletion:")]
		void RemoveChildKeyList(NSMutableArray childKeyList, NSNumber parentKey, Action<NSObject, NSError> completion);

		// -(void)addClientChildKeyList:(NSMutableArray *)clientChildKeyList andParentKey:(NSString *)clientParentKey withCompletion:(void (^)(id, NSError *))completion;
		[Export("addClientChildKeyList:andParentKey:withCompletion:")]
		void AddClientChildKeyList(NSMutableArray clientChildKeyList, string clientParentKey, Action<NSObject, NSError> completion);

		// -(void)removeClientChildKeyList:(NSMutableArray *)clientChildKeyList andParentKey:(NSString *)clientParentKey withCompletion:(void (^)(id, NSError *))completion;
		[Export("removeClientChildKeyList:andParentKey:withCompletion:")]
		void RemoveClientChildKeyList(NSMutableArray clientChildKeyList, string clientParentKey, Action<NSObject, NSError> completion);
	}

	// @interface ALContact : ALJson
	[BaseType(typeof(ALJson))]
	interface ALContact
	{
		// @property (retain, nonatomic) NSString * userId;
		[Export("userId", ArgumentSemantic.Retain)]
		string UserId { get; set; }

		// @property (retain, nonatomic) NSString * fullName;
		[Export("fullName", ArgumentSemantic.Retain)]
		string FullName { get; set; }

		// @property (retain, nonatomic) NSString * contactNumber;
		[Export("contactNumber", ArgumentSemantic.Retain)]
		string ContactNumber { get; set; }

		// @property (retain, nonatomic) NSString * displayName;
		[Export("displayName", ArgumentSemantic.Retain)]
		string DisplayName { get; set; }

		// @property (retain, nonatomic) NSString * contactImageUrl;
		[Export("contactImageUrl", ArgumentSemantic.Retain)]
		string ContactImageUrl { get; set; }

		// @property (retain, nonatomic) NSString * email;
		[Export("email", ArgumentSemantic.Retain)]
		string Email { get; set; }

		// @property (retain, nonatomic) NSString * localImageResourceName;
		[Export("localImageResourceName", ArgumentSemantic.Retain)]
		string LocalImageResourceName { get; set; }

		// @property (retain, nonatomic) NSString * userStatus;
		[Export("userStatus", ArgumentSemantic.Retain)]
		string UserStatus { get; set; }

		// @property (retain, nonatomic) NSString * applicationId;
		[Export("applicationId", ArgumentSemantic.Retain)]
		string ApplicationId { get; set; }

		// @property (nonatomic) BOOL connected;
		[Export("connected")]
		bool Connected { get; set; }

		// @property (retain, nonatomic) NSNumber * lastSeenAt;
		[Export("lastSeenAt", ArgumentSemantic.Retain)]
		NSNumber LastSeenAt { get; set; }

		// -(instancetype)initWithDict:(NSDictionary *)dictionary;
		[Export("initWithDict:")]
		IntPtr Constructor(NSDictionary dictionary);

		// -(void)populateDataFromDictonary:(NSDictionary *)dict;
		[Export("populateDataFromDictonary:")]
		void PopulateDataFromDictonary(NSDictionary dict);

		// -(NSString *)getDisplayName;
		//[Export("getDisplayName")]
		//[Verify(MethodToProperty)]
		//string DisplayName { get; }

		// @property (nonatomic, strong) NSNumber * unreadCount;
		[Export("unreadCount", ArgumentSemantic.Strong)]
		NSNumber UnreadCount { get; set; }

		// @property (nonatomic) BOOL block;
		[Export("block")]
		bool Block { get; set; }

		// @property (nonatomic) BOOL blockBy;
		[Export("blockBy")]
		bool BlockBy { get; set; }

		// @property (retain, nonatomic) NSNumber * userTypeId;
		[Export("userTypeId", ArgumentSemantic.Retain)]
		NSNumber UserTypeId { get; set; }

		// @property (retain, nonatomic) NSNumber * contactType;
		[Export("contactType", ArgumentSemantic.Retain)]
		NSNumber ContactType { get; set; }
	}

	// @interface ALContactService : NSObject
	[BaseType(typeof(NSObject))]
	interface ALContactService
	{
		// -(BOOL)purgeListOfContacts:(NSArray *)contacts;
		[Export("purgeListOfContacts:")]
		//[Verify(StronglyTypedNSArray)]
		bool PurgeListOfContacts(NSObject[] contacts);

		// -(BOOL)purgeContact:(ALContact *)contact;
		[Export("purgeContact:")]
		bool PurgeContact(ALContact contact);

		// -(BOOL)purgeAllContact;
		[Export("purgeAllContact")]
		//[Verify(MethodToProperty)]
		bool PurgeAllContact { get; }

		// -(BOOL)updateListOfContacts:(NSArray *)contacts;
		[Export("updateListOfContacts:")]
		//[Verify(StronglyTypedNSArray)]
		bool UpdateListOfContacts(NSObject[] contacts);

		// -(BOOL)updateContact:(ALContact *)contact;
		[Export("updateContact:")]
		bool UpdateContact(ALContact contact);

		// -(BOOL)addListOfContacts:(NSArray *)contacts;
		[Export("addListOfContacts:")]
		//[Verify(StronglyTypedNSArray)]
		bool AddListOfContacts(NSObject[] contacts);

		// -(BOOL)addContact:(ALContact *)userContact;
		[Export("addContact:")]
		bool AddContact(ALContact userContact);

		// -(ALContact *)loadContactByKey:(NSString *)key value:(NSString *)value;
		[Export("loadContactByKey:value:")]
		ALContact LoadContactByKey(string key, string value);

		// -(ALContact *)loadOrAddContactByKeyWithDisplayName:(NSString *)contactId value:(NSString *)displayName;
		[Export("loadOrAddContactByKeyWithDisplayName:value:")]
		ALContact LoadOrAddContactByKeyWithDisplayName(string contactId, string displayName);

		// -(BOOL)setUnreadCountInDB:(ALContact *)contact;
		[Export("setUnreadCountInDB:")]
		bool SetUnreadCountInDB(ALContact contact);

		// -(NSNumber *)getOverallUnreadCountForContact;
		[Export("getOverallUnreadCountForContact")]
		//[Verify(MethodToProperty)]
		NSNumber OverallUnreadCountForContact { get; }

		// -(BOOL)isContactExist:(NSString *)value;
		[Export("isContactExist:")]
		bool IsContactExist(string value);

		// -(BOOL)updateOrInsert:(ALContact *)contact;
		[Export("updateOrInsert:")]
		bool UpdateOrInsert(ALContact contact);

		// -(void)updateOrInsertListOfContacts:(NSMutableArray *)contacts;
		[Export("updateOrInsertListOfContacts:")]
		void UpdateOrInsertListOfContacts(NSMutableArray contacts);
	}

	// @interface ALConversationService : NSObject
	[BaseType(typeof(NSObject))]
	interface ALConversationService
	{
		// -(ALConversationProxy *)getConversationByKey:(NSNumber *)conversationKey;
		[Export("getConversationByKey:")]
		ALConversationProxy GetConversationByKey(NSNumber conversationKey);

		// -(void)addConversations:(NSMutableArray *)conversations;
		[Export("addConversations:")]
		void AddConversations(NSMutableArray conversations);

		// -(NSMutableArray *)getConversationProxyListForUserID:(NSString *)userId;
		[Export("getConversationProxyListForUserID:")]
		NSMutableArray GetConversationProxyListForUserID(string userId);

		// -(NSMutableArray *)getConversationProxyListForChannelKey:(NSNumber *)channelKey;
		[Export("getConversationProxyListForChannelKey:")]
		NSMutableArray GetConversationProxyListForChannelKey(NSNumber channelKey);

		// -(void)createConversation:(ALConversationProxy *)alConversationProxy withCompletion:(void (^)(NSError *, ALConversationProxy *))completion;
		[Export("createConversation:withCompletion:")]
		void CreateConversation(ALConversationProxy alConversationProxy, Action<NSError, ALConversationProxy> completion);

		// -(void)fetchTopicDetails:(NSNumber *)alConversationProxyID;
		[Export("fetchTopicDetails:")]
		void FetchTopicDetails(NSNumber alConversationProxyID);
	}

	// @protocol MessageServiceWrapperDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MessageServiceWrapperDelegate
	{
		// @optional -(void)updateBytesDownloaded:(NSUInteger)bytesReceived;
		[Export("updateBytesDownloaded:")]
		void UpdateBytesDownloaded(nuint bytesReceived);

		// @optional -(void)updateBytesUploaded:(NSUInteger)bytesSent;
		[Export("updateBytesUploaded:")]
		void UpdateBytesUploaded(nuint bytesSent);

		// @optional -(void)uploadDownloadFailed:(ALMessage *)alMessage;
		[Export("uploadDownloadFailed:")]
		void UploadDownloadFailed(ALMessage alMessage);

		// @optional -(void)uploadCompleted:(ALMessage *)alMessage;
		[Export("uploadCompleted:")]
		void UploadCompleted(ALMessage alMessage);

		// @optional -(void)DownloadCompleted:(ALMessage *)alMessage;
		[Export("DownloadCompleted:")]
		void DownloadCompleted(ALMessage alMessage);
	}

	// @interface ALMessageServiceWrapper : NSObject <NSURLConnectionDataDelegate>
	[BaseType(typeof(NSObject))]
	interface ALMessageServiceWrapper : INSUrlConnectionDataDelegate
	{
		[Wrap("WeakMessageServiceDelegate")]
		MessageServiceWrapperDelegate MessageServiceDelegate { get; set; }

		// @property (nonatomic, strong) id<MessageServiceWrapperDelegate> messageServiceDelegate;
		[NullAllowed, Export("messageServiceDelegate", ArgumentSemantic.Strong)]
		NSObject WeakMessageServiceDelegate { get; set; }

		// -(void)sendTextMessage:(NSString *)text andtoContact:(NSString *)toContactId withCompletion:(void (^)(NSString *, NSError *))completion;
		[Export("sendTextMessage:andtoContact:withCompletion:")]
		void SendTextMessage(string text, string toContactId, Action<NSString, NSError> completion);

		// -(void)sendMessage:(ALMessage *)almessage withCompletion:(void (^)(NSString *, NSError *))completion;
		[Export("sendMessage:withCompletion:")]
		void SendMessage(ALMessage almessage, Action<NSString, NSError> completion);

		// -(void)sendMessageWithAttachment:(ALMessage *)alMessage withAttachmentAtLocation:(NSString *)attachmentLocalPath andWithStatusDelegate:(id)statusDelegate andContentType:(short)contentype;
		[Export("sendMessageWithAttachment:withAttachmentAtLocation:andWithStatusDelegate:andContentType:")]
		void SendMessageWithAttachment(ALMessage alMessage, string attachmentLocalPath, NSObject statusDelegate, short contentype);

		// -(void)downloadMessageAttachment:(ALMessage *)alMessage;
		[Export("downloadMessageAttachment:")]
		void DownloadMessageAttachment(ALMessage alMessage);

		// -(ALMessage *)createMessageEntityOfContentType:(int)contentType toSendTo:(NSString *)to withText:(NSString *)text;
		[Export("createMessageEntityOfContentType:toSendTo:withText:")]
		ALMessage CreateMessageEntityOfContentType(int contentType, string to, string text);
	}

	// @interface ALPushNotificationService : NSObject
	[BaseType(typeof(NSObject))]
	interface ALPushNotificationService
	{
		// -(BOOL)isApplozicNotification:(NSDictionary *)dictionary;
		[Export("isApplozicNotification:")]
		bool IsApplozicNotification(NSDictionary dictionary);

		// -(BOOL)processPushNotification:(NSDictionary *)dictionary updateUI:(NSNumber *)updateUI;
		[Export("processPushNotification:updateUI:")]
		bool ProcessPushNotification(NSDictionary dictionary, NSNumber updateUI);

		// @property (readonly, nonatomic, strong) UIViewController * topViewController;
		[Export("topViewController", ArgumentSemantic.Strong)]
		UIViewController TopViewController { get; }

		// -(void)notificationArrivedToApplication:(UIApplication *)application withDictionary:(NSDictionary *)userInfo;
		[Export("notificationArrivedToApplication:withDictionary:")]
		void NotificationArrivedToApplication(UIApplication application, NSDictionary userInfo);

		// +(void)applicationEntersForeground;
		[Static]
		[Export("applicationEntersForeground")]
		void ApplicationEntersForeground();

		// +(void)userSync;
		[Static]
		[Export("userSync")]
		void UserSync();
	}

	// @interface ALRegistrationResponse : ALJson
	[BaseType(typeof(ALJson))]
	interface ALRegistrationResponse
	{
		// @property NSString * message;
		[Export("message")]
		string Message { get; set; }

		// @property NSString * deviceKey;
		[Export("deviceKey")]
		string DeviceKey { get; set; }

		// @property NSString * userKey;
		[Export("userKey")]
		string UserKey { get; set; }

		// @property NSString * contactNumber;
		[Export("contactNumber")]
		string ContactNumber { get; set; }

		// @property NSString * lastSyncTime;
		[Export("lastSyncTime")]
		string LastSyncTime { get; set; }

		// @property NSString * currentTimeStamp;
		[Export("currentTimeStamp")]
		string CurrentTimeStamp { get; set; }

		// @property NSString * brokerURL;
		[Export("brokerURL")]
		string BrokerURL { get; set; }

		// @property NSString * imageLink;
		[Export("imageLink")]
		string ImageLink { get; set; }

		// @property NSString * statusMessage;
		[Export("statusMessage")]
		string StatusMessage { get; set; }

		// @property NSString * encryptionKey;
		[Export("encryptionKey")]
		string EncryptionKey { get; set; }

		// @property short pricingPackage;
		[Export("pricingPackage")]
		short PricingPackage { get; set; }
	}

	// @interface ALUser : ALJson
	[BaseType(typeof(ALJson))]
	interface ALUser
	{
		// @property NSString * userId;
		[Export("userId")]
		string UserId { get; set; }

		// @property NSString * email;
		[Export("email")]
		string Email { get; set; }

		// @property NSString * password;
		[Export("password")]
		string Password { get; set; }

		// @property NSString * displayName;
		[Export("displayName")]
		string DisplayName { get; set; }

		// @property NSString * registrationId;
		[Export("registrationId")]
		string RegistrationId { get; set; }

		// @property NSString * applicationId;
		[Export("applicationId")]
		string ApplicationId { get; set; }

		// @property NSString * contactNumber;
		[Export("contactNumber")]
		string ContactNumber { get; set; }

		// @property NSString * countryCode;
		[Export("countryCode")]
		string CountryCode { get; set; }

		// @property short prefContactAPI;
		[Export("prefContactAPI")]
		short PrefContactAPI { get; set; }

		// @property Boolean emailVerified;
		[Export("emailVerified")]
		byte EmailVerified { get; set; }

		// @property NSString * timezone;
		[Export("timezone")]
		string Timezone { get; set; }

		// @property NSString * appVersionCode;
		[Export("appVersionCode")]
		string AppVersionCode { get; set; }

		// @property NSString * roleName;
		[Export("roleName")]
		string RoleName { get; set; }

		// @property short deviceType;
		[Export("deviceType")]
		short DeviceType { get; set; }

		// @property NSString * imageLink;
		[Export("imageLink")]
		string ImageLink { get; set; }

		// @property NSString * appModuleName;
		[Export("appModuleName")]
		string AppModuleName { get; set; }

		// @property short userTypeId;
		[Export("userTypeId")]
		short UserTypeId { get; set; }

		// @property short notificationMode;
		[Export("notificationMode")]
		short NotificationMode { get; set; }

		// @property short authenticationTypeId;
		[Export("authenticationTypeId")]
		short AuthenticationTypeId { get; set; }

		// @property short unreadCountType;
		[Export("unreadCountType")]
		short UnreadCountType { get; set; }

		// @property short deviceApnsType;
		[Export("deviceApnsType")]
		short DeviceApnsType { get; set; }

		// @property BOOL enableEncryption;
		[Export("enableEncryption")]
		bool EnableEncryption { get; set; }

		// @property NSNumber * contactType;
		[Export("contactType", ArgumentSemantic.Assign)]
		NSNumber ContactType { get; set; }
	}

	// @interface ALRegisterUserClientService : NSObject
	[BaseType(typeof(NSObject))]
	interface ALRegisterUserClientService
	{
		// -(void)initWithCompletion:(ALUser *)user withCompletion:(void (^)(ALRegistrationResponse *, NSError *))completion;
		[Export("initWithCompletion:withCompletion:")]
		void InitWithCompletion(ALUser user, Action<ALRegistrationResponse, NSError> completion);

		// -(void)updateApnDeviceTokenWithCompletion:(NSString *)apnDeviceToken withCompletion:(void (^)(ALRegistrationResponse *, NSError *))completion;
		[Export("updateApnDeviceTokenWithCompletion:withCompletion:")]
		void UpdateApnDeviceTokenWithCompletion(string apnDeviceToken, Action<ALRegistrationResponse, NSError> completion);

		// +(void)updateNotificationMode:(short)notificationMode withCompletion:(void (^)(ALRegistrationResponse *, NSError *))completion;
		[Static]
		[Export("updateNotificationMode:withCompletion:")]
		void UpdateNotificationMode(short notificationMode, Action<ALRegistrationResponse, NSError> completion);

		// -(void)connect;
		[Export("connect")]
		void Connect();

		// -(void)disconnect;
		[Export("disconnect")]
		void Disconnect();

		// -(void)logoutWithCompletionHandler:(void (^)())completion;
		[Export("logoutWithCompletionHandler:")]
		void LogoutWithCompletionHandler(Action completion);

		// +(BOOL)isAppUpdated;
		[Static]
		[Export("isAppUpdated")]
		//[Verify(MethodToProperty)]
		bool IsAppUpdated { get; }

		// -(void)syncAccountStatus;
		[Export("syncAccountStatus")]
		void SyncAccountStatus();
	}

	// @interface ALUserDetail : ALJson
	[BaseType(typeof(ALJson))]
	interface ALUserDetail
	{
		// @property (nonatomic, strong) NSString * userId;
		[Export("userId", ArgumentSemantic.Strong)]
		string UserId { get; set; }

		// @property (nonatomic) BOOL connected;
		[Export("connected")]
		bool Connected { get; set; }

		// @property (nonatomic, strong) NSNumber * lastSeenAtTime;
		[Export("lastSeenAtTime", ArgumentSemantic.Strong)]
		NSNumber LastSeenAtTime { get; set; }

		// @property (nonatomic, strong) NSNumber * unreadCount;
		[Export("unreadCount", ArgumentSemantic.Strong)]
		NSNumber UnreadCount { get; set; }

		// @property (nonatomic, strong) NSString * displayName;
		[Export("displayName", ArgumentSemantic.Strong)]
		string DisplayName { get; set; }

		// @property (copy, nonatomic) NSManagedObjectID * userDetailDBObjectId;
		[Export("userDetailDBObjectId", ArgumentSemantic.Copy)]
		NSManagedObjectID UserDetailDBObjectId { get; set; }

		// @property (nonatomic, strong) NSString * imageLink;
		[Export("imageLink", ArgumentSemantic.Strong)]
		string ImageLink { get; set; }

		// @property (nonatomic, strong) NSString * contactNumber;
		[Export("contactNumber", ArgumentSemantic.Strong)]
		string ContactNumber { get; set; }

		// @property (nonatomic, strong) NSString * userStatus;
		[Export("userStatus", ArgumentSemantic.Strong)]
		string UserStatus { get; set; }

		// @property (nonatomic, strong) NSArray * keyArray;
		[Export("keyArray", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] KeyArray { get; set; }

		// @property (nonatomic, strong) NSArray * valueArray;
		[Export("valueArray", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] ValueArray { get; set; }

		// @property (nonatomic, strong) NSString * userIdString;
		[Export("userIdString", ArgumentSemantic.Strong)]
		string UserIdString { get; set; }

		// @property (nonatomic, strong) NSNumber * userTypeId;
		[Export("userTypeId", ArgumentSemantic.Strong)]
		NSNumber UserTypeId { get; set; }

		// -(void)setUserDetails:(NSString *)jsonString;
		[Export("setUserDetails:")]
		void SetUserDetails(string jsonString);

		// -(void)userDetail;
		[Export("userDetail")]
		void UserDetail();

		// -(NSString *)getDisplayName;
		//[Export("getDisplayName")]
		//[Verify(MethodToProperty)]
		//string DisplayName { get; }

		// -(id)initWithDictonary:(NSDictionary *)messageDictonary;
		[Export("initWithDictonary:")]
		IntPtr Constructor(NSDictionary messageDictonary);

		// -(void)parsingDictionaryFromJSON:(NSDictionary *)JSONDictionary;
		[Export("parsingDictionaryFromJSON:")]
		void ParsingDictionaryFromJSON(NSDictionary JSONDictionary);
	}

	// @interface ALUserService : NSObject
	[BaseType(typeof(NSObject))]
	interface ALUserService
	{
		// +(void)processContactFromMessages:(NSArray *)messagesArr withCompletion:(void (^)())completionMark;
		[Static]
		[Export("processContactFromMessages:withCompletion:")]
		//[Verify(StronglyTypedNSArray)]
		void ProcessContactFromMessages(NSObject[] messagesArr, Action completionMark);

		// +(void)getLastSeenUpdateForUsers:(NSNumber *)lastSeenAt withCompletion:(void (^)(NSMutableArray *))completionMark;
		[Static]
		[Export("getLastSeenUpdateForUsers:withCompletion:")]
		void GetLastSeenUpdateForUsers(NSNumber lastSeenAt, Action<NSMutableArray> completionMark);

		// +(void)userDetailServerCall:(NSString *)contactId withCompletion:(void (^)(ALUserDetail *))completionMark;
		[Static]
		[Export("userDetailServerCall:withCompletion:")]
		void UserDetailServerCall(string contactId, Action<ALUserDetail> completionMark);

		// +(void)updateUserDisplayName:(ALContact *)alContact;
		[Static]
		[Export("updateUserDisplayName:")]
		void UpdateUserDisplayName(ALContact alContact);

		// +(void)markConversationAsRead:(NSString *)contactId withCompletion:(void (^)(NSString *, NSError *))completion;
		[Static]
		[Export("markConversationAsRead:withCompletion:")]
		void MarkConversationAsRead(string contactId, Action<NSString, NSError> completion);

		// +(void)markMessageAsRead:(ALMessage *)alMessage withPairedkeyValue:(NSString *)pairedkeyValue withCompletion:(void (^)(NSString *, NSError *))completion;
		[Static]
		[Export("markMessageAsRead:withPairedkeyValue:withCompletion:")]
		void MarkMessageAsRead(ALMessage alMessage, string pairedkeyValue, Action<NSString, NSError> completion);

		// -(void)blockUser:(NSString *)userId withCompletionHandler:(void (^)(NSError *, BOOL))completion;
		[Export("blockUser:withCompletionHandler:")]
		void BlockUser(string userId, Action<NSError, bool> completion);

		// -(void)blockUserSync:(NSNumber *)lastSyncTime;
		[Export("blockUserSync:")]
		void BlockUserSync(NSNumber lastSyncTime);

		// -(void)unblockUser:(NSString *)userId withCompletionHandler:(void (^)(NSError *, BOOL))completion;
		[Export("unblockUser:withCompletionHandler:")]
		void UnblockUser(string userId, Action<NSError, bool> completion);

		// -(NSMutableArray *)getListOfBlockedUserByCurrentUser;
		[Export("getListOfBlockedUserByCurrentUser")]
		//[Verify(MethodToProperty)]
		NSMutableArray ListOfBlockedUserByCurrentUser { get; }

		// +(void)setUnreadCountZeroForContactId:(NSString *)contactId;
		[Static]
		[Export("setUnreadCountZeroForContactId:")]
		void SetUnreadCountZeroForContactId(string contactId);

		// -(void)getListOfRegisteredUsersWithCompletion:(void (^)(NSError *))completion;
		[Export("getListOfRegisteredUsersWithCompletion:")]
		void GetListOfRegisteredUsersWithCompletion(Action<NSError> completion);

		// -(void)fetchOnlineContactFromServer:(void (^)(NSMutableArray *, NSError *))completion;
		[Export("fetchOnlineContactFromServer:")]
		void FetchOnlineContactFromServer(Action<NSMutableArray, NSError> completion);

		// -(NSNumber *)getTotalUnreadCount;
		[Export("getTotalUnreadCount")]
		//[Verify(MethodToProperty)]
		NSNumber TotalUnreadCount { get; }

		// -(void)resettingUnreadCountWithCompletion:(void (^)(NSString *, NSError *))completion;
		[Export("resettingUnreadCountWithCompletion:")]
		void ResettingUnreadCountWithCompletion(Action<NSString, NSError> completion);

		// -(void)updateUserDisplayName:(NSString *)displayName andUserImage:(NSString *)imageLink userStatus:(NSString *)status withCompletion:(void (^)(id, NSError *))completion;
		[Export("updateUserDisplayName:andUserImage:userStatus:withCompletion:")]
		void UpdateUserDisplayName(string displayName, string imageLink, string status, Action<NSObject, NSError> completion);

		// +(void)updateUserDetail:(NSString *)userId withCompletion:(void (^)(ALUserDetail *))completionMark;
		[Static]
		[Export("updateUserDetail:withCompletion:")]
		void UpdateUserDetail(string userId, Action<ALUserDetail> completionMark);

		// -(void)fetchAndupdateUserDetails:(NSMutableArray *)userArray withCompletion:(void (^)(NSMutableArray *, NSError *))completion;
		[Export("fetchAndupdateUserDetails:withCompletion:")]
		void FetchAndupdateUserDetails(NSMutableArray userArray, Action<NSMutableArray, NSError> completion);
	}

}

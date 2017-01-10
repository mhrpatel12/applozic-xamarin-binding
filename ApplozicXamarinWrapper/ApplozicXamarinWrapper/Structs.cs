using System;

namespace ApplozicXamarinWrapper
{

	public enum ChannelType : uint
{
	Virtual = 0,
	Private = 1,
	Public = 2,
	Seller = 3,
	Self = 4,
	Broadcast = 5,
	Open = 6,
	GroupOfTwo = 7,
	BroadcastOneByOne = 106
}

public enum MessageStatus : uint
{
	Sent = 3,
	Delivered = 4,
	DeliveredAndRead = 5,
	Pending = 2,
	Unread = 0,
	Read = 1
}

public enum AppTriState
{
	Background = -1,
	Inactive = 0,
	Active = 1
}

public enum NotificationTypeMode : uint
{
	EnableSound = 0,
	DisableSound = 1,
	Enable = 0,
	Disable = 2
}

public enum PricingPackage
{
	Closed = -1,
	Beta = 0,
	Starter = 1,
	Launch = 2,
	Growth = 3,
	Enterprise = 4
}

public enum AuthenticationType : uint
{
	Client = 0,
	Applozic = 1,
	Facebook = 2
}

public enum deviceApnsType : uint
{
	Evelopment = 0,
	Istribution = 1
}

}

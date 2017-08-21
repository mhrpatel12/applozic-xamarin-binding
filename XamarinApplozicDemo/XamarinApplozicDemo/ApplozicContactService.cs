using System;
using ApplozicXamarinWrapper;
using Foundation;

namespace XamarinApplozicDemo
{
    public class ApplozicContactService
    {
        public ALContactService contactService;
       
        public ApplozicContactService()
        {
		   contactService = new ALContactService();
		}

		public void AddContact(ALContact contact)
		{
            this.contactService.AddContact(contact);

	    }

        public ALContact buildContact( String userId, 
                                      String displayName, 
                                      Int16 contactType,
                                      String PhoneNo, 
                                      String localImageResourceName, String conatctImageUrl )
		{
            
            ALContact contact = new ALContact();
            contact.UserId = userId;
            contact.DisplayName = displayName;
            contact.ContactType = contactType;
            contact.ContactNumber = PhoneNo;
            contact.LocalImageResourceName = localImageResourceName;
            contact.ContactImageUrl = conatctImageUrl;

			return contact;

	    }

	  /**
       * method you can use to build your contacts group and show same on contact list. 
       * It might be based on company, event etc. 
      */
		public void AddToMembersToContactGroupList(NSMutableArray memberArray, String contactGroupId)
		{

			short type = 9;//For public contact group
			ALChannelService.AddMemberToContactGroupOfType(contactGroupId, memberArray, type,
														   (ALAPIResponse response, NSError error) =>
														   {
															   Console.WriteLine("Working Add member to group");

														   });
		
        }


		/**
		  * Wrapper to add loginuser to a specific contact group
		  * 
		*/
		public void AddLoginUserToContactGroup(String ContactGroupId)
		{
            NSMutableArray memberArray = new NSMutableArray();
			memberArray.Add(new NSString(ALUserDefaultsHandler.UserId));
			AddToMembersToContactGroupList(memberArray,ContactGroupId);
		
        }

    }

}

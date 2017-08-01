using System;
using ApplozicXamarinWrapper;

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

    }

   


}

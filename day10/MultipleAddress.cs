using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class PersonDetails
    {
        
            List<ContactList> contactList = new List<ContactList>();
            //creating a dictonianry to add contact to specific address book
            public static Dictionary<string, List<ContactList>> addressBook = new Dictionary<string, List<ContactList>>();


            //method to take name of address book and store contact in given address book
            public  void AddToAddressBook(string addressBookName)
            {

                addressBook.Add(addressBookName, contactList);

            }
            public void AddContact()
            {
                //creating object of ContactDetails class
                ContactList contact = new ContactList();

                Console.Write("Enter First Name::");
                contact.firstName = Console.ReadLine();
                //passing contactlist and contactDetails class object to check particular contactname is present or not
                int checkfirstName = SearchDuplicate(contactList, contact);

                //if checkfirst name is 1 then firstname given by user is not already present in list
                if (checkfirstName == 1)
                {
                    Console.Write("Enter Last Name::");
                    contact.lastName = Console.ReadLine();

                    Console.Write("Enter address::");
                    contact.address = Console.ReadLine();

                    Console.Write("Enter phone number::");
                    contact.phoneNumber = Console.ReadLine();

                    Console.Write("Enter email ID::");
                    contact.email = Console.ReadLine();

                    Console.Write("Enter city Name::");
                    contact.city = Console.ReadLine();

                    Console.Write("Enter state Name::");
                    contact.state = Console.ReadLine();

                    Console.Write("Enter zip::");
                    int zip = Convert.ToInt32(Console.ReadLine());


                    //adding contact to list
                    contactList.Add(contact);
                }

            }
        //this method takes the contactlist and ContactDetails class its object as conatct book
        public static int SearchDuplicate(List<ContactList> contactList, ContactList contactBook)
        {
            foreach (var contactDetails in contactList)                     //loop to iterating through all the elements in contact list 
            {
                var person = contactList.Find(p => p.firstName.Equals(contactBook.firstName));       //using lambda checking given name is alredy present or not using equals method
                                                                                                     //if the name is not null then contact is present already
                if (person != null)
                {
                    Console.WriteLine("Already this contact exist  with current first name::" + person.firstName);
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            return 1;
        }
    }
}

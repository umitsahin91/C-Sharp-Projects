using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Contacts
{
    class ContactManager
    {
        List<Contact> contacts = new List<Contact>
            {
                new Contact
                {
                    Name="Ümit",
                    LastName="Şahin",
                    PhoneNumber="02122222222"
                },
                new Contact
                {
                    Name="Abdullah Halit",
                    LastName="Korucuoğlu",
                    PhoneNumber="02123333333"
                },
                new Contact
                {
                    Name="Onur",
                    LastName="Coşkun",
                    PhoneNumber="02124444444"
                }
            };
        

        public void Add(Contact contact)
        {
            contacts.Add(contact);
            
        }
        public void Delete(string contact)
        {
            var deleteContact = contacts.Where(x => x.Name == contact ||x.LastName==contact).FirstOrDefault();

            if (deleteContact!=null)
            {             
                contacts.Remove(deleteContact);
            }
        }
        public void Edit(string contact, string number)
        {
            var editContact = contacts.Where(x => x.Name == contact || x.LastName == contact);

            //editContact.PhoneNumber = contact;
            editContact.First().PhoneNumber = number;

        }
        public void Listing()
        {
            foreach (var item in contacts)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.PhoneNumber);
                Console.WriteLine("*****************");
            }
        
        }
        public void Listing(List<Contact> contacts)
        {
            foreach (var item in contacts)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.PhoneNumber);
                Console.WriteLine("*****************");
            }
        }

        public List<Contact> SearchByName(string contact)
        {
            return  contacts.Where(x => x.Name == contact || x.LastName == contact).ToList();

        }
        public List<Contact> SearchByPhoneNumber(string contact)
        {
            return contacts.Where(x => x.PhoneNumber == contact ).ToList();

        }

        public bool CheckContact(string contactName)
        {
            return contacts.Any(x => x.Name == contactName || x.LastName==contactName);
        }
    }
}

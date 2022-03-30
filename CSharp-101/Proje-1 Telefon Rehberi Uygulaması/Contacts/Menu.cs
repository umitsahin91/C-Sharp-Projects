using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Menu
    {
        Contact contact = new Contact();
        ContactManager contactManager = new ContactManager();
        public void MainMenu()
        {         
            bool isProcess = false;
            int process = 0;
            while (isProcess == false)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                process = int.Parse(Console.ReadLine());
                isProcess = process < 1 || process > 5 ? false : true;
                Console.Clear();
            }
            ShowMenu(process);
        }

        private void ShowMenu( int process)
        {
            switch (process)
            {
                case 1:
                    AddMenu();
                    break;
                case 2:
                    DeleteMenu();
                    break;
                case 3:
                    EditMenu();
                    break;
                case 4:
                    ListingMenu();
                    break;
                case 5:
                    SearchMenu();
                    break;
                default:
                    break;
            }
        }

        private void SearchMenu()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int result = int.Parse(Console.ReadLine());
            switch (result)
            {
                case 1:
                    Console.WriteLine("Aramak istediğiniz kişinin adını veya soyadını girin : ");
                    string resultNameLastname = Console.ReadLine();
                    List<Contact>contacts= contactManager.SearchByName(resultNameLastname);
                    contactManager.Listing(contacts);
                    MainMenu();
                    break;
                case 2:
                    Console.WriteLine("Aramak istediğiniz kişinin numarasını girin : ");
                    string resultPhonenumber = Console.ReadLine();
                    List<Contact> contactsNumbers = contactManager.SearchByPhoneNumber(resultPhonenumber);
                    contactManager.Listing(contactsNumbers);
                    MainMenu();
                    break;
                default:
                    break;
            }
        }

        private void ListingMenu()
        {
            contactManager.Listing();
            Console.WriteLine("Ana menüye dönmek için");
            Console.ReadKey();
            MainMenu();
        }

        private void EditMenu()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string editContact = Console.ReadLine();

            if (contactManager.CheckContact(editContact))
            {
                Console.Write("Yeni numarayı girin : ");
                string newContactPhoneNumber = Console.ReadLine();
                contactManager.Edit(editContact, newContactPhoneNumber);
                MainMenu();
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. ");
                Console.WriteLine("Güncelleme işlemini sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için      : (2)");
                int choosing = int.Parse(Console.ReadLine());
                 
                switch (choosing)
                {
                    case 1:
                        MainMenu();
                        break;
                    case 2:
                        EditMenu();
                        break;
                    default:
                        break;

                }
            }
        }

        private void DeleteMenu()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string deleteContact = Console.ReadLine();
            if (contactManager.CheckContact(deleteContact))
            {
                Console.WriteLine($"{deleteContact} isimli kişi rehberden silinmek üzere, onaylıyormusunuz ?(y/n)");
                string result = Console.ReadLine();
                switch (result)
                {
                    case "y":
                        contactManager.Delete(deleteContact);
                        MainMenu();
                        break;
                    case "n":
                        MainMenu();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. ");
                Console.WriteLine("Silme işlemini sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için      : (2)");
                int choosing = int.Parse(Console.ReadLine());
                switch (choosing)
                {
                    case 1:
                        MainMenu();
                        break;
                    case 2:
                        DeleteMenu();
                        break;
                    default:
                        break;

                }
            }
            
        }

        private void AddMenu()
        {         
            Console.Write("Lütfen isim giriniz :");
            contact.Name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz :");
            contact.LastName = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            contact.PhoneNumber = Console.ReadLine();
            contactManager.Add(contact);
            MainMenu();
        }
    }
}

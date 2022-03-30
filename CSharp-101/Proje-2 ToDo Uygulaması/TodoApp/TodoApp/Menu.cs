using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Menu
    {
        CardManager cardManager = new CardManager();
        PersonManager personManager = new PersonManager();
        Card card = new Card();
        public void MainMenu()
        {
            Console.Write("(1) Board Listelemek | ");
            Console.Write("(2) Board'a Kart Eklemek | ");
            Console.Write("(3) Board'dan Kart Silmek | ");
            Console.Write("(4) Kart Taşımak\n");
            Console.WriteLine("**********************************************************************************************");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :");
            string choice = Console.ReadLine();
            MainMenu(choice);

        }
        public void MainMenu(string choice)
        {
            int checkChoice;
            bool result = int.TryParse(choice, out checkChoice) && (checkChoice > 0 && checkChoice < 5);
            if (result)
            {
                SelectMenu(checkChoice);
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!!!");
                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }
        }

        private void SelectMenu(int checkChoice)
        {
            switch (checkChoice)
            {
                case 1:
                    ListMenu();
                    break;
                case 2:
                    AddMenu();
                    break;
                case 3:
                    DeleteMenu();
                    break;
                case 4:
                    EditMenu();
                    break;
                default:
                    break;
            }

        }

        private void EditMenu()
        {
            throw new NotImplementedException();
        }

        private void DeleteMenu()
        {
            throw new NotImplementedException();
        }

        private void AddMenu()
        {
            Console.Write("Başlık Giriniz                                  :");
            card.Title = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  :");
            card.Content = Console.ReadLine();

            bool resultSize;
            int checkSize;
            do
            {
                Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                string size = Console.ReadLine();
                resultSize = int.TryParse(size, out checkSize) && (checkSize > 0 && checkSize < 5);
                if (!resultSize)
                    Console.WriteLine("Lütfen geçerli büyüklük seçin!!");
                
            } while (!resultSize);
            card.Size = (Size)checkSize;

            int count=personManager.List();
            bool resultID;
            int checkID;
            do
            {
                Console.Write("Kişi Seçiniz                                    :");
                string id = Console.ReadLine();
                resultID = int.TryParse(id, out checkID) && (checkID > 0 && checkID <= count);
                if (!resultID)
                    Console.WriteLine("Lütfen geçerli kişi seçin!!");
            } while (!resultID);

            card.ResponsibleID = checkID;
            cardManager.Add(card);
            MainMenu();

        }

        private void ListMenu()
        {
            cardManager.List();
        }
    }
}

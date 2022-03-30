using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class CardManager
    {
        List<Card> cards = new List<Card> 
        {
            new Card
            {
                Title="Deneme1",
                Content="Çöpü at",
                ResponsibleID=1,
                Size=Size.XL,              
            },
            new Card
            {
                Title="Deneme2",
                Content="Yerleri sil",
                ResponsibleID=1,
                Size=Size.XL,
            },
            new Card
            {
                Title="Deneme3",
                Content="Çay demle",
                ResponsibleID=1,
                Size=Size.XL,
            }
        };
        public void Add(Card card)
        {
            cards.Add(card);
           
        }
        public void List()
        {
            Console.Clear();
            foreach (var item in cards)
            {
               
                Console.WriteLine($"Başlık      : {item.Title}");
                Console.WriteLine($"İçerik      : {item.Content}");
                Console.WriteLine($"Atanan Kişi : {item.ResponsibleID}");
                Console.WriteLine($"Büyüklük    : {item.Size}");
                Console.WriteLine();
            }
        }

        
    }
}

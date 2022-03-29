using System;

namespace DrawTriangle
{
    class Program
    {
          
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulama
            */
            Console.Write("Boyut bilgisini girin : ");
            int size=int.Parse(Console.ReadLine());
            Draw draw =new Draw();
            draw.DrawTriangle(size);
        }
    }

    /*
    Draw isimli çizim nesnesi
    */
     class Draw 
    {
        /*
        Boyut bilgisine göre eşkenar üçken çizen metot
        */
        public void DrawTriangle(int size)
        {
           

            for (int i = 0; i < size; i++)
            {
                for (int j = size; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }

    }
}

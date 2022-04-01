using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi 
             içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı
             yazınız. 
             (Array sınıfını kullanarak yazınız.)
             */
            ArrayList numArr = new ArrayList();
            numArr = EnterArrayElement();
            int smallestAverage = SmallestAverage(numArr);
            int biggestAverage = BiggestAverage(numArr);
            Console.WriteLine($"Dizinin en küçük 3 sayısının ortalaması : {smallestAverage}");
            Console.WriteLine($"Dizinin en büyük 3 sayısının ortalaması : {biggestAverage}");
            Console.WriteLine($"Dizinin en küçük 3 ve en büyük 3 sayısının ortalama toplamı : {smallestAverage+biggestAverage}");
        }

        private static int SmallestAverage(ArrayList numArr)
        {
            int average = 0;
            numArr.Sort();
            for (int i = 0; i < 3; i++)
            {
                average += (int)numArr[i];
            }

            return average / 3;
        }

        private static int BiggestAverage(ArrayList numArr)
        {
            int average = 0;
            numArr.Sort();
            numArr.Reverse();
            for (int i = 0; i < 3; i++)
            {
                average += (int)numArr[i];
            }

            return average / 3;
        }

        private static ArrayList EnterArrayElement()
        {
            ArrayList arr = new ArrayList();
            for (int i = 1; i < 21; i++)
            {

                Console.Write($"{i}. sayıyı girin : ");
                bool isNumber = CheckNum(Console.ReadLine(), out int result);
                if (isNumber && result >= 0)
                    arr.Add(result);
                else
                    i--;
            }
            Console.Clear();
            return arr;
        }
        private static bool CheckNum(string num, out int result)
        {
            return int.TryParse(num, out result);
        }
    }
}

using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            (ArrayList sınıfını kullanara yazınız.)
            -Negatif ve numeric olmayan girişleri engelleyin.
            -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
             */

            ArrayList numArr = new ArrayList();
            ArrayList primeNumArr = new ArrayList();
            ArrayList nonPrimeArr = new ArrayList();
            numArr = EnterArrayElement();
            PrimeAndNonPrimeList(numArr,ref primeNumArr,ref nonPrimeArr);
            Console.WriteLine("***ASAL SAYILARIN LİSTESİ***");
            WriteNumArr(primeNumArr);
            Console.WriteLine("***ASAL OLMAYAN SAYILARIN LİSTESİ***");
            WriteNumArr(nonPrimeArr);
            Console.WriteLine($"Asal sayılar dizisinin eleman sayısı : {primeNumArr.Count}");
            Console.WriteLine($"Asal olmayan sayılar dizisinin eleman sayısı : {nonPrimeArr.Count}");
            Console.WriteLine($"Asal sayılar dizisinin ortalaması : { NumArrayAverage(primeNumArr)}");
            Console.WriteLine($"Asal olmayan sayılar dizisinin ortalaması : { NumArrayAverage(nonPrimeArr)}");
           



        }

        private static double NumArrayAverage(ArrayList numArr)
        {
            double average = 0;
            foreach (var num in numArr)
                average += (int)num;
            return average/numArr.Count;
        }

        private static void WriteNumArr(ArrayList numArr)
        {
            numArr.Descending();
            foreach (var num in numArr)
            {
                Console.WriteLine(num);
            }
        }

        private static void PrimeAndNonPrimeList(ArrayList numArr,ref ArrayList primeNumArr,ref ArrayList nonPrimeNumArr)
        {           
            foreach (var num in numArr)
            {
                if (num.isPrime())
                    primeNumArr.Add(num);
                else
                    nonPrimeNumArr.Add(num);
            }
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

    public static class Prime
    {
        public static bool isPrime(this object number)
        {
            int num = (int)number;
            if (num == 2)
                return true;
            if (num == 1 || num % 2 == 0)
                return false;        
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static ArrayList Descending(this ArrayList arr)
        {
            arr.Sort();
            arr.Reverse();
            return arr;
        }
    }
}

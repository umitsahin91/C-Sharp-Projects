using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syste.Collections namespace
            ArrayList liste = new ArrayList();

            // liste.Add("Ayşe");
            liste.Add(2);
            // liste.Add(true);
            // liste.Add('a');

            //içerisindeki verilere erişim

            //.Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //AddRandge
            System.Console.WriteLine("***AddRange***");
            string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayılar = new List<int>() { 1, 8, 3, 7, 9, 12, 5 };
            // liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Sort
            liste.Sort();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Binary Search
            System.Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            liste.Reverse();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
            //Clear
            liste.Clear();


        }
    }
}

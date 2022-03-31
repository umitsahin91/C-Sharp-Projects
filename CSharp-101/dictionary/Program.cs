using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10, "Ayşe Yılmz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(20, "Özcan Coşar");

            //Dizinin elemanlarına erişim
            System.Console.WriteLine(kullanıcılar[12]);

            foreach (var item in kullanıcılar)
                System.Console.WriteLine(item);

            foreach (var item in kullanıcılar)
                System.Console.WriteLine(item.Key);

            foreach (var item in kullanıcılar)
                System.Console.WriteLine(item.Value);

            //Count
            System.Console.WriteLine(kullanıcılar.Count);

            //ContainsKey, ContainsValue
            System.Console.WriteLine(kullanıcılar.ContainsKey(12));
            System.Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            kullanıcılar.Remove(12);
            foreach(var item in kullanıcılar)
                System.Console.WriteLine(item);

            //Keys,Values
            foreach(var item in kullanıcılar.Keys)
                System.Console.WriteLine(item);
            foreach(var item in kullanıcılar.Values)
                System.Console.WriteLine(item);
        }
    }
}

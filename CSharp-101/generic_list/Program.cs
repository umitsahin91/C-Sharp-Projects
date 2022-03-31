using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> clas
            //System.Colection.Generic
            //T=>object türündedir
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);
            //foreach ve List.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                System.Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                System.Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                System.Console.WriteLine("10 liste içerisinde bulundu.");
            }

            //Eleman ile index'e erişmek
            System.Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e çevirmek
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //List temizlemek
            hayvanlarListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                System.Console.WriteLine("Kullanıcı Adı : " + kullanıcı.Isim);
                System.Console.WriteLine("Kullanıcı Soyadı : " + kullanıcı.Soyisim);
                System.Console.WriteLine("Kullanıcı Yaşı : " + kullanıcı.Yas);
            }

            yeniListe.Clear();
            kullanıcıListesi.ForEach(x=>System.Console.WriteLine(x.Isim));



        }
    }

    class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public int Yas { get => yas; set => yas = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Isim { get => isim; set => isim = value; }


    }
}

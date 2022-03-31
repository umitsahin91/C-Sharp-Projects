using System;

namespace hazır_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
           string degisken="Dersimiz CSharp, Hoşgeldiniz";
           string degisken2="CSharp";
           
           //Lenght;
           System.Console.WriteLine(degisken.Length);

           //ToUpper, ToLower
           System.Console.WriteLine(degisken.ToLower());
           System.Console.WriteLine(degisken.ToUpper());

           //Concat
           System.Console.WriteLine(string.Concat(degisken,"Merhaba!"));

           //Compare, CompareTo
           System.Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
           System.Console.WriteLine(string.Compare(degisken,degisken2,true));//0,1,-1
           System.Console.WriteLine(string.Compare(degisken,degisken2,false));//0,1,-1

           //Contains
           System.Console.WriteLine(degisken.Contains(degisken2));//true,false

           //EndWith, StartWith
           System.Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));//true,false
           System.Console.WriteLine(degisken.StartsWith("Merhaba!"));//true,false

           //IndexOf
           System.Console.WriteLine(degisken.IndexOf("CS"));//ilk index,-1
           System.Console.WriteLine(degisken.IndexOf("Zikriye"));

           //LastIndexOf
           System.Console.WriteLine(degisken.LastIndexOf("i"));//son index
           
           //Insert
           System.Console.WriteLine(degisken.Insert(0,"Merhaba!"));//belirtilen indexten sonrasına ekleme

           //PadLeft, PadRight
           System.Console.WriteLine(degisken+degisken2.PadLeft(30));
           System.Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
           System.Console.WriteLine(degisken.PadRight(50)+degisken2);
           System.Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

           //Remove
           System.Console.WriteLine(degisken.Remove(10));
           System.Console.WriteLine(degisken.Remove(5,3));
           System.Console.WriteLine(degisken.Remove(0,1));

           //Replace
           System.Console.WriteLine(degisken.Replace("CSharp","C#"));
           System.Console.WriteLine(degisken.Replace(" ","*"));

           //Split
           System.Console.WriteLine(degisken.Split(' ')[1]);

           //Subtring
           System.Console.WriteLine(degisken.Substring(4));
           System.Console.WriteLine(degisken.Substring(4,6));
        
        }
    }
}

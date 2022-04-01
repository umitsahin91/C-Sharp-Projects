using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve 
              dizinin elemanlarını sıralayan programı yazınız.
            */
            Console.Write("Bir cümle girin : ");
            string sentence = Console.ReadLine();
            sentence = RemoveWhiteSpace(sentence);
            string vowels = CheckVowel(sentence);
            Console.WriteLine(vowels);
            
          
            
        }

        private static string CheckVowel(string sentence)
        {
            string vowels = "aeıiuüoö";
            string vowelArr = "";
            string swap = "";

            for (int i = 0; i < vowels.Length; i++)
            {
                int index = 0;
                swap = sentence;
                while (index < sentence.Length)
                {
                    index = swap.IndexOf(vowels[i]);
                    if (index != -1)
                    {
                        vowelArr += swap[index];
                        swap = swap.Substring(index + 1);
                    }
                    else
                        break;
                }
            }
            return vowelArr;
        } 

        private static string RemoveWhiteSpace(string sentence)
        {
            string[] wordArr = sentence.Split(' ');
            sentence = string.Join("", wordArr);
            return sentence;

        }
    }
}

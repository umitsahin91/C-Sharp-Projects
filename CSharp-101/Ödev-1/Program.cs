using System;

namespace AlgoritmaSoruları
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Soru
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini //isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı 
            //girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift 
            //olanlar console'a yazdırın.


            // EnterArrayLenght(out int lenght);
            // int[] arr = EnterArrayElement(lenght);
            // WriteEvenNumber(arr); 

            #endregion

            #region 2.Soru
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            // EnterArrayLenght(out int lenght);
            // EnterDividingNumber(out int dividing);
            // EnterArrayElement(lenght,out  int[] arr );
            // WriteDividingNumber(arr,dividing);
            #endregion

            #region 3.Soru
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            // EnterArrayLenght(out int lenght);
            // EnterArrayElement(lenght, out string[] arr);
            // WriteReverseArray(arr);
            #endregion

            #region 4.Soru
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            EnterSentence(out string sentence);
            WordCounter(sentence);
            CharacterCounter(sentence);

            #endregion

        }

        private static void CharacterCounter(string sentence)
        {
                string[] arr=sentence.Split(" ");
                
             System.Console.WriteLine($"Girmiş olduğunuz cümledeki karakter sayısı : {string.Join("",arr).Length}");
        }

        private static void WordCounter(string sentence)
        {
            string[] arr = sentence.Split(" ");
            int counter = 0;
            foreach (var item in arr)
            {
                if (item == "")
                    counter++;
            }
            System.Console.WriteLine($"Girmiş olduğunuz cümledeki kelime sayısı : {arr.Length-counter}");
        }

        public static void EnterSentence(out string sentence)
        {
            System.Console.Write("Lütfen bir cümle giriniz : ");
            sentence = Console.ReadLine();
        }
        public static void WriteReverseArray(string[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(arr[i]);
            }

        }
        public static void EnterArrayLenght(out int lenght)
        {
            System.Console.Write("Dizinin uzunluğunu girin : ");
            lenght = int.Parse(Console.ReadLine());
        }
        public static void EnterDividingNumber(out int dividing)
        {
            System.Console.Write("Bölen sayıyı girin : ");
            dividing = int.Parse(Console.ReadLine());
        }
        public static void EnterArrayElement(int lenght, out int[] arr)
        {
            arr = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                System.Console.Write($"Dizinin {i + 1}. elemanını girin : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

        }
        public static void EnterArrayElement(int lenght, out string[] arr)
        {
            arr = new string[lenght];
            for (int i = 0; i < lenght; i++)
            {
                System.Console.Write($"Dizinin {i + 1}. elemanını girin : ");
                arr[i] = Console.ReadLine();
            }

        }
        public static void WriteEvenNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    System.Console.WriteLine(arr[i]);
            }
        }
        public static void WriteDividingNumber(int[] arr, int dividing)
        {
            foreach (var item in arr)
            {
                if ((item == dividing) || (item % dividing == 0))
                    System.Console.WriteLine(item);
            }
        }
    }


}

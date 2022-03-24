using System;

namespace CharacterReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.
            */
            string text;
            string[] textArr;
            do
            {
                Console.Write("Lütfen bir metin girin : ");
                text = Console.ReadLine();

                if (text.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
                else
                {
                    textArr = text.Split(" ");
                    foreach (var item in textArr)
                    {
                        if (item.Length > 0)
                        {
                            if (item.Length == 1)
                            {
                                Console.Write(item + " ");
                            }
                            else
                            {
                                Console.Write(item.Substring(1, item.Length - 1) + item[0] + " ");
                            }
                        }

                    }
                }

            } while (text.Length <= 0);


        }
    }
}

using System;

namespace struct_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.KısaKEnar = 3;
            dikdörtgen.UzunKenar = 4;
            System.Console.WriteLine("Class Alan Hesabı : {0}", dikdörtgen.AlanHesapla());


            Dikdörtgen_Struct dikdörtgen_Struct = new Dikdörtgen_Struct(3, 4);
            // Dikdörtgen_Struct dikdörtgen_Struct;
            //    dikdörtgen_Struct.KısaKEnar=3;
            //    dikdörtgen_Struct.UzunKenar=4;
            System.Console.WriteLine("Struct Alan Hesabı : {0}", dikdörtgen_Struct.AlanHesapla());

        }
    }
    class Dikdörtgen
    {
        public Dikdörtgen()
        {
            KısaKEnar = 3;
            UzunKenar = 4;
        }
        public int KısaKEnar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KısaKEnar * this.UzunKenar;
        }
    }
    struct Dikdörtgen_Struct
    {
        public int KısaKEnar;
        public int UzunKenar;

        public Dikdörtgen_Struct(int kısaKEnar, int uzunKenar)
        {
            KısaKEnar = kısaKEnar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KısaKEnar * this.UzunKenar;
        }
    }
}

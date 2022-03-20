using System;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("fibonacci series length  : ");
            int length  =Convert.ToInt32(Console.ReadLine());

            int[] fibonacciArray=FibonacciArray(length);
            double average=FibonacciAverage(fibonacciArray);
            Write(fibonacciArray,average);         
        }
        public static int[] FibonacciArray (int length)
        {
            int num1=0,num2=1,sum=0;
            int[] fib = new int[length];

            for(int i=0;i<length;i++)
            {
                num1=num2;
                num2=sum;
                sum=num1+num2;
                fib[i]=sum;
            }

            return fib;
        }

        public static double FibonacciAverage (int[] array)
        {
            double average =0;
            double sum=0;
            for(int i=0;i<array.Length;i++){
                sum+=array[i];
            }
            average=sum/array.Length;
            return average;
        }

        public static void Write (int[] array , double average)
        {
            for(int i=0;i<array.Length;i++){
                Console.Write(array[i].ToString()+" ");
                if(i==array.Length-1)
                Console.WriteLine("\n"+"------------------------------------");
            }
            Console.WriteLine($"Average of the fibonacci array : {average}");
        }

    }
   
}

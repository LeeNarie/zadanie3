using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {

        static int min(int[] mas)
        {

            int min = Math.Abs(mas[0]);
            int index = 0;

            for (int i=0;i<mas.Length;i++)
            {
                if (Math.Abs(mas[i]) < min) { min = Math.Abs(mas[i]); index = i; }
            } 

            return index;
        }

        static void unic(int[] mas)
        {

            for (int i = 0; i < mas.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < mas.Length; j++)
                {
                    if (mas[i] != mas[j])
                    {
                        k++;
                    }
                }

                if (k == mas.Length - 1)
                {
                    Console.Write(mas[i] + " ");

                }
            }
        }

        static void randotriz()
        {
            Console.WriteLine("\nМассив случайных чисел: ");
            Random rnd = new Random();
            int[] rmas = new int[10];
  
            int n = 0;
            for (int i = 0; i<10;i++)
            {
                rmas[i] = rnd.Next(-100,100);
                if (rmas[i] < 0) n++;
                Console.Write(rmas[i] + " ");
            }
            int[] newmas = new int[10-n];
            Console.WriteLine("\nМассив случайных чисел без отрицательных: ");
            int k = 0;
            for(int i = 0; i<10; i++)
            {
                if (rmas[i] >= 0) { newmas[k] = rmas[i]; k++; }
            }

            for (int i = 0; i < newmas.Length; i++)
            {
                Console.Write(newmas[i] + " ");
            }

        }

            static void Main(string[] args)
        {

            int[] mas1 = new int[10] { 5, 4, -3, -2, -11,4, -3, -2, -10, 6 };
            Console.WriteLine(min(mas1));
            unic(mas1);
            randotriz();
            Console.ReadKey();
        }
    }
}

// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System;

namespace odev
{
    class metod
    {
        public static int sırala(int[] sayilar)
        {
            int max = sayilar[0];


            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] > max)
                {
                    max = sayilar[i];
                }

            }

            return max;
            



        }

        static void Main()
        {
            
            int[] sayilar = new int[5];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0}. Sayı", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            int max = metod.sırala(sayilar);
            Console.WriteLine("En büyük sayı:"+max);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
                int[] numbers = new int[5];
                int sum = 0;

                Console.WriteLine("Lütfen 5 adet sayı giriniz:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{i + 1}. Sayıyı girin: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    sum += numbers[i];
                }

                double average = (double)sum / numbers.Length;
                Console.WriteLine($"Girilen sayıların ortalaması: {average}");
        }
    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            FactorialAsync(n);

            ulong result = 1;
            for (int i = 1; i < n+1; i++)
                result *= (ulong)i;
           
            Console.WriteLine($"Main: факториал {n} = {result}");

            Console.ReadKey();
        }

        static ulong Factorial(int n)
        {
            ulong fact = 1;
            
            for (int i = 1; i <= n; i++)
                fact *= (ulong)i;
           
            return fact;
        }

        static async void FactorialAsync(int n)
        {
            ulong factorial = await Task.Run(() => Factorial(n));
            Console.WriteLine($"FactorialAsync: Факториал {n} = {factorial}");
        }
    }
}

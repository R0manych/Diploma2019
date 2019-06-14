using Balance;
using Factorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaAppClassic
{
    class Program
    {
        static void Main(string[] args)
        {
            SolveShenks();
        }

        private static void DeterminateBalance()
        {
            Console.WriteLine("Функция: x OR y OR (NOT (x) AND NOT (y)");
            if (ClassicDeterminate.IsBalanced() == FunctionType.Balanced)
                Console.WriteLine("Функция сбалансированная");
            else
                Console.WriteLine("Функция постоянная");
            Console.WriteLine($"Количество шагов: {Math.Pow(2, FunctionUtils.N - 1) + 1}");
            Console.ReadLine();
        }

        private static void ProbabilityBalance()
        {
            Console.WriteLine("Функция: x OR y OR (NOT (x) AND NOT (y)");
            if (ClassicProbability.IsBalanced() == FunctionType.Balanced)
                Console.WriteLine("Функция сбалансированная");
            else
                Console.WriteLine("Функция постоянная");
            Console.WriteLine($"Количество шагов: {ClassicProbability.k}");
            Console.WriteLine($"Вероятность {((double)ClassicProbability.k / 3)}");
            Console.ReadLine();
        }

        private static void SolveShenks()
        {
            //var result = Shenks.Solve(22117019);
            Console.WriteLine($"Входное число: {22117019}");
            Console.WriteLine($"Результат: {4451}");
            Console.WriteLine($"Проверка: {22117019} / {4451} = {22117019 / 4451}");
            Console.WriteLine($"Количество итераций цикла 2: {8}");
            Console.ReadLine();
        }
    }
}

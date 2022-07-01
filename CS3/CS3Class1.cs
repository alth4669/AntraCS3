using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3
{
    public class CS3Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output for randomly generated array reversal:");
            int[] numbers = GenerateNumbers(10);
            Reverse(numbers);
            PrintNumbers(numbers);
            Console.WriteLine("\nOutput for first 10 numbers of Fibonacci sequence:");
            for (int i=1; i<=10; i++)
            {
                int x = Fibonacci(i);
                Console.Write($"{x} ");
            }
        }
        static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];
            for (int i=0; i<length; i++)
            {
                numbers[i] = new Random().Next(int.MinValue, int.MaxValue);
            }
            return numbers;
        }

        static void Reverse(int[] numbers)
        {
            for (int i=0; i<numbers.Length/2; i++)
            {
                int a = numbers[i];
                int b = numbers[numbers.Length - i - 1];
                numbers[i] = b;
                numbers[numbers.Length - i - 1] = a;
            }
        }

        static void PrintNumbers(int[] numbers)
        {
            Console.Write(numbers[0]);
            for (int i=1; i<numbers.Length; i++)
            {
                Console.Write($", {numbers[i]}");
            }
        }

        static int Fibonacci (int x)
        {
            if (x == 1 || x == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }
        }
    }
}

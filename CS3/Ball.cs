using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3
{
    public class Ball
    {
        static void Main(string[] args)
        {
            List<Ball> balls = new List<Ball>();
            int input;
            Console.WriteLine("How many balls do you want to create: ");
            input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                int R = new Random().Next(0, 255);
                int G = new Random().Next(0, 255);
                int B = new Random().Next(0, 255);
                int A = new Random().Next(0, 255);
                Color c = new Color(R, G, B, A);
                int size = new Random().Next(1, 10);
                Ball b = new Ball(size, c);
                balls.Add(b);
            }
            Console.WriteLine($"Throwing {input} balls around...");
            for (int i = 0; i < 10; i++)
            {
                int chosenBall = new Random().Next(0, input - 1);
                if (balls[chosenBall].Throw() == 1)
                {
                    Console.WriteLine($"Throwing ball {chosenBall}");
                }
            }
            Console.WriteLine("Popping half of the balls...");
            for (int i = 0; i < input / 2; i++)
            {
                int chosenBall = new Random().Next(0, input - 1);
                Console.WriteLine($"Ball {chosenBall} was popped.");
                balls[chosenBall].Pop();
            }
            Console.WriteLine($"Throwing {input} balls around again...");
            for (int i = 0; i < 10; i++)
            {
                int chosenBall = new Random().Next(0, input - 1);
                if (balls[chosenBall].Throw() == 1)
                {
                    Console.WriteLine($"Throwing ball {chosenBall}");
                }
                else
                {
                    Console.WriteLine($"Ball {chosenBall} was popped and couldn't be thrown");
                }
            }
            int totalThrows = 0;
            foreach (Ball b in balls)
            {
                totalThrows += b.getThrows();
            }
            Console.WriteLine($"In total, the balls were thrown {totalThrows} times");

        }
        int Size { get; set; }
        Color? Color { get; set; }
        private int Throws {get; set; }
        public void Pop()
        {
            Size = 0;
        }
        public int Throw()
        {
            if (Size == 0)
            {
                return 0;
            }
            Throws++;
            return 1;
        }
        public int getThrows()
        {
            return Throws;
        }
        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
            Throws = 0;
        }
        public Ball()
        {
            Size = 0;
            Throws = 0;
        }
    }
}

using System;

namespace Lesson_6_HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = Prompt("k1");
            int b1 = Prompt("b1");
            int k2 = Prompt("k2");
            int b2 = Prompt("b2");
            double x = X(k1, b1, k2, b2);
            double y = Y(x, k2, b2);
            Console.WriteLine("Точка пересечения находится в координате {" + x + "," + y + "}");

            int Prompt (string message)
            {
                Console.WriteLine("Введите константу " + message);
                return int.Parse(Console.ReadLine());
            }
            
            double X(int k1, int b1, int k2, int b2)
            {
                return ((b2-b1)*1.0)/(k1-k2);
            }

            double Y(double x, int k2, int b2)
            {
                return k2*x+b2;
            }
        }
    }
}

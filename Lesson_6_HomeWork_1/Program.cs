using System;

namespace Lesson_6_HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = CalcMas(ReadMas(Prompt("Введите размер массива")));
            string post = Post(result);
            Console.WriteLine("В массиве " + result + " чис" + post + " меньше нуля");
            int Prompt(string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }

            int[] ReadMas(int masLength)
            {
                int i = 0;
                int[] mas = new int[masLength];
                while (i < masLength)
                {
                    Console.WriteLine("Введите " + (i+1) + " число массива");
                    mas[i] = int.Parse(Console.ReadLine());
                    i++;
                }
                return mas;
            }

            int CalcMas (int[] mas)
            {
                int count = 0;
                int i = 0;
                while (i < mas.Length)
                {
                    if (mas[i] < 0) count++;
                    i++;
                }
                return count;
            }

            string Post(int count)
            {
                if ((count%10 == 1))
                {
                    post = "ло";
                }
                else if ((count%10 == 0) ^ (count%10 == 5) ^ (count%10 == 6) ^ (count%10 == 7) ^ (count%10 == 8) ^ (count%10 == 9))
                {
                    post = "ел";
                }
                else
                {
                   post = "ла";
                }
                return post;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    internal class Program
    {
        static void Main()
        {
            tema1();
            Console.WriteLine();
            tema2();
            Console.ReadKey();
        }
        static void tema1()
        {
            //задания на тему if...else / switch
            //1
            Console.WriteLine("Задание 1");
            Console.Write("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double result = a >= 0 ? a + 5 : a - 5;
            Console.Write("Результат: ");
            Console.WriteLine(result);
            Console.WriteLine();
            //2
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите три числа:");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Наибольшее число: ");
            if (b >= c && b >= d)
            {
                Console.WriteLine(b);
            }
            if (c >= b && c >= d)
            {
                Console.WriteLine(c);
            }
            if (d >= b && d >= c)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            //3
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите три числа:");
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма положительных чисел: ");
            if (e >= 0 && f >= 0 && g >= 0)
            {
                double sum = e + f + g;
                Console.WriteLine(sum);
            }
            if (e >= 0 && f >= 0 && g <= 0)
            {
                double sum = e + f; Console.WriteLine(sum);
            }
            if (e >= 0 && f <= 0 && g >= 0)
            {
                double sum = e + g;
                Console.WriteLine(sum);
            }
            if (e <= 0 && f >= 0 && g >= 0)
            {
                double sum = f + g; Console.WriteLine(sum);
            }
            if (e <= 0 && f >= 0 && g <= 0)
            {
                double sum = f;
                Console.WriteLine(sum);
            }
            if (e <= 0 && f <= 0 && g >= 0)
            {
                double sum = g; Console.WriteLine(sum);
            }
            if (e >= 0 && f <= 0 && g <= 0)
            {
                double sum = a; Console.WriteLine(sum);
            }
            if (e <= 0 && f <= 0 && g <= 0)
            {
                Console.WriteLine("Нет положительных чисел");
            }
            Console.WriteLine();
            //4
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число:");
            double x = Convert.ToDouble(Console.ReadLine());
            double rezult = x > 10 ? x * 2 : x;
            Console.Write("Результат: ");
            Console.WriteLine(rezult);
            Console.WriteLine();
            //5
            Console.WriteLine("Задание 5");
            Console.Write("Введите значение от 1 до 7: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("День недели: ");
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
        }
        static void tema2()
        {
            // задание на тему циклы
            //1
            Console.WriteLine("Задание 1");
            for (int i = 200; ; i++)
            {
                if (i % 17 == 0)
                {
                    Console.Write("Минимальное число: ");
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.WriteLine();
            //2
            Console.WriteLine("Задание 2");
            double s = 10;
            int r = 1;
            double km = s;
            //пробег длиной 20 км
            while (s < 20)
            {
                s = s + (s * 0.05);
                r++;
            }
            Console.WriteLine($"На {r} день пробег равен 20 км");
            //сумма пробега
            s = 10;
            r = 1;
            while (km < 100)
            {
                s = s + (s * 0.05);
                km = km + s;
                r++;
            }
            Console.WriteLine($"На {r} день сумма пробега будет больше 100 км");
            Console.WriteLine();
            //3
            Console.WriteLine("Задание 3");
            Console.Write("Задайте число факториала: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }
            int w = Factorial(n);
            Console.WriteLine($"{n}! = {w}");
            Console.WriteLine();
            //4
            Console.WriteLine("Задание 4");
            Console.Write("Введите натуральное число: ");
            uint z = Convert.ToUInt32(Console.ReadLine());
            for (int i = 2; i < z; i++)
            {
                if (z % i == 0)
                {
                    Console.Write($"Наименьший делитель {z}: ");
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}


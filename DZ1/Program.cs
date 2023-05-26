using System;

namespace DZ1
{
    class Program
    {
        static void Main()
        {
            //работа прислана не вовремя, так как меня отпросили с пары
            //1
            Console.WriteLine("Задание 1");
            string a = "Hello";
            string b = "world";
            Console.WriteLine(a + " " + b);
            Console.WriteLine(  );
            //2
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите первое значение:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе значение:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Результат сложения");
            double result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
            Console.WriteLine("Результат вычитания");
            double result1 = x - y;
            Console.WriteLine($"{x} - {y} = {result1}");
            Console.WriteLine("Результат умножения");
            double result2 = x * y;
            Console.WriteLine($"{x} * {y} = {result2}");
            Console.WriteLine("Результат деления");
            double result3 = x / y;
            Console.WriteLine($"{x} / {y} = {result3}");
            Console.WriteLine();
            //3
            Console.WriteLine("Задание 3");
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{surname} {name} {patronymic}");
            Console.WriteLine();
            //4
            Console.WriteLine("Задание 4");
            //игрок
            Console.Write("Введите значение здоровья игрока: ");
            double phealth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение урона от игрока: ");
            double pdamage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение защиты игрока: ");
            double pprotection = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            //монстр
            Console.Write("Введите значение здоровья монстра: ");
            double mhealth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение урона от монстра: ");
            double mdamage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение защиты монстра: ");
            double mprotection = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            //расчеты
            double ph = phealth - (mdamage / pprotection);
            Console.WriteLine($"Осталось здоровья у игрока: {Math.Round(ph, 2)} ");
            double mh = mhealth - (pdamage / mprotection);
            Console.WriteLine($"Осталось здоровья у монстра: {Math.Round(mh, 2)}");
            double pd = pdamage / mprotection;
            Console.WriteLine($"Урон нанесенный игроком: {Math.Round(pd, 2)}");
            double md = mdamage / pprotection;
            Console.WriteLine($"Урон нанесенный монстром: {Math.Round(md, 2)}");

            Console.ReadKey();
        }
    }
}

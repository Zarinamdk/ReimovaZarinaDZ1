using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    internal class Program
    {
        static void Main()
        {            
            List<Employee> employees = new List<Employee>()
            {
                new("Реймова Зарина Кудайбергеновна", 40000, 5),
                new("Космачев Иван Дмитриевич", 40000, 3),
                new("Уткин Геннадий Владимирович", 35000, 2),
                new("Федоров Данила Дмитриевич", 35000, 1),
                new("Кондрашов Максим Сергеевич", 30000, 2),
                new("Понкратов Никита Сергеевич", 35000, 3),
                new("Дуденков Роман Вячеславович", 25000, 4),
                new("Свотин Алексей Алексеевич", 30000, 4),
                new("Поляков Глеб Александрович", 30000, 3),
                new("Мамаев Глеб Владимирович", 50000, 1)              
            };

            PrintInfo();
            SumSalary();
            MinSalary();
            MaxSalary();
            AverageSalary();
            PrintFio();

            //задание a
            void PrintInfo()
            {
                Console.WriteLine();
                Console.WriteLine("Список информации о сотрудниках:" + "\n");
                foreach (var emp in employees)
                {
                    //Console.WriteLine($"{emp.Fio}   Зарплата: {emp.Salary}  Отдел:{emp.Department}");
                    Console.WriteLine(Employee.Id + "\t" + emp.Fio + "\t" + emp.Salary + " руб." + "\t" + emp.Department + " отдел");
                }
                Console.WriteLine();
            }
            //задание b
            void SumSalary()
            {
                double sum = 0;
                foreach (var emp in employees)
                {
                    sum += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на зарплату: {sum} руб.");
                Console.WriteLine();
            }
            //задание c
            void MinSalary()
            {
                double min = 250000;
                string minemp = "";
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                        minemp = emp.Fio;
                    }                   
                }
                Console.WriteLine($"Сотрудник с минимальной зарплатой: {minemp} ({min} руб.)");
                Console.WriteLine();
            }
            //задание d
            void MaxSalary()
            {
                double max = 0;
                string maxemp = "";
                foreach (var emp in employees)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                        maxemp = emp.Fio;
                    }
                }
                Console.WriteLine($"Сотрудник с максимальной зарплатой: {maxemp} ({max} руб.)");
                Console.WriteLine();
            }
            //задание e
            void AverageSalary()
            {
                double sum = 0;
                foreach (var emp in employees)
                {
                    sum += emp.Salary;
                }
                Console.Write("Средняя зарплата: ");
                Console.WriteLine(Math.Round((sum / employees.Count), 2) + " руб.");
                Console.WriteLine();
            }
            //задание f
            void PrintFio()
            {
                Console.WriteLine(" " + "Список сотрудников:" + "\n");
                foreach (var emp in employees)
                {
                    Console.WriteLine(" " + emp.Fio);
                }              
            }

        }
    }
}
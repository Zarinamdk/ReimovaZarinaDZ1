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
            Employee employee = new Employee();
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
                    Console.WriteLine(employee.Id + "\t" + emp.Fio + "\t" + emp.Salary + " руб." + "\t" + emp.Department + " отдел");
                }
                employee.IdR();
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
                Console.WriteLine("Список сотрудников:" + "\n");
                foreach (var emp in employees)
                {
                    Console.WriteLine(employee.Id + "\t" + emp.Fio);
                }
                employee.IdR();
                Console.WriteLine();
            }

            //блок 2
            SalaryChange();
            Departmet();
            ParamentB();
            ParamentS();
            //1
            void SalaryChange()
            {
                Console.WriteLine("Проиндексированная зарплата всех сотрудников");
                Console.Write("Введите величину аргумента: ");
                double arg = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    emp.Salary = emp.Salary + (emp.Salary * arg * 0.01);
                    Console.WriteLine(employee.Id + "\t" + emp.Fio + "\t" + emp.Salary + " руб.");
                }
                employee.IdR();
                Console.WriteLine();
            }
            //2
            void Departmet()
            {
                Console.Write("Введите название отдела: ");
                string dep = Console.ReadLine();
                Console.WriteLine();
                switch (dep)
                {
                    case "1":
                        MinSalaryDep(1);
                        MaxSalaryDep(1);
                        AverageSalaryDep(1);
                        SalaryChangeDep(1);
                        PrintFioDep(1);
                        break;

                    case "2":
                        MinSalaryDep(2);
                        MaxSalaryDep(2);
                        AverageSalaryDep(2);
                        SalaryChangeDep(2);
                        PrintFioDep(2);
                        break;

                    case "3":
                        MinSalaryDep(3);
                        MaxSalaryDep(3);
                        AverageSalaryDep(3);
                        SalaryChangeDep(3);
                        PrintFioDep(3);
                        break;

                    case "4":
                        MinSalaryDep(4);
                        MaxSalaryDep(4);
                        AverageSalaryDep(4);
                        SalaryChangeDep(4);
                        PrintFioDep(4);
                        break;

                    case "5":
                        MinSalaryDep(5);
                        MaxSalaryDep(5);
                        AverageSalaryDep(5);
                        SalaryChangeDep(5);
                        PrintFioDep(5);
                        break;
                }
                Console.WriteLine();
            }
            //Минимальная зарплата по отделу
            void MinSalaryDep(int i)
            {
                double min = 250000;
                foreach (var emp in employees)
                {
                    if (emp.Department == i)
                    {
                        if (emp.Salary < min)
                        {
                            min = emp.Salary;
                        }
                    }
                }
                foreach (var emp in employees)
                {
                    if (emp.Department == i)
                    {
                        if (emp.Salary == min)
                        {
                            Console.WriteLine("Сотрудник с минимальной зарплатой по отделу: " + emp.Fio + " (" + (min) + ")" + " руб.");
                        }
                    }
                }
            }
            //Максимальная зарплата по отделу
            void MaxSalaryDep(int i)
            {
                double max = 0;
                foreach (var emp in employees)
                {
                    if (emp.Department == i)
                    {
                        if (emp.Salary > max)
                        {
                            max = emp.Salary;
                        }
                    }
                }
                foreach (var emp in employees)
                {
                    if (emp.Department == i)
                    {
                        if (emp.Salary == max)
                        {
                            Console.WriteLine("Сотрудник с максимальной зарплатой по отделу: " + emp.Fio + " (" + (max) + ")" + " руб.");
                        }
                    }
                }
                Console.WriteLine();
            }
            //Средняя зарплата по отделу            
            void AverageSalaryDep(int i)
            {
                int p = 0;
                double sum = 0;
                foreach (var emp in employees)
                {
                    if (emp.Department == i)
                    {
                        p++;
                        sum += emp.Salary;
                    }
                }
                Console.WriteLine($"Средняя зарплата по отделу: {sum / p} руб.");
                Console.WriteLine();
            }
            //Проиндексированная зарплата сотрудников отдела
            void SalaryChangeDep(int i)
            {
                Console.WriteLine("Проиндексированная зарплата сотрудников отдела");
                Console.Write("Введите величину аргумента: ");
                double arg = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == i)
                    {
                        emp.Salary = emp.Salary + (emp.Salary * arg * 0.01);
                        Console.WriteLine(emp.Id + "\t" + emp.Fio + "\t" + emp.Salary + " руб.");
                    }
                }
                employee.IdR();
                Console.WriteLine();
            }
            //Все сотрудники отдела
            void PrintFioDep(int i)
            {
                Console.WriteLine("Все сотрудники отдела:");
                foreach (var emp in employees)
                {
                    if (emp.Department == i)
                    {
                        Console.WriteLine(emp.Id + "\t" + emp.Fio + "\t" + emp.Salary + " руб.");
                    }
                }
                employee.IdR();
            }
            //параметр            
            //1)
            void ParamentB()
            {
                Console.Write("Введите число: ");
                double sm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Сотрудники с зарплатой больше числа: ");
                foreach (var emp in employees)
                {
                    if (sm < emp.Salary)
                    {
                        Console.WriteLine(emp.Id + "\t" + emp.Fio + "\t" + "(" + (emp.Salary) + ")" + " руб.");
                    }
                    else
                    {
                        Console.WriteLine("Таковы отсутствуют");
                    }
                }
                employee.IdR();
                Console.WriteLine();
            }
            //2)
            void ParamentS()
            {
                Console.Write("Введите число: ");
                double sm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Сотрудники с зарплатой меньше числа: ");
                foreach (var emp in employees)
                {
                    if (sm >= emp.Salary)
                    {
                        Console.WriteLine(emp.Id + "\t" + emp.Fio + "\t" + "(" + (emp.Salary) + ")" + " руб.");
                    }
                    else
                    {
                        Console.WriteLine("Таковы отсутствуют");                        
                    }
                }
            }
        }
    }
}
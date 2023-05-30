using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    public class Employee
    {
        private string _fio;
        private int _salary;
        private int _department;
        static int id = 1;
        public static int Id
        {
            get => id++;
        }
        public Employee(string fio, int salary, int department)
        {

            _fio = fio;
            _salary = salary;
            _department = department;
        }
        public string Fio
        {
            get => _fio;
            set => _fio = value;
        }
        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public int Department
        {
            get => _department;
            set => _department = value;
        }     
    }
}

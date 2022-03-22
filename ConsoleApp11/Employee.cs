using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Employee : Person
    {
        private int workedDays;
        public int WorkedDays//Фактически отработанные дни
        {
            get
            {
                return workedDays;
            }
            set
            {
                if ((value < 0) || (value == 0)) throw new Exception("Сумма фактически отработанных  дней в месяце не может быть меньше или равно 0");
                workedDays = value;
            }
        }
        private int workDaysMonth;
        public int WorkDaysMonth//Количество рабочих дней в месяце
        {
            get
            {
                return workDaysMonth;
            }
            set
            {
                if ((value < 0) || (value == 0)) throw new Exception("Сумма рабочих дней в месяцу не может быть меньше или равно 0");
                workDaysMonth = value;
            }

        }
        private decimal salary;
        public decimal Salary//Оклад
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 13890) throw new Exception("Оклад не может быть меньше МРОТ");
                salary = value;
            }
        }
        public decimal MonthSalary
        {
            get
            {
                decimal a = salary / workDaysMonth * workedDays;
                return a-a*0.13m;
            }
        }
      
        public Employee (string name, int age, int salary,int workDaysMonth,int workedDays)
            : base(name, age)
        {
            Salary = salary;
            WorkDaysMonth = workDaysMonth;
            WorkedDays = workedDays;
        }
    }
}

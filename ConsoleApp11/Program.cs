using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            //Инициализация списка
            decimal result=0;
            List <Person> person= new();
            List<Client> client = new();
            List<Employee> employees = new();
            Client Tom = new ("Том",18,1000000,365);//Создаем объекты класса с помощью конструтора
            Client Mike = new ("Mike", 18, 10000000,365);
            Client John = new ("John", 42, 10000000,365);
            Employee Mikhail = new("Mikhail", 18, 35000, 26, 26);
            Employee Anatoly = new("Anatoly", 18, 45000, 26, 23);
            Employee Viktor = new("Viktor", 18, 35000, 26, 22);
            person.Add(Tom);// Присваиваем каждому из элементов массива свой объект класса
            person.Add(Mike);
            person.Add(John);
            person.Add(Anatoly);
            person.Add(Viktor);
            person.Add(Mikhail);
            //Конец инициализации списка
            for (int a=0; a < person.Count; a++) // Разделение объектов разных классов по разным массивам
            {
                if (person[a] is Client)
                {
                    client.Add((Client)person[a]);
                }
                else
                {

                    employees.Add((Employee)person[a]);
                }

            }

            //Работа с сотрудниками
            for (int e=0; e<employees.Count; e++)
            {
                Console.WriteLine($"{Decimal.Round(employees[e].MonthSalary)}");
            }


            Console.WriteLine("Нажмите любую клавишу чтобы выполнить заданную обработку персонала.Внимание-консоль очищется");
            Console.ReadKey();//Переход
            Console.Clear();


            //Работа с клиентами
            NameOut();
            for (int i=0; i<client.Count; i++)
            {
                Console.WriteLine($"{client[i].Information()}");
                Console.WriteLine($"Сумма процентов по вкладу за год у клиента Том {client[i].Percent}"); //Вывод процента по вкладам
                result += client[i].Sum;//Расчет суммы 
            }
             Console.WriteLine($"Общая сумма на счетах в банке:{result}");
            //Конец работы с клиентами



            void NameOut()
            {
                var names = from p in client select p.Name;
                foreach (string n in names)
                {
                    Console.WriteLine(n);
                }
            }
           
            
        }
       
    }
}

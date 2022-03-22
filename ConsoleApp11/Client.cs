using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
   
    
    class Client : Person
    {
        //Объявление полей класса
        readonly decimal precent = 4.5m;
        decimal sum;
        private int depositTerm;
        public int DepositTerm //Установка свойств срока вклада
        {
            get 
            {return depositTerm;}
            set
            {
                if (value < 365) throw new Exception("Срок вклада не может быть меньше 1 года ");
                depositTerm = value;
            }
        }

        public decimal Sum  //Установка свойств размера вклада, если меньше нуля выдет ошибку 
        {
            get { return sum; ;}
            set 
            {
                if (value < 0) throw new Exception("Введено отрицательное значение");
                sum = value;
            }
        }
        public decimal Percent //Возрат проценты в год
        {
            get
            {
                return (sum * precent * depositTerm / 365) / 100;
            } 
        }
        //Конец обявления полей класса


        public Client(string name,  int age, decimal sum,int depositTerm)
            : base(name, age)
        {
            Sum = sum;
            DepositTerm = depositTerm;
        ;}
        public string Information()
        {
            string str=($"Name:{Name} Age:{Age} Money:{Sum}");
            return str;
        }
        
    }
}

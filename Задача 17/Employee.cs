using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    internal class Employee<T>
    {
        public T Num { get; set; }
        
        public int Summa { get; set; }
        public string Name { get; set; }
        public string GetInfo()
        {
            return $"{Num} {Summa} {Name}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));
            Console.WriteLine("Введите баланс счета");
            Summa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            Name = Console.ReadLine();
        }
    }
}

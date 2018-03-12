using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGit
{
    class Score
    {
        public string Name { get; set; } // Наименование
        public int Numscore { get; set; } // Номер счёта 
        public double Summa { get; set; } // Сумма
        public Score()
        {
            Name = null;
            Numscore = 0;
            Summa = 0;
        }
        public Score(string name, int numscore, double summa)
        {
            Name = name;
            Numscore = numscore;
            Summa = summa;
        }
        public void Input()
        {
            Console.WriteLine("Добавление нового счёта => ");
            Console.Write("Наименование: ");
            string name = Console.ReadLine();
            Console.Write("Номер счёта: ");
            int numscore = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сумма: ");
            double summa = Convert.ToDouble(Console.ReadLine());
            Name = name;
            Numscore = numscore;
            Summa = summa;
        }
        public void Print()
        {
            Console.WriteLine("Наименование: {0}, Номер счёта: {1}, Сумма: {2}", Name, Numscore, Summa);
        }
    }
}

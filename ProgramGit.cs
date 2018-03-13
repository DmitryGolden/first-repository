using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectGit
{
    class ProgramGit
    {
         static void Main(string[] args) 
        {
            Console.Write("Введите количество счетов: ");
            int size_list = Convert.ToInt32(Console.ReadLine());
            // с помощью конструктора с параметрами создаем объект класса score_list 
            // (сразу устанавливаем емкость списка внутри класса) 
            ScoreList score_list = new ScoreList(size_list);
            // заполнение данными 
            for (int i = 0; i < size_list; i++)
            {
                score_list.AddItem();
            }
            Console.Clear();
            // используем индексатор 
            // score_list[i] - возвращает целый объект класса Score 
            // используем метод Print(), который мы реализовали в классе Score 
            // для вывода значений объекта класса 
            for (int i = 0; i < size_list; i++)
            {
                score_list[i].Print();
            }
            Console.ReadKey(); 
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGit
{
     /* Класс ScoreList внутри себя будет хранить коллекцию (список List) 
     * с объектами класса Score. 
     * Данный класс будет реализовывать интерфейс IEnumerable 
     * для перебора внутренних объектов Score в контейнере */ 
    class ScoreList : IEnumerable 
    { 
        private List<Score> score; // список с объектами класса Score 
        public int Length // свойство : количество объектов класса Score в коллекции List<T> 
        { 
            get { return score.Count; } 
        } 
        /* выделяем емкость для списка -  
         * это значит количество объектов класса Score, которые 
         * будут хранится в списке */ 
        public ScoreList(int size) 
        { 
            score = new List<Score>(size); 
        } 
        /* добавление элемента в коллекцию. 
         * мы создаем объект класса Score, затем 
         * заносим в него значения с помощью метода Input(), который 
         * мы реализовали в классе Score, 
         * а затем с помощью встроенного метода Add добавляем элемент в коллекцию; 
         * с помощью этого метода все элементы добавляются в конец очереди */ 
        public void AddItem() 
        { 
            Score item = new Score(); 
            item.Input(); 
            score.Add(item); 
        } 
        /* удаление элемента из коллекции по заданной позиции 
         * с помощью встроенного метода RemoveAt */ 
        public void RemoveItem(int pos) 
        { 
            score.RemoveAt(pos); 
        } 
        /* индексатор, по определению похож на обычное свойство класса. 
         * позволяет с помощью объекта класса ScoreList по индексу получить 
         * объект Score, который находится внутри списка. 
         * благодаря индексатору вы сможете изменить или получить значение 
         * объекта Score по индексу */ 
        public Score this[int index] 
        { 
            get { return score[index]; } 
            set { score[index] = value; } 
        } 
        /* возвращаем перечислитель. 
         * без него в Main вы не сможете с помощью цикла foreach 
         * перебирать объекты Score в списке (который находится внутри класса ScoreList) 
         * и просто так получить к ним доступ или перебирать в цикле foreach вы НЕ можете */
        IEnumerator IEnumerable.GetEnumerator()
        {
            return score.GetEnumerator();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class IdealBalanceBinaryThree<T>
    {
        static int height = 0;
        //информационное поле
        private T data;
        //ссылка на правое поддерево
        private IdealBalanceBinaryThree<T> right;
        //ссылка на левое поддерево
        private IdealBalanceBinaryThree<T> left;
        //Получение количества узлов дерева (свойство)
        public int Count
        {
            get
            {
                return SearchCount(this);
            }
            set
            {

            }
        }
        //ToString
        public override string ToString()
        {
            return data.ToString();
        }
        //дефолтный конструктор
        public IdealBalanceBinaryThree()
        {
            data = default;
            right = null;
            left = null;
        }
        //конструктор с начальным информационным полем
        public IdealBalanceBinaryThree(T FirstItem)
        {
            data = FirstItem;
            right = null;
            left = null;
        }
        //добавление элемента к конечному узлу
        public IdealBalanceBinaryThree<T> AddToSubThree(T item)
        {
            IdealBalanceBinaryThree<T> begin = this;
            IdealBalanceBinaryThree<T> temp = new IdealBalanceBinaryThree<T>(item);
                if (begin.right == null && begin.left != null)
                {
                    begin.right = temp;
                }
                else
                {
                    begin.left = temp;
                }    
            return begin;
        }
        public IdealBalanceBinaryThree<T> Add(T item)
        {
            IdealBalanceBinaryThree<T> begin = this;
            IdealBalanceBinaryThree<T> temp = begin;
            if (begin.right == null && begin.left == null)
            {
                begin.right = new IdealBalanceBinaryThree<T>(item);
                return begin;
            }
            if (begin.right == null && begin.left != null)
            {
                begin.right = new IdealBalanceBinaryThree<T>(item);
                return begin;
            }
            if (begin.right != null && begin.left == null)
            {
                begin.left = new IdealBalanceBinaryThree<T>(item);
                return begin;
            }
            if (begin.right != null && begin.left != null)
            {
                if (begin.SeachCountForRight(begin) == begin.SeachCountForLeft(begin))
                {
                    temp = begin.right;
                    temp.Add(item);
                    return begin;
                }
                if (begin.SeachCountForRight(begin) > begin.SeachCountForLeft(begin))
                {
                    temp = begin.left;
                    temp.Add(item);
                    return begin;
                }
                if (begin.SeachCountForRight(begin) < begin.SeachCountForLeft(begin))
                {
                    temp = begin.right;
                    temp.Add(item);
                    return begin;
                }
            }
            return begin;
        }
        //поиск общего количества узлов
        public int SearchCount(IdealBalanceBinaryThree<T> p)
        {
            int count = 0;
            if (p != null)
            {
                count++;
                count += SearchCount(p.left);
                count += SearchCount(p.right);
            }
            return count;
        }
        //поиск количества узлов правого поддерева
        public int SeachCountForRight(IdealBalanceBinaryThree<T> p)
        {
            int count = -1;
            if (p != null)
            {
                count++;
                count += SearchCount(p.right);
            }
            return count;
        }
        //поиск количества узлов левого поддерева
        public int SeachCountForLeft(IdealBalanceBinaryThree<T> p)
        {
            int count = -1;
            if (p != null)
            {
                count++;
                count += SearchCount(p.left);
            }
            return count;
        }
        //печать дерева
        public static void ShowTree(IdealBalanceBinaryThree<T> p)
        {
            if (p != null)
            {
                ShowTree(p.left);
                Console.WriteLine(p.data + " ");
                ShowTree(p.right);
            }
        }
        int Run(IdealBalanceBinaryThree<T> p)
        {
            if (p != null)
            {
                height++;
                Run(p.left);
                Run(p.right);
            }
            return height;
        }
        public int SearchHeight(IdealBalanceBinaryThree<T> p)
        {
            int high = 0;
            Run(p);
            high = 1 + (int)Math.Log(height, 2);
            return high;
        }
    }
}

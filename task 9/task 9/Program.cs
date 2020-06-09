using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static AnnularDoubleLinkedList<int> MainList = null;
        static int Menu()
        {
            if (MainList != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ваша коллекция:");
                Console.ResetColor();
                foreach (int s in MainList)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выберите действие: ");
            Console.ResetColor();
            Console.WriteLine("1. Создать коллекцию с заданным количеством элементов");
            Console.WriteLine("2. Добавить элемент в коллекцию");
            Console.WriteLine("3. Найти номер элемента по значению (первое вхождение)");
            Console.WriteLine("4. Получить значение элемента по номеру");
            Console.WriteLine("5. Удалить элемент");
            Console.WriteLine("6. Печать коллекции");
            Console.WriteLine("Для выхода введите 0");
            Console.Write("Ваш ответ: ");
            int choice = 0;
            bool ok = false;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out choice);
                if (!ok || choice < 0 || choice > 6)
                {
                    Console.Write("Некорректный ввод, попробуйте еще: ");
                }
            } while (!ok);
            return choice;
        }
        static void Functions(int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Введите количество элементов в коллекции: ");
                        int count = 0;
                        bool ok = false;
                        do
                        {
                            ok = int.TryParse(Console.ReadLine(), out count);
                            if (!ok || choice <= 0)
                            {
                                Console.Write("Некорректный ввод, попробуйте еще: ");
                                ok = false;
                            }
                        } while (!ok);
                        MainList = AnnularDoubleLinkedList<int>.CreateCollection(count);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Коллекция, содержащая {0} элементов успешно создана", count);
                        Console.ResetColor();
                        break;
                    }
                case 2:
                    {
                        if (MainList == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Коллекция не создана");
                            Console.ResetColor();
                        }
                        else
                        {
                            int element = 0;
                            Console.Write("Введите значение элемента (целое число): ");
                            bool ok = false;
                            do
                            {
                                ok = int.TryParse(Console.ReadLine(), out element);
                                if (!ok)
                                {
                                    Console.Write("Некорректный ввод, попробуйте еще: ");
                                }
                            } while (!ok);
                            MainList.Add(element);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Элемент {0} успешно добавлен", element);
                            Console.ResetColor();
                        }
                        break;
                    }
                case 3:
                    {
                        if (MainList == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Коллекция не создана");
                            Console.ResetColor();
                        }
                        else
                        {
                            int data = 0;
                            Console.Write("Введите значение элемента для поиска: ");
                            bool ok = false;
                            do
                            {
                                ok = int.TryParse(Console.ReadLine(), out data);
                                if (!ok)
                                {
                                    Console.Write("Некорректный ввод, попробуйте еще: ");
                                }
                            } while (!ok);
                            int index = MainList.IndexOf(data);
                            if (index >= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Элемент найден под номером {0}", index);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Элемент не найден");
                                Console.ResetColor();
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        if (MainList == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Коллекция не создана");
                            Console.ResetColor();
                        }
                        else
                        {
                            int index = 0;
                            Console.Write("Введите номер элемента: ");
                            bool ok = false;
                            do
                            {
                                ok = int.TryParse(Console.ReadLine(), out index);
                                if (!ok || index <= 0)
                                {
                                    Console.Write("Некорректный ввод, попробуйте еще: ");
                                    ok = false;
                                }
                                if (index > MainList.Count)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("Введенный номер больше количества элементов в коллекции, попробуйте еще: ");
                                    Console.ResetColor();
                                    ok = false;
                                }
                            } while (!ok);
                            int val = AnnularDoubleLinkedList<int>.Take(index, MainList);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Полученное значение по номеру - {0}", val);
                            Console.ResetColor();
                        }
                        break;
                    }
                case 5:
                    {
                        if (MainList == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Коллекция не создана");
                            Console.ResetColor();
                        }
                        else
                        {
                            int index = 0;
                            Console.Write("Введите номер элемента для удаления: ");
                            bool ok = false;
                            do
                            {
                                ok = int.TryParse(Console.ReadLine(), out index);
                                if (!ok || index <= 0)
                                {
                                    Console.Write("Некорректный ввод, попробуйте еще: ");
                                    ok = false;
                                }
                                if (index > MainList.Count)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("Введенный номер больше количества элементов в коллекции, попробуйте еще: ");
                                    Console.ResetColor();
                                    ok = false;
                                }
                            } while (!ok);
                            MainList.Remove(index);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Элемент успешно удален");
                            Console.ResetColor();
                        }
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Печать коллекции: ");
                        Console.ResetColor();
                        if (MainList == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Коллекция не создана");
                            Console.ResetColor();
                        }
                        else
                        {
                            foreach (int s in MainList)
                            {
                                Console.WriteLine(s);
                            }
                        }
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            //int z = Convert.ToInt32(Console.ReadLine());
            //AnnularDoubleLinkedList<int> list = AnnularDoubleLinkedList<int>.CreateCollection(z);
            //Console.WriteLine("Всего элементов в коллекции: {0}", list.Count);
            //Console.WriteLine("Печать коллекции");
            //foreach (int n in list)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine("Удаляем третий элемент");
            //list.Remove(3);
            //Console.WriteLine("Всего элементов в коллекции: {0}", list.Count);
            //Console.WriteLine("Печать коллекции");
            //foreach (int n in list)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine("Получаем значение элемента 5");
            //int d = AnnularDoubleLinkedList<int>.Take(5, list);
            //Console.WriteLine(d);
            //Console.WriteLine("Ищем элемент '12'");
            //Console.WriteLine("Его индекс: {0}", list.IndexOf(12));
            //Console.ReadLine();
            //=====================================================================================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Данная программа работает с кольцевым двунаправленным списком");
            Console.ResetColor();
            int choice = -1;
            do
            {
                Console.Clear();
                choice = Menu();
                if (choice == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Functions(choice);
                }
                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ReadKey();
                Console.Clear();
            } while (choice != 0);

        }
    }
}

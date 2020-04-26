using System;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#");
            Console.WriteLine("Выберите действие {1 - сортировка массива, 2 - список, 3 - дерево}");

            string val = Console.ReadLine();
            switch(val)
            {
                case "1":
                    Sort Set = new Sort();
                    Set.PrintResult();
                    break;
                case "2":
                    var List = new LinkedList<int>();
                    Console.WriteLine("Выберите действие для списка {1 - добавить, 2 - удалить, 3 - вывести итог, x - закончить}");
                    string task = Console.ReadLine();
                    int param;
                    do
                    {
                        switch(task)
                        {
                            case "1":
                                Console.Write("Введите значение нового элемента ");
                                param = Convert.ToInt32(Console.ReadLine());
                                List.Add(param);
                                break;
                            case "2":
                                Console.Write("Введите значение удаляемого элемента ");
                                param = Convert.ToInt32(Console.ReadLine());
                                List.Delete(param);
                                break;
                            case "3":
                                Console.WriteLine("Итоговый список:");
                                foreach (var item in List)
                                {
                                    Console.Write(item);
                                    Console.Write(" ");
                                }
                                Console.WriteLine();
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("Выберите действие для списка {1 - добавить, 2 - удалить, 3 - вывести итог, x - закончить}");
                        task = Console.ReadLine();
                    } while (task != "x");
                    break;
                case "3":
                    var binaryTree = new BinaryTree<int>();
                    Console.WriteLine("Выберите действие для дерева {1 - добавить, 2 - удалить, 3 - вывести итог, x - закончить}");
                    task = Console.ReadLine();
                    do
                    {
                        switch (task)
                        {
                            case "1":
                                Console.Write("Введите значение нового элемента ");
                                param = Convert.ToInt32(Console.ReadLine());
                                binaryTree.Add(param);
                                break;
                            case "2":
                                Console.Write("Введите значение удаляемого элемента ");
                                param = Convert.ToInt32(Console.ReadLine());
                                binaryTree.Remove(param);
                                break;
                            case "3":
                                Console.WriteLine("Итоговое дерево:");
                                binaryTree.PrintTree();
                                Console.WriteLine();
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("Выберите действие для списка {1 - добавить, 2 - удалить, 3 - вывести итог, x - закончить}");
                        task = Console.ReadLine();
                    } while (task != "x");
                    break;
                default:
                    break;
            }
        }
    }
}

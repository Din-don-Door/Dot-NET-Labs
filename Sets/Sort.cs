using System;
using System.Collections.Generic;
using System.Text;

namespace Sets
{
    public class Sort
    {
        public int[] InitArray()
        {
            Random rand = new Random();
            int len = rand.Next(5, 20);
            int[] array = new int[len];
            Console.WriteLine("Генерация массива");
            Console.WriteLine($"Длина: {len}");
            Console.Write("Заполнение: ");

            for (int i = 0; i < len; i++)
            {
                array[i] = rand.Next(1, 10);
                Console.Write($"{array[i]}, ");
            }

            Console.WriteLine("завершено");

            return array;
        }
        public int[] InsertionSort(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > array[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = array[i];
            }
            return result;
        }

        public void PrintResult()
        {
            int[] array = InitArray();
            int[] result = InsertionSort(array);
            Console.Write("Упорядоченный массив: ");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]}, ");
            }

            Console.WriteLine("операция завершена");

        }
    }
}

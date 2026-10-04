using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа № 9");

            // 1. Объявление и инициализация массива
            const int n = 15;                 
            double[] A = new double[n];       
            bool err;                 

            // 2. Заполнение массива с клавиатуры
            int i = 0;

            while (i < n)
            {
                err = false;  

                Console.Write("Введите " + i + " элемент массива: ");

                try
                {
                    A[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)  
                {
                    err = true;
                    Console.WriteLine("Возникла ошибка: " + e.Message);
                }

                if (!err)
                    i++; 
            }

            // 3. Подсчет количества отрицательных элементов
            int count = 0;

            for (i = 0; i < n; i++)
            {
                if (A[i] < 0)
                    count++;
            }

            // 4. Поиск минимального элемента
            int minIndex = 0;

            for (i = 1; i < n; i++)
            {
                if (A[i] < A[minIndex])
                    minIndex = i;
            }

            // 5. Вычисление суммы модулей элементов
            //    расположенных после минимального элемента
            double sum = 0;

            for (i = minIndex + 1; i < n; i++)
            {
                sum += Math.Abs(A[i]);
            }

            // 6. Вывод всех элементов массива
            Console.WriteLine("\nЭлементы массива:");

            for (i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }

            // 7. Вывод результатов
            Console.WriteLine("\n\nКоличество отрицательных элементов = " + count);
            Console.WriteLine("Минимальный элемент = " + A[minIndex]);
            Console.WriteLine("Сумма модулей элементов после минимального = " + sum);

            Console.ReadKey(); 
        }
    }
}

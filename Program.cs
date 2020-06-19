using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork8_Dz
{

    class Program
    {
        static int Del(int x, int y)
        {
            return x / y;
        }

        static void Main()
        {
            try
            {
                Console.Write("Введите x:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите y:");
                int y = int.Parse(Console.ReadLine());

                int results = Del(x, y);
                Console.WriteLine("Результат:" + results);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Деление на 0\n", e.GetType().Name, e.Message);
                Main();
            }
            // Обрабатываем исключение при неккоректном вводе числа в консоль
            catch (FormatException)
            {
                Console.WriteLine("Это НЕ число!!!\n");
                Main();
            }

            Console.ReadLine();
        }
        class ExcTest
        {

            // Сгенерировать исключение,

            public static void GenException()
            {

                int[] nums = new int[4];


                Console.WriteLine("До генерирования исключения.");

                // Сгенерировать исключение в связи с выходом

                //индекса за границы массива.

                for (int i = 0; i < 10; i++)
                {

                    nums[i] = i;

                    Console.WriteLine("nums[{0}]: {1}", i, nums[i]);

                }

                Console.WriteLine("He подлежит выводу");
                try
                {

                    ExcTest.GenException();

                }

                catch (IndexOutOfRangeException)
                {

                    // Перехватить исключение. 9

                    Console.WriteLine("Индекс вышел за границы массива!");
                }

                finally
                {
                    Console.WriteLine("Блок finally");
                }
            }

        }

    }
}
    



//******************************
//* практическая работа №9     *
//* Выполнил: Ханов Артур      *
//******************************
using System;

namespace PR_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int m = 15;
            //int[] x = new int[m] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 } ; // инициализация массива с 15 элементами
            int[] x = new int[m];
            int sum = 0, c = 1;
            Console.WriteLine("здравствуйте!");
            try
            {

                for (; ; )
                {
                    //обращения к элементам массива
                    for (int i = 0; i < m; i++)
                    {
                        x[i] = rnd.Next(m);
                        Console.WriteLine("{0} элемент массива: {1}", i, x[i]);

                        if (x[i] % 2 != 0) //проверка четности
                        {

                            if (x[i] % 3 == 0)// проверка нечетности
                            {
                                sum += x[i];
                                c *= x[i];
                                Console.WriteLine($"нечетные числа {x[i]}");
                            }

                        }

                    }

                    Console.WriteLine($"сумма нёчетных элементов, кратных 3 = {sum} ");// вывод результатов на экран
                    Console.WriteLine($"произведение нёчетных элементов, кратных 3 = {c} ");
                    Console.WriteLine("Продолжить?");
                    Console.WriteLine("Нажмите Y или N");
                    string select_key = Console.ReadLine();

                    switch (select_key)
                    {

                        case "y":
                            Console.WriteLine("Вы нажали y");
                            continue;
                        case "n":
                            Console.WriteLine("Вы нажали n");
                            Environment.Exit(0);
                            break;
                    }
                    sum = 0;
                    c = 0;
                }

            }

            catch (IndexOutOfRangeException)// вывод ошибок
            {
                Console.WriteLine("ошибка IndexOutOfRangeException");
            }
            catch (Exception e)
            {
                Console.WriteLine("что-то пошло не так " + e.Message);
            }





        }
    }
}

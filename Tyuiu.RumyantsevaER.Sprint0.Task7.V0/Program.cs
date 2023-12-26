using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RumyantsevaER.Sprint0.Task7.V0.Lib;

namespace Tyuiu.RumyantsevaER.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cпринт #0 | Выполнила: Румянцева Е.Р| ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнила: Румянцева Екатерина Родионовна | ИСПб-23-1                   *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива 1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива 2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* HTPEKMNFN:                                                               *");
            Console.WriteLine("****************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма эл массивов равна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("JIB,RF111111 HFPYJT RJKDJ 'KTVTYNJD");
            }
            Console.ReadKey();
        }
    }
}

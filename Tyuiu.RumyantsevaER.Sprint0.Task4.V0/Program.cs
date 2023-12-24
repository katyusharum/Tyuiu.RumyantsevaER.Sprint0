using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RumyantsevaER.Sprint0.Task4.V0.Lib;

namespace Tyuiu.RumyantsevaER.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            //Addition сложение, subtraction вычитание, multiplication умножение, division деление

            Console.ReadKey();
        }
    }
}

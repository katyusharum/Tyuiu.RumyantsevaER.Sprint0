﻿using System;
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
            //линейная
            Console.WriteLine("А + В = " + DataService.Addition(1, 5));
            Console.WriteLine("А - В = " + DataService.Subtraction(15, 5));
            Console.WriteLine("А * В = " + DataService.Multiplication(10, 10));
            //разветвляющаяся
            Console.WriteLine("А / В = " + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}


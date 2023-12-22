using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RumyantsevaER.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RumyantsevaER.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //Область создания методов тестирования, методов из библиотеки
            var name = "Екатерина";
            var res = DataServiceTest.GetMessage(name);

            //Вызываем класс и метод
            Assert.AreEqual("Привет..., Екатерина", res);
        }
    }
}

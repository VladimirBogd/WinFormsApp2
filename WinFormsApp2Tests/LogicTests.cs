using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void NotValidSymbols() //Содержаться неподходящие символы
        {
            string input = "12,2 ed 4";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(int.MinValue / 10, count);
        }
        [TestMethod()]
        public void EmptyInputOrSpacesTogether() //Содержаться пробелы подряд или пустая строка
        {
            string input = "12,2   3,2";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(int.MinValue / 100, count);
        }
        [TestMethod()]
        public void NotValidInputDigit() //Не удалось преобразовать в число
        {
            string input = "14,2 , 2,2";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(int.MinValue / 1000, count);
        }
        [TestMethod()]
        public void InputLessTwoDigits() //В последовательность введено менее 2 чисел
        {
            string input = "111,1";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(int.MinValue, count);
        }
        [TestMethod()]
        public void ArrayWithAllSimilarDigits() //Одинаковые числа
        {
            string input = "32,123 32,123 32,123 32,123 32,123";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(0, count);
        }
        [TestMethod()]
        public void ArrayWithoutSuchNeighbors() //В строке нет чисел, больших своих "соседей"
        {
            string input = "2,25 12,543 22,5555 32,1111 32,1111";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(0, count);
        }
        [TestMethod()]
        public void ArrayWithDifferentDigits() //В строке есть числа, большие своих "соседей"
        {
            string input = "21,123 20,234 44,345 39,456 12,567 55,678";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(3, count);
        }
        [TestMethod()]
        public void ArrayWithTwoDigitsFirstMore() //Строка с двумя числами (1-ое больше)
        {
            string input = "88,12345 77,54321";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(1, count);
        }
        [TestMethod()]
        public void ArrayWithTwoDigitsSecondMore() //Строка с двумя числами (2-ое больше)
        {
            string input = "50,6789 62,9876";

            int count = Logic.DigitsAreMore(input);
            Assert.AreEqual(1, count);
        }
    }
}
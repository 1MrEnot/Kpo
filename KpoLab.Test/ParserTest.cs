namespace KpoLab.Test
{
    using Lib.Utils;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class ParserTest
    {
        /// <summary>
        /// Проверка на корректную работу
        /// </summary>
        [TestMethod]
        public void CorrectTest()
        {
            const char splitter = '|';
            string[] rows = {
                "Win|MySql|1|2|3",
                "Unix|Sql|3|2|1",
            };

            var res = Parser.Parse(rows, splitter);
            // Должно быть ровно 2 элемента
            Assert.AreEqual(2, res.Count);

            // Значения у первого должны быть как в 1 строке
            var system1 = res[0];
            Assert.AreEqual("Win", system1.OperationSystem);
            Assert.AreEqual("MySql", system1.Database);
            Assert.AreEqual(1, system1.RamAmount);
            Assert.AreEqual(2, system1.MemoryAmount);
            Assert.AreEqual(3, system1.Cost);

            // Значения у второго должны быть как во 2 строке
            var system2 = res[1];
            Assert.AreEqual("Unix", system2.OperationSystem);
            Assert.AreEqual("Sql", system2.Database);
            Assert.AreEqual(3, system2.RamAmount);
            Assert.AreEqual(2, system2.MemoryAmount);
            Assert.AreEqual(1, system2.Cost);
        }

        /// <summary>
        /// Проверка на появление исключения <see cref="ArgumentException"/> при неверном формате файла
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailTest()
        {
            const char splitter = ',';
            string[] rows = {
                "Win|MySql|1|2|3",
                "Unix|Sql|3|2|1",
            };

            // Здесь будет исключение, так как после разбития строки ожидается, что будет 5 элементов
            // Действительно же, будет только 1 (в строке нет запятых и будет один элемент, состоящий из всё строки)
            Parser.Parse(rows, splitter);
        }
    }
}

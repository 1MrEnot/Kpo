namespace KpoLab.Test
{
    using Lib.Utils;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class ParserTest
    {
        /// <summary>
        /// �������� �� ���������� ������
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
            // ������ ���� ����� 2 ��������
            Assert.AreEqual(2, res.Count);

            // �������� � ������� ������ ���� ��� � 1 ������
            var system1 = res[0];
            Assert.AreEqual("Win", system1.OperationSystem);
            Assert.AreEqual("MySql", system1.Database);
            Assert.AreEqual(1, system1.RamAmount);
            Assert.AreEqual(2, system1.MemoryAmount);
            Assert.AreEqual(3, system1.Cost);

            // �������� � ������� ������ ���� ��� �� 2 ������
            var system2 = res[1];
            Assert.AreEqual("Unix", system2.OperationSystem);
            Assert.AreEqual("Sql", system2.Database);
            Assert.AreEqual(3, system2.RamAmount);
            Assert.AreEqual(2, system2.MemoryAmount);
            Assert.AreEqual(1, system2.Cost);
        }

        /// <summary>
        /// �������� �� ��������� ���������� <see cref="ArgumentException"/> ��� �������� ������� �����
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

            // ����� ����� ����������, ��� ��� ����� �������� ������ ���������, ��� ����� 5 ���������
            // ������������� ��, ����� ������ 1 (� ������ ��� ������� � ����� ���� �������, ��������� �� �� ������)
            Parser.Parse(rows, splitter);
        }
    }
}

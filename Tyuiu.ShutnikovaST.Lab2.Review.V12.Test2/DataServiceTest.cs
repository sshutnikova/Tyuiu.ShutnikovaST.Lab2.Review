using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShutnikovaST.Lab2.Review.V12.Lib;

namespace Tyuiu.ShutnikovaST.Lab2.Review.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            var ds = new DataService();
            int start = -5;
            int end = 5;
            double expected1 = -24.69;
            double expected2 = 39.83;
            double expected3 = 45.50;
            double expected4 = 11.29;
            double expected5 = -10.54;
            double expected6 = -1.68;
            double expected7 = 7.12;
            double expected8 = -15.28;
            double expected9 = -49.50;
            double expected10 = -43.83;
            double expected11 = 20.69;
            var result = ds.GetMassFunction(start, end);
            Assert.AreEqual(expected1, result[0], 0.01);
            Assert.AreEqual(expected2, result[1], 0.01);
            Assert.AreEqual(expected3, result[2], 0.01);
            Assert.AreEqual(expected4, result[3], 0.01);
            Assert.AreEqual(expected5, result[4], 0.01);
            Assert.AreEqual(expected6, result[5], 0.01);
            Assert.AreEqual(expected7, result[6], 0.01);
            Assert.AreEqual(expected8, result[7], 0.01);
            Assert.AreEqual(expected9, result[8], 0.01);
            Assert.AreEqual(expected10, result[9], 0.01);
            Assert.AreEqual(expected11, result[10], 0.01);
        }
    }
}
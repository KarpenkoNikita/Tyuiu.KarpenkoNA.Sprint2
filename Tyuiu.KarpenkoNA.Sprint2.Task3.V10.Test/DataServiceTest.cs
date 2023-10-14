using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint2.Task3.V10.Lib;

namespace Tyuiu.KarpenkoNA.Sprint2.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 6.333;
            Assert.AreEqual(wait, res);

        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -1;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.167;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -15;
            double res = ds.Calculate(x);
            double wait = -164.933;
            Assert.AreEqual(wait, res);
        }
    }
}

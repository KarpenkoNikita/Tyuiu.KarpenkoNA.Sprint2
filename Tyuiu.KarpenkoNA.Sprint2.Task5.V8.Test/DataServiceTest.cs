using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint2.Task5.V8.Lib;

namespace Tyuiu.KarpenkoNA.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int m = 10;
            int n = 10;
            string res = ds.FindDateOfPreviousDay(m, n);
            string wait = "10 9";
            Assert.AreEqual(wait, res);

        }
    }
}

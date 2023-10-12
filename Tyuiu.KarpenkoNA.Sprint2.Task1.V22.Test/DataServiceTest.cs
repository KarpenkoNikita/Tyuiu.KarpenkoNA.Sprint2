using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint2.Task1.V22.Lib;

namespace Tyuiu.KarpenkoNA.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, false, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

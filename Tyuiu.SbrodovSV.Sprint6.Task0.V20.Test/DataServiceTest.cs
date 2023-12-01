using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint6.Task0.V20.Lib;

namespace Tyuiu.SbrodovSV.Sprint6.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int x = 3;
            double res = dataService.Calculate(x), wait = 9.037;
            Assert.AreEqual(wait, res);
        }
    }
}

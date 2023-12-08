using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SbrodovSV.Sprint6.Task5.V7.Lib;

namespace Tyuiu.SbrodovSV.Sprint6.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V7.txt";
            double[] res = dataService.LoadFromDataFile(path);
            double[] wait = new double[res.Length];
            wait[0] = 13;
            wait[1] = 11.49;
            wait[2] = 10;
            wait[3] = 14.52;
            wait[4] = 16;
            wait[5] = 13.66;
            wait[6] = 19;
            wait[7] = 11;
            wait[8] = 11.28;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}

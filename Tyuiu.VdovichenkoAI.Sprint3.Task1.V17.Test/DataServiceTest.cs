using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VdovichenkoAI.Sprint3.Task1.V17.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 4;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 256.871;

            Assert.AreEqual(res, wait);
        }
    }
}

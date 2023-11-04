using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VdovichenkoAI.Sprint3.Task7.V6.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 22.40;
            valueWaitArray[1] = 20.22;
            valueWaitArray[2] = 14.59;
            valueWaitArray[3] = 7.21;
            valueWaitArray[4] = 1.25;
            valueWaitArray[5] = -2.50;
            valueWaitArray[6] = -6.25;
            valueWaitArray[7] = -12.21;
            valueWaitArray[8] = -19.59;
            valueWaitArray[9] = -25.22;
            valueWaitArray[10] = -27.40;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}

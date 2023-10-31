using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint3.TaskReview.V6.Lib;

namespace Tyuiu.KasenovAE.Sprint3.TaskReview.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int a = -5;
            int b = 5;

            double[] res = new double[b - a + 1];

            res[0] = 23.92;
            res[1] = 18.88;
            res[2] = 13.10;
            res[3] = 7.24;
            res[4] = 1.80;
            res[5] = -8.00;
            res[6] = -5.70;
            res[7] = -11.26;
            res[8] = -17.12;
            res[9] = -22.88;
            res[10] = -27.92;

            DataService ds = new DataService();
            CollectionAssert.AreEqual(res, ds.GetMassFunction(a, b));
        }
    }
}

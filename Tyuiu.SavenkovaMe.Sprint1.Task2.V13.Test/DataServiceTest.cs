using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaMe.Sprint1.Task2.V13.Lib;

namespace Tyuiu.SavenkovaMe.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int mil = 1;
            double res = ds.ConvertMilesToKm(mil);
            Assert.AreEqual(1.609, res);
        }
    }
}

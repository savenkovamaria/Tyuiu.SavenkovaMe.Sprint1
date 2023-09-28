using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint1.Task7.V11.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double wait = 2.751;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

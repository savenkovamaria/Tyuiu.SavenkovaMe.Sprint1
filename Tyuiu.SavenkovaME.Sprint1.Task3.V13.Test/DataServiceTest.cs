using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint1.Task3.V13.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double num = 123;
            var res = ds.MultiplyOfDigits(num);
            Assert.AreEqual(6, res);
        }
    }
}

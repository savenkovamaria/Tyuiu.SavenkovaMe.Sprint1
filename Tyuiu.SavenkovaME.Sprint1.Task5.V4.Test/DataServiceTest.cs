using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint1.Task5.V4.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int sec = 4000;
            int res = ds.SecondsToHours(sec);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}

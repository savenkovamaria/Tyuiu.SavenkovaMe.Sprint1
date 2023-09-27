using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint1.Task6.V17.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strtest = "шалаш";
            bool wait = true;
            bool res = ds.CheckPalindrome(strtest);
            Assert.AreEqual(wait, res);

        }
    }
}

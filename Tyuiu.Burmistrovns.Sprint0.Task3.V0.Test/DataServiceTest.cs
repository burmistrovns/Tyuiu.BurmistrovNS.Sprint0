using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Burmistrovns.Sprint0.Task3.V0.Lib;

namespace Tyuiu.Burmistrovns.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid1()
        {
            Assert.AreEqual(10, DataServiceTest.Sum(5, 5));
        }
    }
}

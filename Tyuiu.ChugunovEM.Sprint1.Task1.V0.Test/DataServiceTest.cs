﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using Tyuiu.ChugunovEM.Sprint1.Task1.V21.Lib;

namespace Tyuiu.ChugunovEM.Sprint1.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1, res);
        }
    }
}

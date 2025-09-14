using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KhafizovTV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KhafizovTV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Тимур";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Тимур", res);
        }
    }
}

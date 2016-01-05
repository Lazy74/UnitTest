using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void Class1Test()
        {
            Class1 p = new Class1(1, 6, 9);
            Assert.AreEqual(0, p.fn());
        }

        [TestMethod()]
        public void Class1Test1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void fnTest()
        {
            Assert.Fail();
        }
    }
}
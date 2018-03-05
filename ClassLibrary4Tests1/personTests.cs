using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.Tests
{
    [TestClass()]
    public class personTests
    {
        [TestMethod()]
        public void TestNameTest()
        {
            person p1 = new person();
            string name = p1.Getname();
            Assert.AreEqual("Murat", name);        
            ///mgskgsm
        }
    }
}
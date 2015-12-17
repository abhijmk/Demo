using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void CheckLoginSuccessTest()
        {
            var obj = new User { UserId="Abhi" , Password="Abhi" };
            var actual = obj.CheckLogin();

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckLoginFailTest()
        {
            var obj = new User { UserId = "Abh", Password = "Abhi" };
            var actual = obj.CheckLogin();

            Assert.IsFalse(actual);
        }

    }
}
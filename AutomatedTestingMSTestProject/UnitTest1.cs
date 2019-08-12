using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace AutomatedTestingMSTestProject {
    [TestClass]
    public class TestFunctions {


        Functions functions = null;

        [TestInitialize] // attributes
        public void Setup() {
            functions = new Functions();
        }

        [TestMethod]
        public void Test1() {
            var answer = functions.Add1(0);
            Assert.AreEqual(1, answer);
            answer = functions.Add1(-1);
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void TestXSquaredPlus3() {
            //test input 0
            var ans = functions.XSquaredPlus3(0);
            Assert.AreEqual(3, ans);
            //test input 3
            ans = functions.XSquaredPlus3(3);
            Assert.AreEqual(12, ans);
            //test input 2
            ans = functions.XSquaredPlus3(2);
            Assert.AreEqual(7, ans);
            //test input 23
            ans = functions.XSquaredPlus3(23);
            Assert.AreEqual(532, ans);
            //test input 100
            ans = functions.XSquaredPlus3(100);
            Assert.AreEqual(10003, ans);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestX7X12() {
            //test input 0
            var ans = functions.X7X12(0);
            Assert.AreEqual(12, ans);
            //test input 3
            ans = functions.X7X12(3);
            Assert.AreEqual(0, ans);
            //test input -3
            ans = functions.X7X12(-3);
            Assert.AreEqual(42, ans);
            //test input 4
            ans = functions.X7X12(4);
            Assert.AreEqual(0, ans);
            //test 4
            Assert.AreEqual(0, functions.X7X12(4));
        }

    }
}

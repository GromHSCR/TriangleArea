using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleLibraryUnitTests
{
    [TestClass]
    public class AreaUnitTest
    {
        [TestMethod]
        public void TestAreaResult1()
        {
            Assert.AreEqual(6,TriangleLibrary.Triangle.Area(3,4,5));
        }

        [TestMethod]
        public void TestAreaResult2()
        {
            Assert.IsTrue(double.IsNaN(TriangleLibrary.Triangle.Area(3, 3, 7)));
        }

        [TestMethod]
        public void TestAreaResult3()
        {
            Assert.IsTrue(double.IsNaN(TriangleLibrary.Triangle.Area(0, 0, 0)));
        }

        [TestMethod]
        public void TestAreaResult4()
        {
            Assert.IsTrue(double.IsNaN(TriangleLibrary.Triangle.Area(-1, -3, -5)));
        }

        [TestMethod]
        public void TestAreaResult5()
        {
            Assert.AreEqual(0.582253, TriangleLibrary.Triangle.Area(1.1, 2.1, 3.1), 0.000001);
        }

        [TestMethod]
        public void TestAreaResult6()
        {
            Assert.AreEqual(793.725393, TriangleLibrary.Triangle.Area(40, 40, 60), 0.000001);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(ArgumentNullException))]
        public void TestAreaInput1()
        {
            var result = TriangleLibrary.Triangle.Area("", "", "");
            Assert.Fail(result.ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(ArgumentNullException))]
        public void TestAreaInput2()
        {
            var result = TriangleLibrary.Triangle.Area("1", "2", "");
            Assert.Fail(result.ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void TestAreaInput3()
        {
            Assert.IsTrue(double.IsNaN(TriangleLibrary.Triangle.Area("1", "2", "3")));
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(FormatException))]
        public void TestAreaInput4()
        {
            var result = TriangleLibrary.Triangle.Area("1", "2", "a");
            Assert.Fail(result.ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void TestAreaInput5()
        {
            Assert.AreEqual(6,TriangleLibrary.Triangle.Area("4", "5", "3"));
        }
    }
}

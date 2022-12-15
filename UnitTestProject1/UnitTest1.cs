using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit1;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        [TestMethod]
        public void TestMaxRow()
        {
            Sedlo sedlo = new Sedlo(matrix);
            var test = sedlo.Max('r');
            int[] myMatrix = new int[]{ 3, 6, 9 };
            CollectionAssert.AreEqual(myMatrix, test);
        }
        [TestMethod]
        public void TestMaxCol()
        {
            Sedlo sedlo = new Sedlo(matrix);
            var test = sedlo.Max('c');
            int[] myMatrix = new int[] { 7, 8, 9 };
            CollectionAssert.AreEqual(myMatrix, test);
        }
        [TestMethod]
        public void TestMinRow()
        {
            Sedlo sedlo = new Sedlo(matrix);
            var test = sedlo.Min('r');
            int[] myMatrix = new int[] { 1, 4, 7 };
            CollectionAssert.AreEqual(myMatrix, test);
        }

        [TestMethod]
        public void TestMinCol()
        {
            Sedlo sedlo = new Sedlo(matrix);
            var test = sedlo.Min('c');
            int[] myMatrix = new int[] { 1, 2, 3 };
            CollectionAssert.AreEqual(myMatrix, test);
        }
        [TestMethod]
        public void TestMain()
        {
            using(var sw = new StringWriter())
            {
                using (var sr = new StringReader("3\n1\n2\n3\n4\n5\n6\n7\n8\n9\n"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    Program.Main();
                    var result = sw.ToString().Trim();
                    Assert.AreEqual("X-0 Y-0 Value-3\nX-2 Y-0 value-7\n", result);
                }
            }
        }
        [TestMethod]
        public void TestSedlo()
        {
            Sedlo sedlo = new Sedlo(matrix);
            List<Point> goodPoints = new List<Point>();

            goodPoints.Add(new Point(0, 2, 3));
            goodPoints.Add(new Point(2, 0, 7));
            var goodhash = goodPoints.Select(item => item.HashPoint).ToArray();
            Array.Sort(goodhash);

            var badhash = sedlo.SedloPoints.Select(item => item.HashPoint).ToArray();
            Array.Sort(badhash);

            Assert.AreEqual(true, badhash.SequenceEqual(goodhash));
        }
    }
}

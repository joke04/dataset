using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace gorina
{
    [TestClass]
    public class UnitTest1
    {
        static bool CheckMarks(string str)
        {
            string stroka = str.Trim();
            string[] array = stroka.Split(' ');
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Convert.ToDouble(array[i]) != 4 && Convert.ToDouble(array[i]) != 5)
                    k++;
            }
            if (k == 0)
                return true;
            else
                return false;
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(CheckMarks("4 5 4 4 5 5 5"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(CheckMarks("5 4 3 3 4 2"));
        }

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    Assert.IsFalse(CheckMarks("5 3 3 5 2"));
        //}

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    Assert.IsFalse(CheckMarks("2 3 3 3 2 2 3"));
        //}
    }
}

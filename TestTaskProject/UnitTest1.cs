using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskProject;
using System.IO;

namespace TestTaskProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFileCreation()
        {
            var fileName = "datetime_data.txt";
            Program.WriteTime(DateTime.Now, fileName);

            Assert.IsTrue(File.Exists(fileName));
        }

        [TestMethod]
        public void TestFileNotEmpty()
        {
            var fileName = "datetime_data.txt";
            Program.WriteTime(DateTime.Now, fileName);

            var testData = File.ReadAllText(fileName);
            Assert.IsTrue(testData.Length > 0);
        }


        [TestMethod]
        public void TestTimeCorrectness()
        {
            var fileName = "datetime_data.txt";
            Program.WriteTime(DateTime.Now, fileName);

            var testData = File.ReadAllText(fileName);

            Assert.AreEqual(testData, DateTime.Now.ToString(), "Dates are not equal");
        }
    }
}

using System.IO;
using Tyuiu.BabaiKV.Sprint5.Task4.V9.Lib;
namespace Tyuiu.BabaiKV.Sprint5.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
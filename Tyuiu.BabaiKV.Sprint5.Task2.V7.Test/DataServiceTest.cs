using System.IO;
using Tyuiu.BabaiKV.Sprint5.Task2.V7.Lib;
namespace Tyuiu.BabaiKV.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BabaiKV.Sprint5\Tyuiu.BabaiKV.Sprint5.Task2.V7\bin\Debug\net8.0\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
using System.IO;
using Tyuiu.BabaiKV.Sprint5.Task0.V27.Lib;
namespace Tyuiu.BabaiKV.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.BabaiKV.Sprint5\Tyuiu.BabaiKV.Sprint5.Task0.V27\bin\Debug\net8.0\outPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
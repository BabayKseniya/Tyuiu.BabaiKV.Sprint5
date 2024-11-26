using System.Globalization;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BabaiKV.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            string X = File.ReadAllText(path);
            double strX = double.Parse(X, CultureInfo.InvariantCulture);
            double res = Math.Round(1/(Math.Sin(Convert.ToInt32(strX))) + Math.Pow(Convert.ToInt32(strX), 2),3);
            return res;
        }
    }
}

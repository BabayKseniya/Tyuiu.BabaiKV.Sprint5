using Tyuiu.BabaiKV.Sprint5.Task4.V9.Lib;
namespace Tyuiu.BabaiKV.Sprint5.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Бабай К.В. | СМАРТб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнила: Бабай К.В.  | СМАРТб-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";
            Console.WriteLine("Данные в файле " + path);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
           
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

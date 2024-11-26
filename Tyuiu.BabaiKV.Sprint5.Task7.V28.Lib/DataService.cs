using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BabaiKV.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {
            int s = 0;//chitayu
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V28";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            bool previousWasSpace = false;
            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (char ch in line)
                    {
                        if (ch == ' ')
                        {
                            if (!previousWasSpace)
                            {
                                strLine += ' '; 
                            }
                            previousWasSpace = true;
                        }
                        else
                        {
                            strLine += ch; 
                            previousWasSpace = false;
                        }
                    }
                    File.WriteAllText(pathSaveFile, strLine);

                }
            }
            
            return pathSaveFile;

        }
    }
            
}
    


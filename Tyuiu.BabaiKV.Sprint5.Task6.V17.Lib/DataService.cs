using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BabaiKV.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            int c = 0;
            int s = 0;// podryad
            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        
                        if (line[i] == ' ')
                        {
                            s++;  
                        }
                        else
                        {
                            
                            if (s > 1)
                            {
                                c++;
                            }
                            s = 0; 
                        }
                    }
 
                }

            }
            return c;
        }
    }
}

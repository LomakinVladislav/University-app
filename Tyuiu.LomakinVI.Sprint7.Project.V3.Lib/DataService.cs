using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        public string[,] LoadFromData(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues;
        }

        public string RndFileTime()
        {
            Random rnd = new Random();
            string[] pathes = { "Time_1", "Time_2", "Time_3", "Time_4", "Time_5", "Time_6", "Time_7", "Time_8", "Time_9", "Time_10" };

            int index = rnd.Next(pathes.Length);
            int tempIndex = 0;
            while (tempIndex == index)
            {
                index = rnd.Next(pathes.Length);
            }
            tempIndex = index;
            return pathes[index];   
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.LomakinVI.Sprint7.Project.V3.Lib;

namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromData()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint7\Tyuiu.LomakinVI.Sprint7.Project.V3\bin\Debug\Files\Subjects_Math.csv";
            string[,] arrayValues = ds.LoadFromData(path);

            string[,] wait = { {"1","180","512","Математический анализ","Арясова Д. В."},
                               {"2","144","904","Алгебра и геометрия","Овчинникова С. В."},
                               {"3","108","1113","Дискретная математика","Терехова Н. В." } };

            CollectionAssert.AreEqual(wait, arrayValues);
        }

        [TestMethod]
        public void CheckFileExist()
        {
            string path = $@"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint7\Tyuiu.LomakinVI.Sprint7.Project.V3\bin\Debug\Files\Subjects_Math.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

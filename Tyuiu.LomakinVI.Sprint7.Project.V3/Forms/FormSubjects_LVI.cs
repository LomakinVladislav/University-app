using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Forms
{
    public partial class FormSubjects_LVI : Form
    {
        public FormSubjects_LVI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = 0;
            string path = $@"{Directory.GetCurrentDirectory()}\Files\Jopa.csv";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }


            /*
            StreamReader reader = null;
            if (File.Exists(path))
            {
                reader = new StreamReader(File.OpenRead(path));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                }

                reader.Close();
            }
            else
            {
                MessageBox.Show("Файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            //int[,] matrix = { { 112, 11, 11, 12 }, { 54, 23, 54, 12 } };
            int rows = numsArray.GetLength(0);
            dataGridViewSubjects.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewSubjects.Rows[i].Cells[0].Value = Convert.ToString(numsArray[i]);
            }
        }
    }
}

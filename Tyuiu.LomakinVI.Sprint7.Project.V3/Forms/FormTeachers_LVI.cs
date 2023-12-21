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
    public partial class FormTeachers_LVI : Form
    {
        public FormTeachers_LVI()
        {
            InitializeComponent();
        }

        private void buttonDone_LVI_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\Files\Teachers.csv";

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

            dataGridViewTachers_LVI.ColumnCount = columns;
            dataGridViewTachers_LVI.RowCount = rows;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewTachers_LVI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }
    }
}

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
using Tyuiu.LomakinVI.Sprint7.Project.V3.Lib;

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
            try
            {
                string path;
                DataService ds = new DataService();

                switch (comboBoxKaphedra_LVI.SelectedIndex)
                {
                    case 0:
                        path = $@"{Directory.GetCurrentDirectory()}\Files\Teachers_Sport.csv";
                        break;
                    case 1:
                        path = $@"{Directory.GetCurrentDirectory()}\Files\Teachers_MiPIT.csv";
                        break;
                    case 2:
                        path = $@"{Directory.GetCurrentDirectory()}\Files\Teachers_Gum.csv";
                        break;
                    case 3:
                        path = $@"{Directory.GetCurrentDirectory()}\Files\Teachers_All.csv";
                        break;
                    default:
                        path = $@"{Directory.GetCurrentDirectory()}\Files\Teachers_All.csv";
                        break;
                }
                string[,] arrayValues = ds.LoadFromData(path);

                int rows = arrayValues.GetLength(0);
                int columns = arrayValues.GetLength(1);

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
            catch 
            {
                MessageBox.Show("Исходный файл открыт в стороннем приложении!", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

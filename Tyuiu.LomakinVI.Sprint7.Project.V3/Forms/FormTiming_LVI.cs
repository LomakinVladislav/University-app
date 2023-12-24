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
    public partial class FormTiming_LVI : Form
    {
        public FormTiming_LVI()
        {
            InitializeComponent();
            saveFileDialogMatrix_LVI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        string[,] arrayValues;

        private void buttonDone_LVI_Click(object sender, EventArgs e)
        {

            try
            {
                string rndPath = ds.RndFileTime();
                string path = $@"{Directory.GetCurrentDirectory()}\Files\{rndPath}.csv";

                arrayValues = ds.LoadFromData(path);

                int rows = arrayValues.GetLength(0);
                int columns = arrayValues.GetLength(1);

                dataGridViewTiming_LVI.ColumnCount = columns;
                dataGridViewTiming_LVI.RowCount = rows;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewTiming_LVI.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                buttonDone_LVI.Enabled = false;
                buttonSave_LVI.Enabled = true;
            }
            catch 
            {
                MessageBox.Show("Исходный файл открыт в стороннем приложении!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxGroup_LVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDay_LVI.Text != "День" && comboBoxWeek_LVI.Text != "Неделя")
            {
                buttonDone_LVI.Enabled = true;
            }
        }

        private void comboBoxWeek_LVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDay_LVI.Text != "День" && comboBoxGroup_LVI.Text != "Группа")
            {
                buttonDone_LVI.Enabled = true;
            }
        }

        private void comboBoxDay_LVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroup_LVI.Text != "Группа" && comboBoxWeek_LVI.Text != "Неделя")
            {
                buttonDone_LVI.Enabled = true;
            }
        }

        private void buttonSave_LVI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_LVI.FileName = "Учебное_расписание.csv";
            saveFileDialogMatrix_LVI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_LVI.ShowDialog();

            string path = saveFileDialogMatrix_LVI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewTiming_LVI.RowCount;
            int columns = dataGridViewTiming_LVI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewTiming_LVI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewTiming_LVI.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.GetEncoding("Windows-1251"));
                str = "";
            }
        }
    }
}

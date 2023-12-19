using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Forms
{
    public partial class FormMap_LVI : Form
    {
        public FormMap_LVI()
        {
            InitializeComponent();
        }

        private void FormMap_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseFloor_LVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBoxChooseFloor_LVI.SelectedIndex)
            {
                case 0:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_1;
                    break;
                case 1:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_2;
                    break;
                case 2:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_3;
                    break;
                case 3:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_5;
                    break;
                case 4:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_6;
                    break;
                case 5:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_7;
                    break;
                case 6:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_8;
                    break;
                case 7:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_9;
                    break;
                case 8:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_10;
                    break;
                case 9:
                    pictureBoxFloor_LVI.ClientSize = new Size(496, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_11;
                    break;
                case 10:
                    pictureBoxFloor_LVI.ClientSize = new Size(320, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_12;
                    break;
                case 11:
                    pictureBoxFloor_LVI.ClientSize = new Size(320, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_13;
                    break;
                case 12:
                    pictureBoxFloor_LVI.ClientSize = new Size(320, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_14;
                    break;
                case 13:
                    pictureBoxFloor_LVI.ClientSize = new Size(320, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_15;
                    break;
                case 14:
                    pictureBoxFloor_LVI.ClientSize = new Size(320, 304);
                    pictureBoxFloor_LVI.Image = null;
                    pictureBoxFloor_LVI.Image = Properties.Resources.Floor_16;
                    break;
                default:
                    break;
            }
        }
    }
}

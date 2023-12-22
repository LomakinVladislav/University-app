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
    public partial class FormPhoto_LVI : Form
    {
        public FormPhoto_LVI()
        {
            InitializeComponent();
        }

        private void PictureZoom(PictureBox picture, string text)
        {
            if (picture.Image != null)
            {
                if (picture.Dock == DockStyle.Fill)
                {
                    picture.Dock = DockStyle.None;
                    textBoxDescription_LVI.Clear();
                }
                else
                {
                    picture.Dock = DockStyle.Fill;
                    textBoxDescription_LVI.Text = text;
                }
                picture.BringToFront();
            }
        }
        private void pictureBoxUpRow1_LVI_Click(object sender, EventArgs e)
        {
            PictureZoom(pictureBoxUpRow1_LVI, "Описание: 7 учебно-лабораторный корпус Тюменского индустриального университета был построен в 2016 году.");
        }

        private void pictureBoxUpRow2_LVI_Click(object sender, EventArgs e)
        {
            PictureZoom(pictureBoxUpRow2_LVI, "Описание: интерьер 7 учебно-лабораторного корпуса, 5 этаж. Ряд этажей строения посвящен нефтегазовым компаниям спонсорам. Так, на 5 этаже находится атрибутика компании \"Роснефть\".");
        }

        private void pictureBoxUpRow3_LVI_Click(object sender, EventArgs e)
        {
            PictureZoom(pictureBoxUpRow3_LVI, "Описание: строительный институт ТИУ. Находится по адресу Луначарского, 2. Строительный институт Тюменского индустриального университета был организован 01.02.2012 г. За полвека своего существования институт дал путевку в жизнь трем десяткам тысяч высококвалифицированных специалистов строительной отрасли и смежных с ней отраслей народного хозяйства, многим талантливым руководителям строительных предприятий беззаветно преданных избранной профессии, более 80 процентов выпускников университета трудится в Тюменской области.");
        }

        private void pictureBoxDownRow1_LVI_Click(object sender, EventArgs e)
        {
            PictureZoom(pictureBoxDownRow1_LVI, "Описание: здание применой комиссии находится рядом с 1 учебеным корпусом ТИУ на Володарского, 38. Здесь абитуриенты могут подать документы для зачисления в ВУЗ.");
        }

        private void pictureBoxDownRow2_LVI_Click(object sender, EventArgs e)
        {
            PictureZoom(pictureBoxDownRow2_LVI, "Описание: в Тюменском индустриальном университете обучается много иностранных студентов. Так, около тысячи студентов ТИУ родом из-за границы.");
        }

        private void pictureBoxDownRow3_LVI_Click(object sender, EventArgs e)
        {
            PictureZoom(pictureBoxDownRow3_LVI, "Описание: так выглядит комната одного из общежитий Тюменского индустриального университета.");
        }
    }
}

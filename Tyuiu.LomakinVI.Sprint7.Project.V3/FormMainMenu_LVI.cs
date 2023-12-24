using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint7.Project.V3
{
    public partial class FormMainMenu_LVI : Form
    {

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        
        //Constructor
        public FormMainMenu_LVI()
        {
            InitializeComponent();
            random = new Random();
            buttonCloseChildForm_LVI.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        
        /*
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    buttonCloseChildForm_LVI.Visible = true;
                }
            }
        }
        */

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu_LVI.Controls)
            {
                if (previousBtn.GetType() ==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane_LVI.Controls.Add(childForm);
            this.panelDesktopPane_LVI.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle_LVI.Text = childForm.Text;
        }

        private void buttonTeachers_LVI_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#5F9EA0");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar_LVI.BackColor = color;
                    panelLogo_LVI.BackColor = ColorTranslator.FromHtml("#468185");
                    buttonCloseChildForm_LVI.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormTeachers_LVI(), sender);
        }

        private void buttonSubjects_LVI_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#3548A4");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar_LVI.BackColor = color;
                    panelLogo_LVI.BackColor = ColorTranslator.FromHtml("#25347A");
                    buttonCloseChildForm_LVI.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormSubjects_LVI(), sender);
        }

        private void buttonTiming_LVI_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#A93673");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar_LVI.BackColor = color;
                    panelLogo_LVI.BackColor = ColorTranslator.FromHtml("#892D5E");
                    buttonCloseChildForm_LVI.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormTiming_LVI(), sender);
        }

        private void buttonMap_LVI_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#8949D2");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar_LVI.BackColor = color;
                    panelLogo_LVI.BackColor = ColorTranslator.FromHtml("#6C3AA5");
                    buttonCloseChildForm_LVI.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormMap_LVI(), sender);
        }

        private void buttonCloseChildForm_LVI_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            labelTitle_LVI.Text = "Университет";
            panelTitleBar_LVI.BackColor = Color.FromArgb(75, 75, 196);
            panelLogo_LVI.BackColor = Color.FromArgb(34, 34, 51);
            currentButton = null;
            buttonCloseChildForm_LVI.Visible = false;
        }

        private void panelTitleBar_LVI_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_LVI_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_LVI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_LVI_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_LVI_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonTutorial_LVI_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\Files\User's_guide.docx";
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "WINWORD.EXE";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInformation_LVI_Click(object sender, EventArgs e)
        {
            Forms.FormInformation_LVI formAbout = new Forms.FormInformation_LVI();
            formAbout.ShowDialog();
        }

        private void buttonPhotos_LVI_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#a11a10");
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar_LVI.BackColor = color;
                    panelLogo_LVI.BackColor = ColorTranslator.FromHtml("#85150d");
                    buttonCloseChildForm_LVI.Visible = true;
                }
            }

            OpenChildForm(new Forms.FormPhoto_LVI(), sender);
        }
    }
}

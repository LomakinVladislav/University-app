
namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Forms
{
    partial class FormMap_LVI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDescription_LVI = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxChooseFloor_LVI = new System.Windows.Forms.ComboBox();
            this.pictureBoxFloor_LVI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloor_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription_LVI
            // 
            this.textBoxDescription_LVI.BackColor = System.Drawing.Color.White;
            this.textBoxDescription_LVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription_LVI.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription_LVI.Location = new System.Drawing.Point(166, 25);
            this.textBoxDescription_LVI.Multiline = true;
            this.textBoxDescription_LVI.Name = "textBoxDescription_LVI";
            this.textBoxDescription_LVI.ReadOnly = true;
            this.textBoxDescription_LVI.Size = new System.Drawing.Size(421, 73);
            this.textBoxDescription_LVI.TabIndex = 0;
            this.textBoxDescription_LVI.Text = "В разделе \"Карта\" вы можете посмотреть карту всех этажей 7 корпуса и найти нужный" +
    " кабинет.\r\n\r\n";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(26, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(126, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Описание:";
            // 
            // comboBoxChooseFloor_LVI
            // 
            this.comboBoxChooseFloor_LVI.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseFloor_LVI.FormattingEnabled = true;
            this.comboBoxChooseFloor_LVI.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBoxChooseFloor_LVI.Location = new System.Drawing.Point(37, 136);
            this.comboBoxChooseFloor_LVI.Name = "comboBoxChooseFloor_LVI";
            this.comboBoxChooseFloor_LVI.Size = new System.Drawing.Size(179, 31);
            this.comboBoxChooseFloor_LVI.TabIndex = 3;
            this.comboBoxChooseFloor_LVI.Text = "Выберите этаж";
            this.comboBoxChooseFloor_LVI.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseFloor_LVI_SelectedIndexChanged);
            // 
            // pictureBoxFloor_LVI
            // 
            this.pictureBoxFloor_LVI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFloor_LVI.Location = new System.Drawing.Point(272, 136);
            this.pictureBoxFloor_LVI.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFloor_LVI.Name = "pictureBoxFloor_LVI";
            this.pictureBoxFloor_LVI.Size = new System.Drawing.Size(552, 290);
            this.pictureBoxFloor_LVI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFloor_LVI.TabIndex = 4;
            this.pictureBoxFloor_LVI.TabStop = false;
            this.pictureBoxFloor_LVI.Click += new System.EventHandler(this.pictureBoxFloor_LVI_Click);
            // 
            // FormMap_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 452);
            this.Controls.Add(this.pictureBoxFloor_LVI);
            this.Controls.Add(this.comboBoxChooseFloor_LVI);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxDescription_LVI);
            this.Name = "FormMap_LVI";
            this.Text = "Карта ТИУ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloor_LVI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription_LVI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxChooseFloor_LVI;
        private System.Windows.Forms.PictureBox pictureBoxFloor_LVI;
    }
}
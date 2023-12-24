
namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Forms
{
    partial class FormTeachers_LVI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTachers_LVI = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaphedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.comboBoxKaphedra_LVI = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTachers_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTachers_LVI
            // 
            this.dataGridViewTachers_LVI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTachers_LVI.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTachers_LVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTachers_LVI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTachers_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTachers_LVI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Kaphedra,
            this.Teacher,
            this.Subject});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTachers_LVI.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTachers_LVI.Location = new System.Drawing.Point(21, 68);
            this.dataGridViewTachers_LVI.Name = "dataGridViewTachers_LVI";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTachers_LVI.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTachers_LVI.RowHeadersVisible = false;
            this.dataGridViewTachers_LVI.RowHeadersWidth = 51;
            this.dataGridViewTachers_LVI.RowTemplate.Height = 23;
            this.dataGridViewTachers_LVI.Size = new System.Drawing.Size(632, 261);
            this.dataGridViewTachers_LVI.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 75;
            // 
            // Kaphedra
            // 
            this.Kaphedra.HeaderText = "Кафедра";
            this.Kaphedra.MinimumWidth = 6;
            this.Kaphedra.Name = "Kaphedra";
            this.Kaphedra.Width = 200;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Преподаватель";
            this.Teacher.MinimumWidth = 6;
            this.Teacher.Name = "Teacher";
            this.Teacher.Width = 200;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Дисциплина";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.Width = 125;
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonDone_LVI.FlatAppearance.BorderSize = 0;
            this.buttonDone_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_LVI.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_LVI.ForeColor = System.Drawing.Color.White;
            this.buttonDone_LVI.Location = new System.Drawing.Point(180, 22);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(107, 30);
            this.buttonDone_LVI.TabIndex = 1;
            this.buttonDone_LVI.Text = "Показать";
            this.buttonDone_LVI.UseVisualStyleBackColor = false;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            // 
            // comboBoxKaphedra_LVI
            // 
            this.comboBoxKaphedra_LVI.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKaphedra_LVI.FormattingEnabled = true;
            this.comboBoxKaphedra_LVI.Items.AddRange(new object[] {
            "Физическая культура и спорт",
            "МиПИТ",
            "Гуманитарные науки",
            "Все"});
            this.comboBoxKaphedra_LVI.Location = new System.Drawing.Point(21, 27);
            this.comboBoxKaphedra_LVI.Name = "comboBoxKaphedra_LVI";
            this.comboBoxKaphedra_LVI.Size = new System.Drawing.Size(121, 26);
            this.comboBoxKaphedra_LVI.TabIndex = 5;
            this.comboBoxKaphedra_LVI.Text = "Кафедра";
            // 
            // FormTeachers_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxKaphedra_LVI);
            this.Controls.Add(this.buttonDone_LVI);
            this.Controls.Add(this.dataGridViewTachers_LVI);
            this.Name = "FormTeachers_LVI";
            this.Text = "Преподаватели";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTachers_LVI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTachers_LVI;
        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.ComboBox comboBoxKaphedra_LVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaphedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
    }
}
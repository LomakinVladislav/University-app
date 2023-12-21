
namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Forms
{
    partial class FormSubjects_LVI
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
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Numbear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numbear,
            this.Hours,
            this.Auditory,
            this.Subject,
            this.Teacher});
            this.dataGridViewSubjects.Location = new System.Drawing.Point(13, 86);
            this.dataGridViewSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.RowHeadersVisible = false;
            this.dataGridViewSubjects.RowHeadersWidth = 51;
            this.dataGridViewSubjects.RowTemplate.Height = 23;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(908, 442);
            this.dataGridViewSubjects.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Numbear
            // 
            this.Numbear.HeaderText = "№";
            this.Numbear.MinimumWidth = 6;
            this.Numbear.Name = "Numbear";
            this.Numbear.Width = 75;
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Часы";
            this.Hours.MinimumWidth = 6;
            this.Hours.Name = "Hours";
            this.Hours.Width = 125;
            // 
            // Auditory
            // 
            this.Auditory.HeaderText = "Аудитория";
            this.Auditory.MinimumWidth = 6;
            this.Auditory.Name = "Auditory";
            this.Auditory.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Дисциплина";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.Width = 200;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Преподаватель";
            this.Teacher.MinimumWidth = 6;
            this.Teacher.Name = "Teacher";
            this.Teacher.Width = 200;
            // 
            // FormSubjects_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSubjects);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSubjects_LVI";
            this.Text = "Предметы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
    }
}
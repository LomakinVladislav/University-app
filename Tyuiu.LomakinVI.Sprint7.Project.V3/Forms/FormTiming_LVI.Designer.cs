
namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Forms
{
    partial class FormTiming_LVI
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
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.dataGridViewTachers_LVI = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTachers_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.Location = new System.Drawing.Point(68, 44);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_LVI.TabIndex = 3;
            this.buttonDone_LVI.Text = "button1";
            this.buttonDone_LVI.UseVisualStyleBackColor = true;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            // 
            // dataGridViewTachers_LVI
            // 
            this.dataGridViewTachers_LVI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTachers_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTachers_LVI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Time,
            this.Subject,
            this.Teacher,
            this.Auditory});
            this.dataGridViewTachers_LVI.Location = new System.Drawing.Point(41, 90);
            this.dataGridViewTachers_LVI.Name = "dataGridViewTachers_LVI";
            this.dataGridViewTachers_LVI.RowHeadersVisible = false;
            this.dataGridViewTachers_LVI.RowTemplate.Height = 23;
            this.dataGridViewTachers_LVI.Size = new System.Drawing.Size(722, 325);
            this.dataGridViewTachers_LVI.TabIndex = 2;
            // 
            // Number
            // 
            this.Number.HeaderText = "№ пары";
            this.Number.Name = "Number";
            this.Number.Width = 75;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            this.Subject.Width = 200;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Преподаватель";
            this.Teacher.Name = "Teacher";
            this.Teacher.Width = 200;
            // 
            // Auditory
            // 
            this.Auditory.HeaderText = "Аудитория";
            this.Auditory.Name = "Auditory";
            // 
            // FormTiming_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_LVI);
            this.Controls.Add(this.dataGridViewTachers_LVI);
            this.Name = "FormTiming_LVI";
            this.Text = "Расписание";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTachers_LVI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.DataGridView dataGridViewTachers_LVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditory;
    }
}
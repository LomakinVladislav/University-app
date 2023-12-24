
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.dataGridViewTiming_LVI = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxGroup_LVI = new System.Windows.Forms.ComboBox();
            this.comboBoxWeek_LVI = new System.Windows.Forms.ComboBox();
            this.comboBoxDay_LVI = new System.Windows.Forms.ComboBox();
            this.buttonSave_LVI = new System.Windows.Forms.Button();
            this.saveFileDialogMatrix_LVI = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTiming_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(54)))), ((int)(((byte)(115)))));
            this.buttonDone_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_LVI.Enabled = false;
            this.buttonDone_LVI.FlatAppearance.BorderSize = 0;
            this.buttonDone_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_LVI.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_LVI.ForeColor = System.Drawing.Color.White;
            this.buttonDone_LVI.Location = new System.Drawing.Point(478, 54);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(120, 29);
            this.buttonDone_LVI.TabIndex = 3;
            this.buttonDone_LVI.Text = "Показать";
            this.buttonDone_LVI.UseVisualStyleBackColor = false;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            // 
            // dataGridViewTiming_LVI
            // 
            this.dataGridViewTiming_LVI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTiming_LVI.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTiming_LVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTiming_LVI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTiming_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTiming_LVI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Time,
            this.Subject,
            this.Teacher,
            this.Auditory});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTiming_LVI.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTiming_LVI.Location = new System.Drawing.Point(25, 90);
            this.dataGridViewTiming_LVI.Name = "dataGridViewTiming_LVI";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 11.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTiming_LVI.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTiming_LVI.RowHeadersVisible = false;
            this.dataGridViewTiming_LVI.RowHeadersWidth = 51;
            this.dataGridViewTiming_LVI.RowTemplate.Height = 23;
            this.dataGridViewTiming_LVI.Size = new System.Drawing.Size(763, 325);
            this.dataGridViewTiming_LVI.TabIndex = 2;
            // 
            // Number
            // 
            this.Number.HeaderText = "№ пары";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 75;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
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
            // Auditory
            // 
            this.Auditory.HeaderText = "Аудитория";
            this.Auditory.MinimumWidth = 6;
            this.Auditory.Name = "Auditory";
            this.Auditory.Width = 125;
            // 
            // comboBoxGroup_LVI
            // 
            this.comboBoxGroup_LVI.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroup_LVI.FormattingEnabled = true;
            this.comboBoxGroup_LVI.Items.AddRange(new object[] {
            "ИИПб-23-1",
            "ИИПб-23-2",
            "ИИПб-23-3",
            "АСОУИб-23-1",
            "АСОУИб-23-2",
            "СМАРТб-23-1",
            "СМАРТб-22-1"});
            this.comboBoxGroup_LVI.Location = new System.Drawing.Point(25, 56);
            this.comboBoxGroup_LVI.Name = "comboBoxGroup_LVI";
            this.comboBoxGroup_LVI.Size = new System.Drawing.Size(121, 26);
            this.comboBoxGroup_LVI.TabIndex = 4;
            this.comboBoxGroup_LVI.Text = "Группа";
            this.comboBoxGroup_LVI.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_LVI_SelectedIndexChanged);
            // 
            // comboBoxWeek_LVI
            // 
            this.comboBoxWeek_LVI.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWeek_LVI.FormattingEnabled = true;
            this.comboBoxWeek_LVI.Items.AddRange(new object[] {
            "Чётная",
            "Нечётная"});
            this.comboBoxWeek_LVI.Location = new System.Drawing.Point(175, 56);
            this.comboBoxWeek_LVI.Name = "comboBoxWeek_LVI";
            this.comboBoxWeek_LVI.Size = new System.Drawing.Size(121, 26);
            this.comboBoxWeek_LVI.TabIndex = 4;
            this.comboBoxWeek_LVI.Text = "Неделя";
            this.comboBoxWeek_LVI.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeek_LVI_SelectedIndexChanged);
            // 
            // comboBoxDay_LVI
            // 
            this.comboBoxDay_LVI.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDay_LVI.FormattingEnabled = true;
            this.comboBoxDay_LVI.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.comboBoxDay_LVI.Location = new System.Drawing.Point(319, 56);
            this.comboBoxDay_LVI.Name = "comboBoxDay_LVI";
            this.comboBoxDay_LVI.Size = new System.Drawing.Size(121, 26);
            this.comboBoxDay_LVI.TabIndex = 4;
            this.comboBoxDay_LVI.Text = "День";
            this.comboBoxDay_LVI.SelectedIndexChanged += new System.EventHandler(this.comboBoxDay_LVI_SelectedIndexChanged);
            // 
            // buttonSave_LVI
            // 
            this.buttonSave_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(54)))), ((int)(((byte)(115)))));
            this.buttonSave_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_LVI.Enabled = false;
            this.buttonSave_LVI.FlatAppearance.BorderSize = 0;
            this.buttonSave_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_LVI.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_LVI.ForeColor = System.Drawing.Color.White;
            this.buttonSave_LVI.Location = new System.Drawing.Point(636, 54);
            this.buttonSave_LVI.Name = "buttonSave_LVI";
            this.buttonSave_LVI.Size = new System.Drawing.Size(114, 29);
            this.buttonSave_LVI.TabIndex = 5;
            this.buttonSave_LVI.Text = "Сохранить";
            this.buttonSave_LVI.UseVisualStyleBackColor = false;
            this.buttonSave_LVI.Click += new System.EventHandler(this.buttonSave_LVI_Click);
            // 
            // FormTiming_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave_LVI);
            this.Controls.Add(this.comboBoxDay_LVI);
            this.Controls.Add(this.comboBoxWeek_LVI);
            this.Controls.Add(this.comboBoxGroup_LVI);
            this.Controls.Add(this.buttonDone_LVI);
            this.Controls.Add(this.dataGridViewTiming_LVI);
            this.Name = "FormTiming_LVI";
            this.Text = "Расписание";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTiming_LVI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.DataGridView dataGridViewTiming_LVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditory;
        private System.Windows.Forms.ComboBox comboBoxGroup_LVI;
        private System.Windows.Forms.ComboBox comboBoxWeek_LVI;
        private System.Windows.Forms.ComboBox comboBoxDay_LVI;
        private System.Windows.Forms.Button buttonSave_LVI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_LVI;
    }
}
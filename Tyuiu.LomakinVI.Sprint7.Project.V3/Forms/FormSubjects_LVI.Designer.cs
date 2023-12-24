
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSubjects_LVI = new System.Windows.Forms.DataGridView();
            this.Numbear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.comboBoxChooseDirection_LVI = new System.Windows.Forms.ComboBox();
            this.labelChoose_LVI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubjects_LVI
            // 
            this.dataGridViewSubjects_LVI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubjects_LVI.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSubjects_LVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubjects_LVI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSubjects_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects_LVI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numbear,
            this.Hours,
            this.Auditory,
            this.Subject,
            this.Teacher});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubjects_LVI.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSubjects_LVI.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewSubjects_LVI.Name = "dataGridViewSubjects_LVI";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubjects_LVI.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSubjects_LVI.RowHeadersVisible = false;
            this.dataGridViewSubjects_LVI.RowHeadersWidth = 51;
            this.dataGridViewSubjects_LVI.RowTemplate.Height = 23;
            this.dataGridViewSubjects_LVI.Size = new System.Drawing.Size(776, 361);
            this.dataGridViewSubjects_LVI.TabIndex = 0;
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
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(164)))));
            this.buttonDone_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_LVI.FlatAppearance.BorderSize = 0;
            this.buttonDone_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_LVI.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_LVI.ForeColor = System.Drawing.Color.White;
            this.buttonDone_LVI.Location = new System.Drawing.Point(650, 27);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(97, 29);
            this.buttonDone_LVI.TabIndex = 4;
            this.buttonDone_LVI.Text = "Показать";
            this.buttonDone_LVI.UseVisualStyleBackColor = false;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            // 
            // comboBoxChooseDirection_LVI
            // 
            this.comboBoxChooseDirection_LVI.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseDirection_LVI.FormattingEnabled = true;
            this.comboBoxChooseDirection_LVI.Items.AddRange(new object[] {
            "Математика",
            "Информаткиа",
            "Физическая культура",
            "Гуманитарные науки",
            "Другое",
            "Все"});
            this.comboBoxChooseDirection_LVI.Location = new System.Drawing.Point(193, 29);
            this.comboBoxChooseDirection_LVI.Name = "comboBoxChooseDirection_LVI";
            this.comboBoxChooseDirection_LVI.Size = new System.Drawing.Size(103, 26);
            this.comboBoxChooseDirection_LVI.TabIndex = 5;
            this.comboBoxChooseDirection_LVI.Text = "Все";
            // 
            // labelChoose_LVI
            // 
            this.labelChoose_LVI.AutoSize = true;
            this.labelChoose_LVI.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoose_LVI.Location = new System.Drawing.Point(12, 32);
            this.labelChoose_LVI.Name = "labelChoose_LVI";
            this.labelChoose_LVI.Size = new System.Drawing.Size(155, 18);
            this.labelChoose_LVI.TabIndex = 6;
            this.labelChoose_LVI.Text = "Выберите область:";
            // 
            // FormSubjects_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChoose_LVI);
            this.Controls.Add(this.comboBoxChooseDirection_LVI);
            this.Controls.Add(this.buttonDone_LVI);
            this.Controls.Add(this.dataGridViewSubjects_LVI);
            this.Name = "FormSubjects_LVI";
            this.Text = "Предметы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects_LVI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSubjects_LVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.ComboBox comboBoxChooseDirection_LVI;
        private System.Windows.Forms.Label labelChoose_LVI;
    }
}
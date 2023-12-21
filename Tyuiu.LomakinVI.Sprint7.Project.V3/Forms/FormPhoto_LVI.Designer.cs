
namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Forms
{
    partial class FormPhoto_LVI
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
            this.panelDescription_LVI = new System.Windows.Forms.Panel();
            this.textBoxDescription_LVI = new System.Windows.Forms.TextBox();
            this.pictureBoxUpRow1_LVI = new System.Windows.Forms.PictureBox();
            this.panelDescription_LVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpRow1_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDescription_LVI
            // 
            this.panelDescription_LVI.Controls.Add(this.textBoxDescription_LVI);
            this.panelDescription_LVI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDescription_LVI.Location = new System.Drawing.Point(0, 355);
            this.panelDescription_LVI.Name = "panelDescription_LVI";
            this.panelDescription_LVI.Size = new System.Drawing.Size(800, 95);
            this.panelDescription_LVI.TabIndex = 0;
            // 
            // textBoxDescription_LVI
            // 
            this.textBoxDescription_LVI.BackColor = System.Drawing.Color.White;
            this.textBoxDescription_LVI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription_LVI.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription_LVI.Location = new System.Drawing.Point(0, 0);
            this.textBoxDescription_LVI.Multiline = true;
            this.textBoxDescription_LVI.Name = "textBoxDescription_LVI";
            this.textBoxDescription_LVI.ReadOnly = true;
            this.textBoxDescription_LVI.Size = new System.Drawing.Size(800, 95);
            this.textBoxDescription_LVI.TabIndex = 0;
            // 
            // pictureBoxUpRow1_LVI
            // 
            this.pictureBoxUpRow1_LVI.Location = new System.Drawing.Point(30, 39);
            this.pictureBoxUpRow1_LVI.Name = "pictureBoxUpRow1_LVI";
            this.pictureBoxUpRow1_LVI.Size = new System.Drawing.Size(154, 120);
            this.pictureBoxUpRow1_LVI.TabIndex = 1;
            this.pictureBoxUpRow1_LVI.TabStop = false;
            // 
            // FormPhoto_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxUpRow1_LVI);
            this.Controls.Add(this.panelDescription_LVI);
            this.Name = "FormPhoto_LVI";
            this.Text = "Фото университета";
            this.panelDescription_LVI.ResumeLayout(false);
            this.panelDescription_LVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpRow1_LVI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDescription_LVI;
        private System.Windows.Forms.TextBox textBoxDescription_LVI;
        private System.Windows.Forms.PictureBox pictureBoxUpRow1_LVI;
    }
}
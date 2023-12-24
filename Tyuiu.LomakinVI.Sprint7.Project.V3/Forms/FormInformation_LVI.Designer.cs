
namespace Tyuiu.LomakinVI.Sprint7.Project.V3.Forms
{
    partial class FormInformation_LVI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation_LVI));
            this.buttonOk_LVI = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_LVI = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_LVI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_LVI
            // 
            this.buttonOk_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.buttonOk_LVI.FlatAppearance.BorderSize = 0;
            this.buttonOk_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_LVI.ForeColor = System.Drawing.Color.White;
            this.buttonOk_LVI.Location = new System.Drawing.Point(637, 389);
            this.buttonOk_LVI.Name = "buttonOk_LVI";
            this.buttonOk_LVI.Size = new System.Drawing.Size(93, 32);
            this.buttonOk_LVI.TabIndex = 0;
            this.buttonOk_LVI.Text = "OK";
            this.buttonOk_LVI.UseVisualStyleBackColor = false;
            this.buttonOk_LVI.Click += new System.EventHandler(this.buttonOk_LVI_Click);
            // 
            // pictureBoxAvatar_LVI
            // 
            this.pictureBoxAvatar_LVI.Image = global::Tyuiu.LomakinVI.Sprint7.Project.V3.Properties.Resources.Shuba_Kak_Y_Ryana_Goslinga;
            this.pictureBoxAvatar_LVI.Location = new System.Drawing.Point(22, 27);
            this.pictureBoxAvatar_LVI.Name = "pictureBoxAvatar_LVI";
            this.pictureBoxAvatar_LVI.Size = new System.Drawing.Size(274, 379);
            this.pictureBoxAvatar_LVI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_LVI.TabIndex = 1;
            this.pictureBoxAvatar_LVI.TabStop = false;
            // 
            // textBoxInfo_LVI
            // 
            this.textBoxInfo_LVI.BackColor = System.Drawing.Color.White;
            this.textBoxInfo_LVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_LVI.Location = new System.Drawing.Point(316, 27);
            this.textBoxInfo_LVI.Multiline = true;
            this.textBoxInfo_LVI.Name = "textBoxInfo_LVI";
            this.textBoxInfo_LVI.ReadOnly = true;
            this.textBoxInfo_LVI.Size = new System.Drawing.Size(414, 319);
            this.textBoxInfo_LVI.TabIndex = 2;
            this.textBoxInfo_LVI.Text = resources.GetString("textBoxInfo_LVI.Text");
            // 
            // FormInformation_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 433);
            this.Controls.Add(this.textBoxInfo_LVI);
            this.Controls.Add(this.pictureBoxAvatar_LVI);
            this.Controls.Add(this.buttonOk_LVI);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "FormInformation_LVI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения о программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LVI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_LVI;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_LVI;
        private System.Windows.Forms.TextBox textBoxInfo_LVI;
    }
}
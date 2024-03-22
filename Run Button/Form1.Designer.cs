

namespace Run_Button
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox = new CheckBox();
            btnRun = new Button();
            SuspendLayout();
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(12, 12);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(62, 24);
            checkBox.TabIndex = 0;
            checkBox.Text = "Start";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.Red;
            btnRun.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRun.ForeColor = Color.Black;
            btnRun.Location = new Point(126, 70);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(172, 64);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run Button";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.MouseEnter += btnRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(btnRun);
            Controls.Add(checkBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private CheckBox checkBox;
        private Button btnRun;
    }
}

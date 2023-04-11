namespace lab6
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
            firstNumberTextBox = new TextBox();
            secondNumberTextBox = new TextBox();
            sumNumberTextBox = new TextBox();
            exitbutton = new Button();
            clearbutton = new Button();
            plusbutton = new Button();
            SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            firstNumberTextBox.Location = new Point(28, 32);
            firstNumberTextBox.Name = "firstNumberTextBox";
            firstNumberTextBox.Size = new Size(356, 23);
            firstNumberTextBox.TabIndex = 0;
            // 
            // secondNumberTextBox
            // 
            secondNumberTextBox.Location = new Point(28, 78);
            secondNumberTextBox.Name = "secondNumberTextBox";
            secondNumberTextBox.Size = new Size(356, 23);
            secondNumberTextBox.TabIndex = 1;
            // 
            // sumNumberTextBox
            // 
            sumNumberTextBox.Location = new Point(28, 180);
            sumNumberTextBox.Name = "sumNumberTextBox";
            sumNumberTextBox.Size = new Size(356, 23);
            sumNumberTextBox.TabIndex = 2;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(284, 219);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(100, 35);
            exitbutton.TabIndex = 3;
            exitbutton.Text = "Вихід";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(28, 219);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(100, 35);
            clearbutton.TabIndex = 4;
            clearbutton.Text = "Очистити";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // plusbutton
            // 
            plusbutton.Location = new Point(165, 121);
            plusbutton.Name = "plusbutton";
            plusbutton.Size = new Size(75, 35);
            plusbutton.TabIndex = 5;
            plusbutton.Text = "+";
            plusbutton.UseVisualStyleBackColor = true;
            plusbutton.TextChanged += firstNumberTextBox_TextChanged;
            plusbutton.Click += plusbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 278);
            Controls.Add(plusbutton);
            Controls.Add(clearbutton);
            Controls.Add(exitbutton);
            Controls.Add(sumNumberTextBox);
            Controls.Add(secondNumberTextBox);
            Controls.Add(firstNumberTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNumberTextBox;
        private TextBox secondNumberTextBox;
        private TextBox sumNumberTextBox;
        private Button exitbutton;
        private Button clearbutton;
        private Button plusbutton;
    }
}
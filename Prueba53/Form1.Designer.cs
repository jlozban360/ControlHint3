﻿namespace Prueba53
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
            textBoxHint1 = new ControlHint3.TextBoxHint();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBoxHint1
            // 
            textBoxHint1.ForeColor = Color.Gray;
            textBoxHint1.Hint = "HOLHOLAHOLA";
            textBoxHint1.Location = new Point(81, 87);
            textBoxHint1.Name = "textBoxHint1";
            textBoxHint1.Size = new Size(455, 23);
            textBoxHint1.TabIndex = 0;
            textBoxHint1.Text = "HOLHOLAHOLA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(455, 23);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textBoxHint1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ControlHint3.TextBoxHint textBoxHint1;
        private TextBox textBox1;
    }
}

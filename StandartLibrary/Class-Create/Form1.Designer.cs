﻿
namespace Class_Create
{
    partial class Form1
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 22);
            this.textBox3.TabIndex = 24;
            this.textBox3.Text = "-";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Result :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 22);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "-";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pass :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Text :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "Solve";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Encrypt";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 126);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
    }
}


﻿
namespace _180IQ_Solver
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
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SolutionShowTextBox = new System.Windows.Forms.TextBox();
            this.NumAnsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(423, 81);
            this.QuestionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(249, 22);
            this.QuestionTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(423, 113);
            this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(249, 22);
            this.AnswerTextBox.TabIndex = 2;
            this.AnswerTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculate_solution);
            // 
            // SolutionShowTextBox
            // 
            this.SolutionShowTextBox.Location = new System.Drawing.Point(352, 248);
            this.SolutionShowTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SolutionShowTextBox.Multiline = true;
            this.SolutionShowTextBox.Name = "SolutionShowTextBox";
            this.SolutionShowTextBox.Size = new System.Drawing.Size(319, 123);
            this.SolutionShowTextBox.TabIndex = 5;
            // 
            // NumAnsTextBox
            // 
            this.NumAnsTextBox.Location = new System.Drawing.Point(427, 154);
            this.NumAnsTextBox.Name = "NumAnsTextBox";
            this.NumAnsTextBox.Size = new System.Drawing.Size(244, 22);
            this.NumAnsTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "NumAns";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumAnsTextBox);
            this.Controls.Add(this.SolutionShowTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SolutionShowTextBox;
        private System.Windows.Forms.TextBox NumAnsTextBox;
        private System.Windows.Forms.Label label3;
    }
}


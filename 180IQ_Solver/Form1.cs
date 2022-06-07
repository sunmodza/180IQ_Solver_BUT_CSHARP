using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180IQ_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculate_solution(object sender, EventArgs e)
        {
            String question = QuestionTextBox.Text;
            String Answer = AnswerTextBox.Text;
            int NumAns = Int32.Parse(NumAnsTextBox.Text);
            SolutionShowTextBox.Text = "";
            Console.WriteLine(Answer);

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "auto_180iq_lib.exe",
                    Arguments = String.Format("-q \"{0}\" -a {1} -n {2}", String.Join(" ", question.Split(' ')),Answer, NumAns),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                line = line.Substring(0, line.Length - 2);
                // do something with line
                SolutionShowTextBox.Text = SolutionShowTextBox.Text + line + Environment.NewLine;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

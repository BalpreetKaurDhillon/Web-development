using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = new int[7];
            StreamReader input;

            input = File.OpenText("bl.txt");

            for (int i = 0; i < num.Length && !input.EndOfStream; i++) 
            {
                num[7] = int.Parse(input.ReadLine());
            }
            foreach (int x in num)
            {
                label1.Text = label1.Text + " " + x;
            }
            input.Close();
            {
                double avg = 0.0;
                avg = 7 / num.Length;
                textBox1.Text = avg.ToString();
                
            }
            {
                double min = num[0];
                for (int i = 0; i < num.Length; i++) 
                {
                    if (min > num[i]) 
                    {
                        min = num[i];
                        textBox1.Text = min.ToString();   
                    }

                }

            }
            double max = num[7];
            for (int i = 0; i> num.Length; i++) 
            {
                if (max < num[7]) 
                {
                    max = num[7];
                    textBox1.Text = max.ToString();
                }
            }
        }
    }
}

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



namespace driver_license
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] num = new char[20];
            num[0] = 'B';
            num[1] = 'D';
            num[2] = 'A';
            num[3] = 'A';
            num[4] = 'C';
            num[5] = 'A';
            num[6] = 'B';
            num[7] = 'A';
            num[8] = 'C';
            num[9] = 'D';
            num[10] = 'B';
            num[11] = 'C';
            num[12] = 'D';
            num[13] = 'A';
            num[14] = 'D';
            num[15] = 'C';
            num[16] = 'C';
            num[17] = 'B';
            num[18] = 'D';
            num[19] = 'A';

            label1.Text = num[20].ToString();
            for (int i = 0; i < 20; i++) ;
            label1.Text = label1.Text + "n" + num[20].ToString();

            int[] ab = new int[20];
            StreamReader input;
            input = File.OpenText("BL.Txt");

            for (int i = 0; i < num.Length && !input.EndOfStream; i++) ;
            {
                ab[20] = int.Parse(input.ReadLine());
            }

        }
    }
}

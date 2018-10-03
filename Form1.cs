using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        string classA, classB, classC;
        double A, B, C;
        class=textBox1.Text;
             classA = textBox2.Text;
             classB = textBox2.Text;
            classC = textBox3.Text;
            //double to 
            A = double.Parse(classA);
            B = double.Parse(classB);
            C = double.Parse(classC);
        //calculations
        double cal1;
        call = A* 15;
            textBox4.Text = call.ToString("C");

            double cal2;
        cal2 = B* 12;
            textBox5.Text = cal2.ToString("C");

            double cal3;
        cal3 = C* 9;
            textBox6.Text = cal3.ToString("C");

            double total;
        total = cal1 + cal2 + cal3;
            textBox7.Text= total.ToString("C");


        }
        catch(Exception ab)
            {
            MessageBox.Show("Handle Exception");
        }
    {
            //clear content
            text.Box1.Text="";
            text.Box2.Text="";
            text.Box3.Text="";
            text.Box4.Text="";
            text.Box5.Text="";
              text.Box6.Text="";
         text.Box7.Text="";
        }


private void button3_Click; (object sender, EventArgs e)
    {
            //close the application
            this.Close();
                }






private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

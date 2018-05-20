using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verse
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Program.Get.verse(1,1);
            comboBox1.SelectedIndex = (int)myCustomNumericBox1.Value - 1;
            myCustomNumericBox2.Maximum = Program.Get.vCount(myCustomNumericBox1.Value);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void myCustomNumericBox1_ValueChanged_1(object sender, EventArgs e)
        {
            myCustomNumericBox2.Maximum = Program.Get.vCount(myCustomNumericBox1.Value);
            myCustomNumericBox2.Value = 1;
            textBox1.Text = Program.Get.verse(myCustomNumericBox1.Value, myCustomNumericBox2.Value);
            comboBox1.SelectedIndex = (int)myCustomNumericBox1.Value - 1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (myCustomNumericBox2.Value <= 1)
            {
                if (myCustomNumericBox1.Value > 1)
                {
                    myCustomNumericBox1.Value--;
                    myCustomNumericBox2.Value = Program.Get.vCount(myCustomNumericBox1.Value);
                    textBox1.Text = Program.Get.verse(myCustomNumericBox1.Value, myCustomNumericBox2.Value);
                }
            }
            else
            {
                myCustomNumericBox2.Value--;
                textBox1.Text = Program.Get.verse(myCustomNumericBox1.Value, myCustomNumericBox2.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(myCustomNumericBox2.Value >= Program.Get.vCount(myCustomNumericBox1.Value)){
                if (myCustomNumericBox1.Value < 114) {
                    myCustomNumericBox1.Value++;
                    myCustomNumericBox2.Value = 1;
                    textBox1.Text = Program.Get.verse(myCustomNumericBox1.Value, myCustomNumericBox2.Value);
                }
            }
            else
            {
                    myCustomNumericBox2.Value++;
                    textBox1.Text = Program.Get.verse(myCustomNumericBox1.Value, myCustomNumericBox2.Value);
            }
           

        }

        private void myCustomNumericBox2_ValueChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = Program.Get.verse(myCustomNumericBox1.Value, myCustomNumericBox2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
                textBox1.Text = Program.Get.verse(myCustomNumericBox1.Value, myCustomNumericBox2.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCustomNumericBox1.Value = comboBox1.SelectedIndex + 1;
            myCustomNumericBox2.Value = 1;
        }

    }
}

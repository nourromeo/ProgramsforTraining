using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mudol2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {

            int text1 = int.Parse(LottoradTextBox1.Text);
            int text2 = int.Parse(LottoradTextBox2.Text);
            int text3 = int.Parse(LottoradTextBox3.Text);
            int text4 = int.Parse(LottoradTextBox4.Text);
            int text5 = int.Parse(LottoradTextBox5.Text);
            int text6 = int.Parse(LottoradTextBox6.Text);
            int text7 = int.Parse(LottoradTextBox7.Text);

            int Min = 1;
            int Max = 36;

            int[] numbers = new int[7];

            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(Min, Max);                
                AntalDragTextBox.Text = numbers[i].ToString();
                Console.WriteLine(numbers[i]);

            }

 



        }




        private void LottoradLabel_Click(object sender, EventArgs e)
        {

        }

        private void AntalDragLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LottoradTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LottoradTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LottoradTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FemRattTextBox_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void SexRattTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SjuRattTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void theText_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void theText_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Mudol2F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "hello world",
                "Viktigt Information",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            var result = Interaction.InputBox(
                "do you want to hide?", 
                "Input"
            );

            MessageBox.Show($"your answer was {result} ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

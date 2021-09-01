using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Miniräknare
{
    public partial class CalculatorForm : Form
    {
        int firstNumber = 0;
        String Operation = "";
        bool isClicked = false;
        int MaxValue = int.MaxValue;
        int resultat;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        // varje gång jag tycker på knappen kommer den nummer visas i textboxen
    private void button_Click(object sender, EventArgs e)
        {
            try
            {
                if (isClicked)
                {
                    textBox.Clear();
                }

                isClicked = false;
                Button button = (Button)sender;
                textBox.Text = textBox.Text + button.Text;
                numberLabel.Text = button.Text;
            }
            catch (Exception)
            {
                textBox.Text = "";
            }


        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                Operation = button.Text;
                firstNumber = int.Parse(textBox.Text); // här sparas den siffran man får från textbox
                numberLabel.Text = firstNumber + " " + Operation;
                isClicked = true;
            }
            catch (Exception ee)
            {
                textBox.Text = "";
            }

        }

        // här tömma textboxen när man trycker på C
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox.Text = " ";
            numberLabel.Text = " ";

        }

        // använder switch för den matimatiska räkningar
        private void buttonLikaMed_Click(object sender, EventArgs e)
        {
            checked // använder check metod för att kolla om intger når max värdet eller inte. sedan sckiar man en error medelande
            {
                try
                {                     
                    switch (Operation)
                    {                 
                        case "+":

                            resultat = (firstNumber + int.Parse(textBox.Text));
                            textBox.Text = resultat.ToString();
                            break;
                        case "-":
                            resultat = (firstNumber - int.Parse(textBox.Text));
                            textBox.Text = resultat.ToString();
                            break;
                        case "x":
                            resultat = (firstNumber * int.Parse(textBox.Text));
                            textBox.Text = resultat.ToString();
                            break;
                        case "/":
                            if (int.Parse(textBox.Text) != 0)
                            {
                                resultat = (firstNumber / int.Parse(textBox.Text));
                                textBox.Text = resultat.ToString();
                            }
                            else
                            {
                                textBox.Text = "Error!!";
                            }
                            break;
                        default:
                            break;
                    }

                }
                catch
                {
                    // textBox.Text = "";
                    textBox.Text = "ERROR!";
                }
            }
 

        }
    }
}

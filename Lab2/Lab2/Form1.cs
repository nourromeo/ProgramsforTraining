using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private int[] textBox = new int[7];
        List<int> lottoNummerList = new List<int>();
        List<int> randNummerList = new List<int>();
        Random rand = new Random();

        int slumptal1, slumptal2, slumptal3, slumptal4, slumptal5, slumptal6, slumptal7;
        int femRatt = 0, sexRatt = 0, sjuRatt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // här byggar jag starta lotto button..
        private void StartaLotto_Click(object sender, EventArgs e)
        {
            int Test;

            if (TextBoxInput() == false)
            {
                return;
            }

            try
            {
                if (AntalDragTextBox.Text.Length == 0)
                {
                    MessageBox.Show(" Du måste ge antal dragning! ");
                }
                else
                {
                    if (!int.TryParse(AntalDragTextBox.Text, out Test) || int.Parse(AntalDragTextBox.Text) <= 0)
                    {
                        MessageBox.Show("Antal dragning måste vara en hel positiv tal.");
                    }
                    else
                    {
                        int antal = int.Parse(AntalDragTextBox.Text);

                        for (int i = 1; i <= 7; i++)
                        {
                            lottoNummerList.Add(i);
                        }

                        femRatt = 0;
                        sexRatt = 0;
                        sjuRatt = 0;
                        FemRattTextBox.Text = "0";
                        SexRattTextBox.Text = "0";
                        SjuRattTextBox.Text = "0";

                        for (int i = 0; i < antal; i++)
                        {
                            GenereraSlumptal();
                            HittaRattNummer(jamforLotto());
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Något gick fel, starta om programet!");
            }

        }

        // för att läsa textbox och sedan se till att siffror är unika.
        private bool TextBoxInput()
        {
            try
            {
                textBox[0] = int.Parse(textBox1.Text);
                textBox[1] = int.Parse(textBox2.Text);
                textBox[2] = int.Parse(textBox3.Text);
                textBox[3] = int.Parse(textBox4.Text);
                textBox[4] = int.Parse(textBox5.Text);
                textBox[5] = int.Parse(textBox6.Text);
                textBox[6] = int.Parse(textBox7.Text);

                for (int i = 0; i <= 6; i++)
                {
                    if (textBox[i] > 35 || textBox[i] == 0 || Nummer(textBox[i], i))
                        throw new Exception();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show("Fel! Vänligen välj unika nr mellan 1 och 35.", "Viktigt Medelande");
                return false;
            }
            return true;
        }

        private bool Nummer(int i, int j)
        {
            if (textBox.Contains(i) && (Array.IndexOf(textBox, i) != j))
            {
                return true;
            }

            return false;
        }

        // ett sätt att skapa en slumptal siffror, genom while kotrollerar om nummret är dubbel.
        private void GenereraSlumptal()
        {
            randNummerList.Clear();

            //första nummer :
            slumptal1 = rand.Next(1, 36);

            // andra nummer :           
            slumptal2 = rand.Next(1, 36);
            while (slumptal2 == slumptal1)
                slumptal2 = rand.Next(1, 36);

            // tredje nummer :
            slumptal3 = rand.Next(1, 36);
            while ((slumptal3 == slumptal1) || (slumptal3 == slumptal2))
                slumptal3 = rand.Next(1, 36);

            //fjärde nummer :
            slumptal4 = rand.Next(1, 36);
            while ((slumptal4 == slumptal1) || (slumptal4 == slumptal2) || (slumptal4 == slumptal3))
                slumptal4 = rand.Next(1, 36);

            // femte nummer:
            slumptal5 = rand.Next(1, 36);
            while ((slumptal5 == slumptal1) || (slumptal5 == slumptal2) || (slumptal5 == slumptal3) || (slumptal5 == slumptal4))
                slumptal5 = rand.Next(1, 36);

            //sjätte nummer :
            slumptal6 = rand.Next(1, 36);
            while ((slumptal6 == slumptal1) || (slumptal6 == slumptal2) || (slumptal6 == slumptal3) || (slumptal6 == slumptal4) || (slumptal6 == slumptal5))
                slumptal6 = rand.Next(1, 36);

            // sjunde nemmer :
            slumptal7 = rand.Next(1, 36);
            while ((slumptal7 == slumptal1) || (slumptal7 == slumptal2) || (slumptal7 == slumptal3) || (slumptal7 == slumptal4) || (slumptal7 == slumptal5) || (slumptal7 == slumptal6))
                slumptal7 = rand.Next(1, 36);

            randNummerList.Add(slumptal1);
            randNummerList.Add(slumptal2);
            randNummerList.Add(slumptal3);
            randNummerList.Add(slumptal4);
            randNummerList.Add(slumptal5);
            randNummerList.Add(slumptal6);
            randNummerList.Add(slumptal7);

        }

        /* 
         * här bygger jag en jamförelse metod, 
         * den jamföra mellan två lister och 
         * returerar bara de som finns på både listor
         */
        private int jamforLotto()
        {
            IEnumerable<int> jamforList;
            jamforList = lottoNummerList.Except(randNummerList);

            int rattNummer = jamforList.Count();

            return rattNummer;

        }
        /*
         * här fyller man den rätt textbox.
         */
        private void HittaRattNummer(int rattNummer)
        {
            switch (rattNummer)
            {
                case 0:
                    sjuRatt++;
                    SjuRattTextBox.Text = sjuRatt.ToString();
                    break;
                case 1:
                    sexRatt++;
                    SexRattTextBox.Text = sexRatt.ToString();
                    break;
                case 2:
                    femRatt++;
                    FemRattTextBox.Text = femRatt.ToString();
                    break;
                default:
                    break;
            }

        }

    }
}

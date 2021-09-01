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
using System.IO;

namespace Lab3___texteditor
{
    public partial class textEditor : Form
    {
        static String fileName;
        static String sfileName;
        bool textHasChanged = false;

        public textEditor()
        {
            InitializeComponent();
        }
        
        // menu action
        private void newMenu_Click(object sender, EventArgs e)
        {
            try
            {
                    if (!String.IsNullOrEmpty(richTextBox.Text))
                    {
                        DialogResult dialogNew = MessageBox.Show("Do you want to save before starting a new file?", "Warning!!", MessageBoxButtons.YesNoCancel);

                        if (dialogNew == DialogResult.Yes)
                        {
                            SaveAsFile();
                            NewFile();
                        }
                        else if (dialogNew == DialogResult.No)
                        {
                            NewFile();
                        }
                    }
                    else
                    {
                        NewFile();
                    }


            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error starting a new file: " + ioe.Message);
            }
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (textHasChanged == true)
                {
                    if (!String.IsNullOrEmpty(richTextBox.Text))
                    {
                        DialogResult dialogSaveBeforeClose = MessageBox.Show($"Do you want to save the changing in {this.Text}?", "Warning!", MessageBoxButtons.YesNoCancel);

                        if (dialogSaveBeforeClose == DialogResult.Yes)
                        {
                            SaveFile();
                            OpenFile();
                        }
                        else if (dialogSaveBeforeClose == DialogResult.No)
                        {
                            OpenFile();
                        }
                    }
                    else
                    {
                        OpenFile();
                    }

                }
                else
                {
                    OpenFile();
                }

            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error opening the file: " + ioe.Message);
            }

        }

        // Om filen är inte sparat, spara den som en ny. annars bara spara
        private void saveMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    SaveAsFile();
                }
                else
                {
                    SaveFile();

                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error saving the file: " + ioe.Message);
            }

        }

        private void saveAsMenu_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAsFile();
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error saving the file: " + ioe.Message);
            }
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textHasChanged == true)
                {
                    if (!String.IsNullOrEmpty(richTextBox.Text))
                    {
                        DialogResult dialogSaveBeforeClose = MessageBox.Show($"Do you want to save the changing in {this.Text}?", "Warning!", MessageBoxButtons.YesNoCancel);

                        if (dialogSaveBeforeClose == DialogResult.Yes)
                        {
                            SaveFile();
                            CloseTheFile();
                        }
                        else if (dialogSaveBeforeClose == DialogResult.No)
                        {
                            CloseTheFile();
                        }

                    }
                    else
                    {
                        CloseTheFile();
                    }

                }
                else
                {
                    CloseTheFile();
                }


            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error closing the file: " + ioe.Message);
            }

        }

        private void textEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (textHasChanged == true)
                {
                    if (!String.IsNullOrEmpty(richTextBox.Text))
                    {
                        DialogResult dialogSaveBeforeClose = MessageBox.Show($"Do you want to save the changing in {this.Text}?", "Warning!", MessageBoxButtons.YesNoCancel);

                        if (dialogSaveBeforeClose == DialogResult.Yes)
                        {
                            SaveFile();
                            CloseTheFile();
                        }
                        else if (dialogSaveBeforeClose == DialogResult.No)
                        {
                            CloseTheFile();
                        }
                        else if (dialogSaveBeforeClose == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    else
                    {
                        CloseTheFile();
                    }                   
                }
                else
                {
                    CloseTheFile();
                }


            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error closing the file: " + ioe.Message);
            }
        }





        // metoder för menyer..

        //starta ny textbox genom att rensa innehållet
        private void NewFile()
        {
            richTextBox.Clear();
            this.Text = "Namnlös - Text Editor";
        }

        // öppna en befintligt fil
        private void OpenFile()
        {
    /*

            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                OpenFileDialog OpenTheFile = new OpenFileDialog();
                
                OpenTheFile.Filter = "files (*.txt)| *.txt";

                if (OpenTheFile.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.LoadFile(OpenTheFile.FileName, RichTextBoxStreamType.RichText); // plain för computer och rich för program
                    richTextBox.Rtf = richTextBox.Text;
                }
            }
    */

            DialogResult openFlie = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "files (*.txt)| *.txt";


            if (openFlie == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                richTextBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                sfileName = openFileDialog1.SafeFileName;
                this.Text = sfileName;
                //this.Text = openFileDialog1.SafeFileName + "- Text Editor";
            }
        }

        // spara i en samma fil metod, om filen är ny, då ska man skapa en ny fil och spara i den.
        private void SaveFile()
        {
            if (fileName !=null)
            {
                richTextBox.SaveFile(fileName);
                this.Text = sfileName;
            }
            else
            {
                saveFileDialog1.Filter = "files (*.txt)|*.txt";
                DialogResult saveFlie = saveFileDialog1.ShowDialog();

                if (saveFlie == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                    richTextBox.SaveFile(fileName);
                    sfileName = Path.GetFileName(fileName);
                    this.Text = sfileName;
                    // this.Text = saveFileDialog1.FileName.Substring(31) + "- Text Editor";
                }
            }
        }

        // spara som ..
        private void SaveAsFile()
        {
            saveFileDialog1.Filter = "files (*.txt)|*.txt";
            DialogResult saveFlie = saveFileDialog1.ShowDialog();

            if (saveFlie == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                richTextBox.SaveFile(fileName);
                sfileName = Path.GetFileName(fileName);
                this.Text = sfileName;
                // this.Text = saveFileDialog1.FileName.Substring(31) + "- Text Editor";
            }
        }

        // här för att räkna antal ord, (jag fick hjälp av en kompis)
        private void CountWords()
        {
            char[] space = { ' ', '\r', '\n' };
            int words = richTextBox.Text.Split(space, StringSplitOptions.RemoveEmptyEntries).Length;
            WordsCount.Text = "Words: " + words.ToString();
        }

        // här för att räkna antal rader, (jag fick hjälp av en kompis)
        private void CountRow()
        {
            char[] space = { '\n' };
            int rows = richTextBox.Text.Split(space, StringSplitOptions.None).Length;
            StatusRow.Text = "Rows: " + rows.ToString();
        }

        // här för att räkna antal tecken med och utan mellanslag
        private void CountLetterWithSpace()
        {
            // med mellanslag
            int letterWithSpace = richTextBox.Text.Length; //Replace("\n", "")
            StatusLetterWithSpace.Text = "Letter/space: " + letterWithSpace.ToString();
        }

        // jag fick veta om Replace metod av (Soner Gönül), available: https://stackoverflow.com/questions/16608691/length-of-string-without-spaces-c 
        private void CountLetter()
        {
            char[] space = { '\r' };
            int letter = richTextBox.Text.Replace("\n", "").Replace(" ", "").Length;
            StatusLetter.Text = "Letter: " + letter.ToString();
        }

            private void CloseTheFile()
        {
            Application.Exit();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

            CountWords();
            CountRow();
            CountLetterWithSpace();
            CountLetter();

           if (sfileName != null)
            {
                textHasChanged = true;
                this.Text = sfileName + "*";
            }
            else
            {
                this.Text = "Namnlös - Text Editor*";
            }

        }
    }
}


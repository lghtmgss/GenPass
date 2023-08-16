using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenPass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len_pas = (int)numericUpDown1.Value;
            int quan = (int)numericUpDown2.Value;
            bool symbols = checkBox1.Checked;
            Random rnd = new Random();
            Random type = new Random();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] letters2 = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] sym = "!%^<>?)($".ToCharArray();
            for (int j = 0; j < quan; j++)
            {
                for (int i = 0; i < len_pas; i++)
                {
                    int chance3 = type.Next(0, 3);
                    int chance2 = type.Next(0, 2);
                    if (symbols == true & chance3 == 1)
                    {
                        char sym_num = sym[rnd.Next(0, sym.Length)];
                        richTextBox1.Text += sym_num;
                        continue;
                    }
                    if (chance3 == 0)
                    {
                        int num = rnd.Next(0, 10);
                        richTextBox1.Text += num;
                        continue;
                    }
                    else if (chance2 == 0)
                    {
                        char letter_num2 = letters2[rnd.Next(0, letters2.Length)];
                        richTextBox1.Text += letter_num2;
                        continue;
                    }
                    else
                    {
                        char letter_num = letters[rnd.Next(0, letters.Length)];
                        richTextBox1.Text += letter_num;
                        continue;
                    }
                  
                }
                richTextBox1.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}

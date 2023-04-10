using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зачётное_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox1.Text;
                char[] strWords = { 'а', 'о', 'у', 'э', 'ы', 'я', 'ё', 'у', 'ю', 'и', 'А', 'О', 'У', 'Э', 'Ы', 'Я', 'Ё', 'У', 'Ю', 'И' };
                int wordsCount = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (strWords.Contains(str[i]))
                    {
                        wordsCount++;
                    }
                }
                textBox2.Text = wordsCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }                       
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = textBox1.Text;
            string insertText = textBox2.Text;
            string bookTitle = partBookTitle.Insert(3, insertText);
            listBox1.Items.Add(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            bookTitle = bookTitle.Remove(2);
            listBox1.Items.Add(bookTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            bookTitle = bookTitle.Substring(5, 3);
            listBox1.Items.Add(bookTitle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            int i = str2.IndexOf(str1);
            if (i >= 0) MessageBox.Show(str1 + " входит в строку " + str2);
            else MessageBox.Show(str1 + " не входит в строку " + str2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog;
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}

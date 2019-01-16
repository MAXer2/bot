using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butt_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(textBox1.Text + "\n");


            switch (textBox1.Text)
            {
                case "Привет":
                    richTextBox1.AppendText("Здравствуйте"+ "\n");
                    break;
                case "Пока":
                    richTextBox1.AppendText("прощайте,сударь" + "\n");
                    break;
                case "Как дела?":
                    richTextBox1.AppendText("норм" + "\n");
                    break;
                case "ты даун":
                    richTextBox1.AppendText("сам ты даун " + "\n");
                    break;

                case "Расскажи анекдот":
                    richTextBox1.AppendText("Самую большую щуку весом в 50 килограмм, поймал рыболов из Рязани. Это на 7 кг больше, чем нап@здел предыдущий рекордсмен." + "\n");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 dsfgdfg = new Form2();
            dsfgdfg.ShowDialog();
        }
    }
}

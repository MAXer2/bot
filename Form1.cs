using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            richTextBox1.Lines = File.ReadAllLines("../../2131.txt");
            /*textBox1.Text = "Ваня, брось рисовать";
            textBox1.Size = new Size(450, 50);

            button.BackColor = Color.Maroon;
            button.Font = new Font("Arial", 12);*/
        }

        private void butt_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ваня, да утихни уже!!!");

            richTextBox1.AppendText(textBox1.Text + "\n");

            /*if (textBox1.Text == "Привет")
            {
                richTextBox1.AppendText("Здравствуйте" + "\n");
            }
            else if (textBox1.Text == "Как дела?")
            {
                richTextBox1.AppendText("норм" + "\n");
            }*/

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Тварь!");
        }
    }
}

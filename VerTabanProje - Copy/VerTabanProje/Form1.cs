using System;
using Npgsql;
namespace VerTabanProje
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("error");
            }

            else if (textBox1.Text == "12358134")
            {
                if (textBox2.Text == "564738")
                { 
                Form2 fr2 = new Form2();
                fr2.ShowDialog();
                }
                else MessageBox.Show("sifreyi yanlis girdiniz");
            }
            else if (textBox1.Text == "12248248")
            {
                if (textBox2.Text == "563000")
                {
                    Form2 fr2 = new Form2();
                    fr2.ShowDialog();
                }
                else MessageBox.Show("sifreyi yanlis girdiniz");
            }
            else if (textBox1.Text == "63188640")
            {
                if (textBox2.Text == "739123")
                {
                    Form2 fr2 = new Form2();
                    fr2.ShowDialog();
                }
                else MessageBox.Show("sifreyi yanlis girdiniz");
            }
            else if (textBox1.Text == "98178156")
            {
                if (textBox2.Text == "897291")
                {
                    Form2 fr2 = new Form2();
                    fr2.ShowDialog();
                }
                else MessageBox.Show("sifreyi yanlis girdiniz");
            }
            else if (textBox1.Text == "62810159")
            {
                if (textBox2.Text == "963852")
                {
                    Form2 fr2 = new Form2();
                    fr2.ShowDialog();
                }
                else MessageBox.Show("sifreyi yanlis girdiniz");
            }
            else MessageBox.Show("Hatali giris");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerTabanProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Form3 fr3 = new Form3();
                    fr3.ShowDialog();
                    //insert
                    break;
                case 1:
                    Form4 fr4 = new Form4();
                    fr4.ShowDialog();
                    //update
                    break;
                case 2:
                    Form5 fr5=new Form5();
                    fr5.ShowDialog();
                    //delete
                    break;
                case 3:
                    //select
                    Form6 fr6 = new Form6();
                    fr6.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Please chose one on these items");
                    break;
            }
        }
    }
}

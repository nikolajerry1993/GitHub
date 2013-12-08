using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private double bmi;

        double izracunajBMI(){
            if ((Convert.ToDouble(richTextBox1.Text) < 1.2)||(Convert.ToDouble(richTextBox1.Text) > 2.4)) {
                MessageBox.Show("Oo you entered the wrong values, please enter 1.20-2.40 m");
                return 0;
            }
            if ((Convert.ToDouble(richTextBox2.Text) < 30) || (Convert.ToDouble(richTextBox2.Text) > 200))
            {
                MessageBox.Show("Oo you entered the wrong values, please enter 30-200 kg");
                return 0;
            }
            double rezultat = (Convert.ToDouble(richTextBox2.Text)) / (Convert.ToDouble(richTextBox1.Text)* Convert.ToDouble(richTextBox1.Text));
            bmi = rezultat;
            richTextBox3.Text = Convert.ToString(rezultat);
            richTextBox3.Refresh();
            
            return rezultat;

        }
        void ispisiBMIKategoriju(double bmi)
        {
            if (bmi <= 15)
               label3.Text =  "     You are anorexic. \n   Go eat or you will die!";
            label3.Show();
            label3.Refresh();
            if ((bmi > 15) && (bmi <= 18.5))
                label3.Text = "         You are slim. \n        Get some weight";
            label3.Show();
            label3.Refresh();
            if ((bmi > 18.5) && (bmi <= 25))
                label3.Text = " You are normal. Are you?";
            label3.Show();
            label3.Refresh();
            if ((bmi > 25) && (bmi <= 30))
                label3.Text = "      You are almost fat. \n              Watch out!";
            label3.Show();
            label3.Refresh();
            if ((bmi > 30) && (bmi <= 40))
                label3.Text = "           You are fat. \n       Do some excercises";
            label3.Show();
            label3.Refresh();
            if (bmi > 40)
                label3.Text = "         You are a fatass. \n      Get out of the house!";
            label3.Show();
            label3.Refresh();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsPunctuation(e.KeyChar) || Char.IsDigit(e.KeyChar)) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                if (e.KeyChar == '.')
                {
                    
                e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text =="" || richTextBox2.Text=="")
            {
                MessageBox.Show("You didn't enter all values");
            }
            else
            {
                izracunajBMI();
                ispisiBMIKategoriju(bmi);
                


            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            richTextBox2.ResetText();
            richTextBox3.ResetText();
            label3.Text = "";
        }
    }
}

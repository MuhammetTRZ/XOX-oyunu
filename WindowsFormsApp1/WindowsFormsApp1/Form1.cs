using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Text = "X";
            if (label1.Text=="X")
            {
                bt.Text = "X";
                bt.Enabled = false;
                label1.Text = "O";
            }
            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                label1.Text="X";
            }

            if (button1.Text=="X"&&button2.Text=="X"&&button3.Text=="X")
            {
                MessageBox.Show("KAZANAN X ");
                oyunbitis();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("KAZANAN X ");
                oyunbitis();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN X ");
                oyunbitis();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN X ");
                oyunbitis();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("KAZANAN X ");
                oyunbitis();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN X ");
                oyunbitis();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN X ");
                oyunbitis();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN X ");
                oyunbitis();
            }
            /////
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN O ");
                oyunbitis();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("KAZANAN O ");
                oyunbitis();
            }
            if (button7.Text == "0" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN O ");
                oyunbitis();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN O ");
                oyunbitis();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("KAZANAN O ");
                oyunbitis();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN 0 ");
                oyunbitis();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN 0 ");
                oyunbitis();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN O ");
                oyunbitis();
            }
            if (button1.Text!=""&& button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Oyun berabere");
                oyunbitis();
            }


        }
        private void oyunbitis()
        {
            label1.Text = "X";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
    }
}
